using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAccountHolderBalanceError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostAccountHolderBalanceError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostAccountHolderBalanceError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostAccountHolderBalanceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostAccountHolderBalanceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAccountHolderBalanceErrorResponse : IErrorResponse<PostAccountHolderBalanceError>
{
    public static PostAccountHolderBalanceErrorResponse Instance { get; } = new();

    private PostAccountHolderBalanceErrorResponse()
    {
    }

    public Task<PostAccountHolderBalanceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAccountHolderBalanceError.Create(response, ct);
}

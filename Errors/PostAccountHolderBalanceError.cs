using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAccountHolderBalanceError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostAccountHolderBalanceError(Optional<ServiceError1> serviceError1Value, Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostAccountHolderBalanceError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostAccountHolderBalanceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostAccountHolderBalanceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
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

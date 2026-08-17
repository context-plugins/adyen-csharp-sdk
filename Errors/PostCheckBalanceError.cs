using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCheckBalanceError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCheckBalanceError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCheckBalanceError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCheckBalanceError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCheckBalanceError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCheckBalanceErrorResponse : IErrorResponse<PostCheckBalanceError>
{
    public static PostCheckBalanceErrorResponse Instance { get; } = new();

    private PostCheckBalanceErrorResponse()
    {
    }

    public Task<PostCheckBalanceError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCheckBalanceError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCloseStoresError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCloseStoresError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCloseStoresError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCloseStoresError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCloseStoresError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCloseStoresErrorResponse : IErrorResponse<PostCloseStoresError>
{
    public static PostCloseStoresErrorResponse Instance { get; } = new();

    private PostCloseStoresErrorResponse()
    {
    }

    public Task<PostCloseStoresError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCloseStoresError.Create(response, ct);
}

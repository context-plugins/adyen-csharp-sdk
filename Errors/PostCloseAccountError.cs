using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCloseAccountError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCloseAccountError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCloseAccountError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCloseAccountError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCloseAccountError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCloseAccountErrorResponse : IErrorResponse<PostCloseAccountError>
{
    public static PostCloseAccountErrorResponse Instance { get; } = new();

    private PostCloseAccountErrorResponse()
    {
    }

    public Task<PostCloseAccountError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCloseAccountError.Create(response, ct);
}

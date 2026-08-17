using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAuthoriseError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostAuthoriseError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostAuthoriseError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostAuthoriseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostAuthoriseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAuthoriseErrorResponse : IErrorResponse<PostAuthoriseError>
{
    public static PostAuthoriseErrorResponse Instance { get; } = new();

    private PostAuthoriseErrorResponse()
    {
    }

    public Task<PostAuthoriseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAuthoriseError.Create(response, ct);
}

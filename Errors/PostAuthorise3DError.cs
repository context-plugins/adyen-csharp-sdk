using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAuthorise3DError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostAuthorise3DError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostAuthorise3DError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostAuthorise3DError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostAuthorise3DError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAuthorise3DErrorResponse : IErrorResponse<PostAuthorise3DError>
{
    public static PostAuthorise3DErrorResponse Instance { get; } = new();

    private PostAuthorise3DErrorResponse()
    {
    }

    public Task<PostAuthorise3DError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAuthorise3DError.Create(response, ct);
}

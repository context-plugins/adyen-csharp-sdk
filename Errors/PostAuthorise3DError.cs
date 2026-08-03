using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAuthorise3DError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostAuthorise3DError(Optional<ServiceError1> serviceError1Value, Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostAuthorise3DError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostAuthorise3DError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostAuthorise3DError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
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

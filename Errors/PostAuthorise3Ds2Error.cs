using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostAuthorise3Ds2Error : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostAuthorise3Ds2Error(Optional<ServiceError1> serviceError1Value, Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostAuthorise3Ds2Error AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostAuthorise3Ds2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostAuthorise3Ds2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostAuthorise3Ds2ErrorResponse : IErrorResponse<PostAuthorise3Ds2Error>
{
    public static PostAuthorise3Ds2ErrorResponse Instance { get; } = new();

    private PostAuthorise3Ds2ErrorResponse()
    {
    }

    public Task<PostAuthorise3Ds2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostAuthorise3Ds2Error.Create(response, ct);
}

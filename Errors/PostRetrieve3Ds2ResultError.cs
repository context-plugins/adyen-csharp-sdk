using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostRetrieve3Ds2ResultError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostRetrieve3Ds2ResultError(Optional<ServiceError1> serviceError1Value, Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostRetrieve3Ds2ResultError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostRetrieve3Ds2ResultError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostRetrieve3Ds2ResultError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostRetrieve3Ds2ResultErrorResponse : IErrorResponse<PostRetrieve3Ds2ResultError>
{
    public static PostRetrieve3Ds2ResultErrorResponse Instance { get; } = new();

    private PostRetrieve3Ds2ResultErrorResponse()
    {
    }

    public Task<PostRetrieve3Ds2ResultError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostRetrieve3Ds2ResultError.Create(response, ct);
}

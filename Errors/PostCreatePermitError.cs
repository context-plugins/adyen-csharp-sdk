using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCreatePermitError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCreatePermitError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCreatePermitError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCreatePermitError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCreatePermitError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCreatePermitErrorResponse : IErrorResponse<PostCreatePermitError>
{
    public static PostCreatePermitErrorResponse Instance { get; } = new();

    private PostCreatePermitErrorResponse()
    {
    }

    public Task<PostCreatePermitError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCreatePermitError.Create(response, ct);
}

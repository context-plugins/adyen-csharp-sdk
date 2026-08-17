using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostChangeStatusError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostChangeStatusError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostChangeStatusError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostChangeStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostChangeStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostChangeStatusErrorResponse : IErrorResponse<PostChangeStatusError>
{
    public static PostChangeStatusErrorResponse Instance { get; } = new();

    private PostChangeStatusErrorResponse()
    {
    }

    public Task<PostChangeStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostChangeStatusError.Create(response, ct);
}

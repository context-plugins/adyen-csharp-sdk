using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostCreateNotificationConfigurationError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostCreateNotificationConfigurationError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostCreateNotificationConfigurationError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostCreateNotificationConfigurationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostCreateNotificationConfigurationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostCreateNotificationConfigurationErrorResponse : IErrorResponse<PostCreateNotificationConfigurationError>
{
    public static PostCreateNotificationConfigurationErrorResponse Instance { get; } = new();

    private PostCreateNotificationConfigurationErrorResponse()
    {
    }

    public Task<PostCreateNotificationConfigurationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostCreateNotificationConfigurationError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostGetNotificationConfigurationError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PostGetNotificationConfigurationError(Optional<ServiceError> serviceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PostGetNotificationConfigurationError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PostGetNotificationConfigurationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PostGetNotificationConfigurationError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostGetNotificationConfigurationErrorResponse : IErrorResponse<PostGetNotificationConfigurationError>
{
    public static PostGetNotificationConfigurationErrorResponse Instance { get; } = new();

    private PostGetNotificationConfigurationErrorResponse()
    {
    }

    public Task<PostGetNotificationConfigurationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostGetNotificationConfigurationError.Create(response, ct);
}

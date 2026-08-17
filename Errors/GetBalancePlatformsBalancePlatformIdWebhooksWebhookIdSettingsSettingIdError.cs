using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse : IErrorResponse<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError>
{
    public static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse Instance { get; } = new();

    private GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse()
    {
    }

    public Task<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.Create(response, ct);
}

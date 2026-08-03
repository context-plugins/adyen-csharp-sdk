using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError : ApiError
{
    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId400Error1> _balancePlatformsWebhooksSettingsSettingId400Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId401Error1> _balancePlatformsWebhooksSettingsSettingId401Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId403Error1> _balancePlatformsWebhooksSettingsSettingId403Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId404Error1> _balancePlatformsWebhooksSettingsSettingId404Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId422Error1> _balancePlatformsWebhooksSettingsSettingId422Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettingsSettingId500Error1> _balancePlatformsWebhooksSettingsSettingId500Error1Value;

    private GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError(Optional<BalancePlatformsWebhooksSettingsSettingId400Error1> balancePlatformsWebhooksSettingsSettingId400Error1Value,
        Optional<BalancePlatformsWebhooksSettingsSettingId401Error1> balancePlatformsWebhooksSettingsSettingId401Error1Value,
        Optional<BalancePlatformsWebhooksSettingsSettingId403Error1> balancePlatformsWebhooksSettingsSettingId403Error1Value,
        Optional<BalancePlatformsWebhooksSettingsSettingId404Error1> balancePlatformsWebhooksSettingsSettingId404Error1Value,
        Optional<BalancePlatformsWebhooksSettingsSettingId422Error1> balancePlatformsWebhooksSettingsSettingId422Error1Value,
        Optional<BalancePlatformsWebhooksSettingsSettingId500Error1> balancePlatformsWebhooksSettingsSettingId500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balancePlatformsWebhooksSettingsSettingId400Error1Value = balancePlatformsWebhooksSettingsSettingId400Error1Value;
        _balancePlatformsWebhooksSettingsSettingId401Error1Value = balancePlatformsWebhooksSettingsSettingId401Error1Value;
        _balancePlatformsWebhooksSettingsSettingId403Error1Value = balancePlatformsWebhooksSettingsSettingId403Error1Value;
        _balancePlatformsWebhooksSettingsSettingId404Error1Value = balancePlatformsWebhooksSettingsSettingId404Error1Value;
        _balancePlatformsWebhooksSettingsSettingId422Error1Value = balancePlatformsWebhooksSettingsSettingId422Error1Value;
        _balancePlatformsWebhooksSettingsSettingId500Error1Value = balancePlatformsWebhooksSettingsSettingId500Error1Value;
    }

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId400Error1(BalancePlatformsWebhooksSettingsSettingId400Error1 value) =>
        new(Optional<BalancePlatformsWebhooksSettingsSettingId400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId401Error1(BalancePlatformsWebhooksSettingsSettingId401Error1 value) =>
        new(default,
            Optional<BalancePlatformsWebhooksSettingsSettingId401Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId403Error1(BalancePlatformsWebhooksSettingsSettingId403Error1 value) =>
        new(default,
            default,
            Optional<BalancePlatformsWebhooksSettingsSettingId403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId404Error1(BalancePlatformsWebhooksSettingsSettingId404Error1 value) =>
        new(default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettingsSettingId404Error1>.Some(value),
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId422Error1(BalancePlatformsWebhooksSettingsSettingId422Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettingsSettingId422Error1>.Some(value),
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsBalancePlatformsWebhooksSettingsSettingId500Error1(BalancePlatformsWebhooksSettingsSettingId500Error1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettingsSettingId500Error1>.Some(value),
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId400Error1(out BalancePlatformsWebhooksSettingsSettingId400Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId400Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId401Error1(out BalancePlatformsWebhooksSettingsSettingId401Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId401Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId403Error1(out BalancePlatformsWebhooksSettingsSettingId403Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId403Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId404Error1(out BalancePlatformsWebhooksSettingsSettingId404Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId404Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId422Error1(out BalancePlatformsWebhooksSettingsSettingId422Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId422Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettingsSettingId500Error1(out BalancePlatformsWebhooksSettingsSettingId500Error1 value) =>
        _balancePlatformsWebhooksSettingsSettingId500Error1Value.TryGetValue(out value);

    internal static Task<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<BalancePlatformsWebhooksSettingsSettingId400Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId400Error1),
            401 => FromJson<BalancePlatformsWebhooksSettingsSettingId401Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId401Error1),
            403 => FromJson<BalancePlatformsWebhooksSettingsSettingId403Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId403Error1),
            404 => FromJson<BalancePlatformsWebhooksSettingsSettingId404Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId404Error1),
            422 => FromJson<BalancePlatformsWebhooksSettingsSettingId422Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId422Error1),
            500 => FromJson<BalancePlatformsWebhooksSettingsSettingId500Error1>(response, ct).As(AsBalancePlatformsWebhooksSettingsSettingId500Error1),
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

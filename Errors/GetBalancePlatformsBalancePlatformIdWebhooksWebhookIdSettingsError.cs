using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError : ApiError
{
    private readonly Optional<BalancePlatformsWebhooksSettings400Error1> _balancePlatformsWebhooksSettings400Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettings401Error1> _balancePlatformsWebhooksSettings401Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettings403Error1> _balancePlatformsWebhooksSettings403Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettings404Error1> _balancePlatformsWebhooksSettings404Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettings422Error1> _balancePlatformsWebhooksSettings422Error1Value;

    private readonly Optional<BalancePlatformsWebhooksSettings500Error1> _balancePlatformsWebhooksSettings500Error1Value;

    private GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError(Optional<BalancePlatformsWebhooksSettings400Error1> balancePlatformsWebhooksSettings400Error1Value,
        Optional<BalancePlatformsWebhooksSettings401Error1> balancePlatformsWebhooksSettings401Error1Value,
        Optional<BalancePlatformsWebhooksSettings403Error1> balancePlatformsWebhooksSettings403Error1Value,
        Optional<BalancePlatformsWebhooksSettings404Error1> balancePlatformsWebhooksSettings404Error1Value,
        Optional<BalancePlatformsWebhooksSettings422Error1> balancePlatformsWebhooksSettings422Error1Value,
        Optional<BalancePlatformsWebhooksSettings500Error1> balancePlatformsWebhooksSettings500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balancePlatformsWebhooksSettings400Error1Value = balancePlatformsWebhooksSettings400Error1Value;
        _balancePlatformsWebhooksSettings401Error1Value = balancePlatformsWebhooksSettings401Error1Value;
        _balancePlatformsWebhooksSettings403Error1Value = balancePlatformsWebhooksSettings403Error1Value;
        _balancePlatformsWebhooksSettings404Error1Value = balancePlatformsWebhooksSettings404Error1Value;
        _balancePlatformsWebhooksSettings422Error1Value = balancePlatformsWebhooksSettings422Error1Value;
        _balancePlatformsWebhooksSettings500Error1Value = balancePlatformsWebhooksSettings500Error1Value;
    }

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings400Error1(BalancePlatformsWebhooksSettings400Error1 value) =>
        new(Optional<BalancePlatformsWebhooksSettings400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings401Error1(BalancePlatformsWebhooksSettings401Error1 value) =>
        new(default,
            Optional<BalancePlatformsWebhooksSettings401Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings403Error1(BalancePlatformsWebhooksSettings403Error1 value) =>
        new(default,
            default,
            Optional<BalancePlatformsWebhooksSettings403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings404Error1(BalancePlatformsWebhooksSettings404Error1 value) =>
        new(default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettings404Error1>.Some(value),
            default,
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings422Error1(BalancePlatformsWebhooksSettings422Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettings422Error1>.Some(value),
            default,
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsBalancePlatformsWebhooksSettings500Error1(BalancePlatformsWebhooksSettings500Error1 value) =>
        new(default,
            default,
            default,
            default,
            default,
            Optional<BalancePlatformsWebhooksSettings500Error1>.Some(value),
            default);

    private static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError AsFallback(RawError value) =>
        new(default, default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalancePlatformsWebhooksSettings400Error1(out BalancePlatformsWebhooksSettings400Error1 value) =>
        _balancePlatformsWebhooksSettings400Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettings401Error1(out BalancePlatformsWebhooksSettings401Error1 value) =>
        _balancePlatformsWebhooksSettings401Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettings403Error1(out BalancePlatformsWebhooksSettings403Error1 value) =>
        _balancePlatformsWebhooksSettings403Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettings404Error1(out BalancePlatformsWebhooksSettings404Error1 value) =>
        _balancePlatformsWebhooksSettings404Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettings422Error1(out BalancePlatformsWebhooksSettings422Error1 value) =>
        _balancePlatformsWebhooksSettings422Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsWebhooksSettings500Error1(out BalancePlatformsWebhooksSettings500Error1 value) =>
        _balancePlatformsWebhooksSettings500Error1Value.TryGetValue(out value);

    internal static Task<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<BalancePlatformsWebhooksSettings400Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings400Error1),
            401 => FromJson<BalancePlatformsWebhooksSettings401Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings401Error1),
            403 => FromJson<BalancePlatformsWebhooksSettings403Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings403Error1),
            404 => FromJson<BalancePlatformsWebhooksSettings404Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings404Error1),
            422 => FromJson<BalancePlatformsWebhooksSettings422Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings422Error1),
            500 => FromJson<BalancePlatformsWebhooksSettings500Error1>(response, ct).As(AsBalancePlatformsWebhooksSettings500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsErrorResponse : IErrorResponse<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError>
{
    public static GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsErrorResponse Instance { get; } = new();

    private GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsErrorResponse()
    {
    }

    public Task<GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.Create(response, ct);
}

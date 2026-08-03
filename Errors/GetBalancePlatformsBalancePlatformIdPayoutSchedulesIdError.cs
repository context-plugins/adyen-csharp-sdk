using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError : ApiError
{
    private readonly Optional<BalancePlatformsPayoutSchedules401Error1> _balancePlatformsPayoutSchedules401Error1Value;

    private readonly Optional<BalancePlatformsPayoutSchedules403Error1> _balancePlatformsPayoutSchedules403Error1Value;

    private readonly Optional<BalancePlatformsPayoutSchedules404Error1> _balancePlatformsPayoutSchedules404Error1Value;

    private readonly Optional<BalancePlatformsPayoutSchedules422Error1> _balancePlatformsPayoutSchedules422Error1Value;

    private readonly Optional<BalancePlatformsPayoutSchedules500Error1> _balancePlatformsPayoutSchedules500Error1Value;

    private GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError(Optional<BalancePlatformsPayoutSchedules401Error1> balancePlatformsPayoutSchedules401Error1Value,
        Optional<BalancePlatformsPayoutSchedules403Error1> balancePlatformsPayoutSchedules403Error1Value,
        Optional<BalancePlatformsPayoutSchedules404Error1> balancePlatformsPayoutSchedules404Error1Value,
        Optional<BalancePlatformsPayoutSchedules422Error1> balancePlatformsPayoutSchedules422Error1Value,
        Optional<BalancePlatformsPayoutSchedules500Error1> balancePlatformsPayoutSchedules500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balancePlatformsPayoutSchedules401Error1Value = balancePlatformsPayoutSchedules401Error1Value;
        _balancePlatformsPayoutSchedules403Error1Value = balancePlatformsPayoutSchedules403Error1Value;
        _balancePlatformsPayoutSchedules404Error1Value = balancePlatformsPayoutSchedules404Error1Value;
        _balancePlatformsPayoutSchedules422Error1Value = balancePlatformsPayoutSchedules422Error1Value;
        _balancePlatformsPayoutSchedules500Error1Value = balancePlatformsPayoutSchedules500Error1Value;
    }

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsBalancePlatformsPayoutSchedules401Error1(BalancePlatformsPayoutSchedules401Error1 value) =>
        new(Optional<BalancePlatformsPayoutSchedules401Error1>.Some(value), default, default, default, default, default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsBalancePlatformsPayoutSchedules403Error1(BalancePlatformsPayoutSchedules403Error1 value) =>
        new(default, Optional<BalancePlatformsPayoutSchedules403Error1>.Some(value), default, default, default, default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsBalancePlatformsPayoutSchedules404Error1(BalancePlatformsPayoutSchedules404Error1 value) =>
        new(default, default, Optional<BalancePlatformsPayoutSchedules404Error1>.Some(value), default, default, default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsBalancePlatformsPayoutSchedules422Error1(BalancePlatformsPayoutSchedules422Error1 value) =>
        new(default, default, default, Optional<BalancePlatformsPayoutSchedules422Error1>.Some(value), default, default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsBalancePlatformsPayoutSchedules500Error1(BalancePlatformsPayoutSchedules500Error1 value) =>
        new(default, default, default, default, Optional<BalancePlatformsPayoutSchedules500Error1>.Some(value), default);

    private static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalancePlatformsPayoutSchedules401Error1(out BalancePlatformsPayoutSchedules401Error1 value) =>
        _balancePlatformsPayoutSchedules401Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsPayoutSchedules403Error1(out BalancePlatformsPayoutSchedules403Error1 value) =>
        _balancePlatformsPayoutSchedules403Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsPayoutSchedules404Error1(out BalancePlatformsPayoutSchedules404Error1 value) =>
        _balancePlatformsPayoutSchedules404Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsPayoutSchedules422Error1(out BalancePlatformsPayoutSchedules422Error1 value) =>
        _balancePlatformsPayoutSchedules422Error1Value.TryGetValue(out value);

    public bool TryGetBalancePlatformsPayoutSchedules500Error1(out BalancePlatformsPayoutSchedules500Error1 value) =>
        _balancePlatformsPayoutSchedules500Error1Value.TryGetValue(out value);

    internal static Task<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalancePlatformsPayoutSchedules401Error1>(response, ct).As(AsBalancePlatformsPayoutSchedules401Error1),
            403 => FromJson<BalancePlatformsPayoutSchedules403Error1>(response, ct).As(AsBalancePlatformsPayoutSchedules403Error1),
            404 => FromJson<BalancePlatformsPayoutSchedules404Error1>(response, ct).As(AsBalancePlatformsPayoutSchedules404Error1),
            422 => FromJson<BalancePlatformsPayoutSchedules422Error1>(response, ct).As(AsBalancePlatformsPayoutSchedules422Error1),
            500 => FromJson<BalancePlatformsPayoutSchedules500Error1>(response, ct).As(AsBalancePlatformsPayoutSchedules500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse : IErrorResponse<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError>
{
    public static GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse Instance { get; } = new();

    private GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdErrorResponse()
    {
    }

    public Task<GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalancePlatformsBalancePlatformIdPayoutSchedulesIdError.Create(response, ct);
}

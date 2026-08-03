using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError : ApiError
{
    private readonly Optional<BalanceAccountsPayoutSchedules401Error1> _balanceAccountsPayoutSchedules401Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedules403Error1> _balanceAccountsPayoutSchedules403Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedules404Error1> _balanceAccountsPayoutSchedules404Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedules422Error1> _balanceAccountsPayoutSchedules422Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedules500Error1> _balanceAccountsPayoutSchedules500Error1Value;

    private PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError(Optional<BalanceAccountsPayoutSchedules401Error1> balanceAccountsPayoutSchedules401Error1Value,
        Optional<BalanceAccountsPayoutSchedules403Error1> balanceAccountsPayoutSchedules403Error1Value,
        Optional<BalanceAccountsPayoutSchedules404Error1> balanceAccountsPayoutSchedules404Error1Value,
        Optional<BalanceAccountsPayoutSchedules422Error1> balanceAccountsPayoutSchedules422Error1Value,
        Optional<BalanceAccountsPayoutSchedules500Error1> balanceAccountsPayoutSchedules500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsPayoutSchedules401Error1Value = balanceAccountsPayoutSchedules401Error1Value;
        _balanceAccountsPayoutSchedules403Error1Value = balanceAccountsPayoutSchedules403Error1Value;
        _balanceAccountsPayoutSchedules404Error1Value = balanceAccountsPayoutSchedules404Error1Value;
        _balanceAccountsPayoutSchedules422Error1Value = balanceAccountsPayoutSchedules422Error1Value;
        _balanceAccountsPayoutSchedules500Error1Value = balanceAccountsPayoutSchedules500Error1Value;
    }

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsBalanceAccountsPayoutSchedules401Error1(BalanceAccountsPayoutSchedules401Error1 value) =>
        new(Optional<BalanceAccountsPayoutSchedules401Error1>.Some(value), default, default, default, default, default);

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsBalanceAccountsPayoutSchedules403Error1(BalanceAccountsPayoutSchedules403Error1 value) =>
        new(default, Optional<BalanceAccountsPayoutSchedules403Error1>.Some(value), default, default, default, default);

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsBalanceAccountsPayoutSchedules404Error1(BalanceAccountsPayoutSchedules404Error1 value) =>
        new(default, default, Optional<BalanceAccountsPayoutSchedules404Error1>.Some(value), default, default, default);

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsBalanceAccountsPayoutSchedules422Error1(BalanceAccountsPayoutSchedules422Error1 value) =>
        new(default, default, default, Optional<BalanceAccountsPayoutSchedules422Error1>.Some(value), default, default);

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsBalanceAccountsPayoutSchedules500Error1(BalanceAccountsPayoutSchedules500Error1 value) =>
        new(default, default, default, default, Optional<BalanceAccountsPayoutSchedules500Error1>.Some(value), default);

    private static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsPayoutSchedules401Error1(out BalanceAccountsPayoutSchedules401Error1 value) =>
        _balanceAccountsPayoutSchedules401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedules403Error1(out BalanceAccountsPayoutSchedules403Error1 value) =>
        _balanceAccountsPayoutSchedules403Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedules404Error1(out BalanceAccountsPayoutSchedules404Error1 value) =>
        _balanceAccountsPayoutSchedules404Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedules422Error1(out BalanceAccountsPayoutSchedules422Error1 value) =>
        _balanceAccountsPayoutSchedules422Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedules500Error1(out BalanceAccountsPayoutSchedules500Error1 value) =>
        _balanceAccountsPayoutSchedules500Error1Value.TryGetValue(out value);

    internal static Task<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceAccountsPayoutSchedules401Error1>(response, ct).As(AsBalanceAccountsPayoutSchedules401Error1),
            403 => FromJson<BalanceAccountsPayoutSchedules403Error1>(response, ct).As(AsBalanceAccountsPayoutSchedules403Error1),
            404 => FromJson<BalanceAccountsPayoutSchedules404Error1>(response, ct).As(AsBalanceAccountsPayoutSchedules404Error1),
            422 => FromJson<BalanceAccountsPayoutSchedules422Error1>(response, ct).As(AsBalanceAccountsPayoutSchedules422Error1),
            500 => FromJson<BalanceAccountsPayoutSchedules500Error1>(response, ct).As(AsBalanceAccountsPayoutSchedules500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse : IErrorResponse<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError>
{
    public static PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse Instance { get; } = new();

    private PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdErrorResponse()
    {
    }

    public Task<PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PatchBalanceAccountsBalanceAccountIdPayoutSchedulesIdError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError : ApiError
{
    private readonly Optional<BalanceAccountsPayoutSchedulesExecutions401Error1> _balanceAccountsPayoutSchedulesExecutions401Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedulesExecutions403Error1> _balanceAccountsPayoutSchedulesExecutions403Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedulesExecutions404Error1> _balanceAccountsPayoutSchedulesExecutions404Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedulesExecutions422Error1> _balanceAccountsPayoutSchedulesExecutions422Error1Value;

    private readonly Optional<BalanceAccountsPayoutSchedulesExecutions500Error1> _balanceAccountsPayoutSchedulesExecutions500Error1Value;

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError(Optional<BalanceAccountsPayoutSchedulesExecutions401Error1> balanceAccountsPayoutSchedulesExecutions401Error1Value,
        Optional<BalanceAccountsPayoutSchedulesExecutions403Error1> balanceAccountsPayoutSchedulesExecutions403Error1Value,
        Optional<BalanceAccountsPayoutSchedulesExecutions404Error1> balanceAccountsPayoutSchedulesExecutions404Error1Value,
        Optional<BalanceAccountsPayoutSchedulesExecutions422Error1> balanceAccountsPayoutSchedulesExecutions422Error1Value,
        Optional<BalanceAccountsPayoutSchedulesExecutions500Error1> balanceAccountsPayoutSchedulesExecutions500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsPayoutSchedulesExecutions401Error1Value = balanceAccountsPayoutSchedulesExecutions401Error1Value;
        _balanceAccountsPayoutSchedulesExecutions403Error1Value = balanceAccountsPayoutSchedulesExecutions403Error1Value;
        _balanceAccountsPayoutSchedulesExecutions404Error1Value = balanceAccountsPayoutSchedulesExecutions404Error1Value;
        _balanceAccountsPayoutSchedulesExecutions422Error1Value = balanceAccountsPayoutSchedulesExecutions422Error1Value;
        _balanceAccountsPayoutSchedulesExecutions500Error1Value = balanceAccountsPayoutSchedulesExecutions500Error1Value;
    }

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsBalanceAccountsPayoutSchedulesExecutions401Error1(BalanceAccountsPayoutSchedulesExecutions401Error1 value) =>
        new(Optional<BalanceAccountsPayoutSchedulesExecutions401Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsBalanceAccountsPayoutSchedulesExecutions403Error1(BalanceAccountsPayoutSchedulesExecutions403Error1 value) =>
        new(default,
            Optional<BalanceAccountsPayoutSchedulesExecutions403Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsBalanceAccountsPayoutSchedulesExecutions404Error1(BalanceAccountsPayoutSchedulesExecutions404Error1 value) =>
        new(default,
            default,
            Optional<BalanceAccountsPayoutSchedulesExecutions404Error1>.Some(value),
            default,
            default,
            default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsBalanceAccountsPayoutSchedulesExecutions422Error1(BalanceAccountsPayoutSchedulesExecutions422Error1 value) =>
        new(default,
            default,
            default,
            Optional<BalanceAccountsPayoutSchedulesExecutions422Error1>.Some(value),
            default,
            default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsBalanceAccountsPayoutSchedulesExecutions500Error1(BalanceAccountsPayoutSchedulesExecutions500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<BalanceAccountsPayoutSchedulesExecutions500Error1>.Some(value),
            default);

    private static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsPayoutSchedulesExecutions401Error1(out BalanceAccountsPayoutSchedulesExecutions401Error1 value) =>
        _balanceAccountsPayoutSchedulesExecutions401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedulesExecutions403Error1(out BalanceAccountsPayoutSchedulesExecutions403Error1 value) =>
        _balanceAccountsPayoutSchedulesExecutions403Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedulesExecutions404Error1(out BalanceAccountsPayoutSchedulesExecutions404Error1 value) =>
        _balanceAccountsPayoutSchedulesExecutions404Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedulesExecutions422Error1(out BalanceAccountsPayoutSchedulesExecutions422Error1 value) =>
        _balanceAccountsPayoutSchedulesExecutions422Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsPayoutSchedulesExecutions500Error1(out BalanceAccountsPayoutSchedulesExecutions500Error1 value) =>
        _balanceAccountsPayoutSchedulesExecutions500Error1Value.TryGetValue(out value);

    internal static Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceAccountsPayoutSchedulesExecutions401Error1>(response, ct).As(AsBalanceAccountsPayoutSchedulesExecutions401Error1),
            403 => FromJson<BalanceAccountsPayoutSchedulesExecutions403Error1>(response, ct).As(AsBalanceAccountsPayoutSchedulesExecutions403Error1),
            404 => FromJson<BalanceAccountsPayoutSchedulesExecutions404Error1>(response, ct).As(AsBalanceAccountsPayoutSchedulesExecutions404Error1),
            422 => FromJson<BalanceAccountsPayoutSchedulesExecutions422Error1>(response, ct).As(AsBalanceAccountsPayoutSchedulesExecutions422Error1),
            500 => FromJson<BalanceAccountsPayoutSchedulesExecutions500Error1>(response, ct).As(AsBalanceAccountsPayoutSchedulesExecutions500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse : IErrorResponse<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError>
{
    public static GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse Instance { get; } = new();

    private GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsErrorResponse()
    {
    }

    public Task<GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalanceAccountsBalanceAccountIdPayoutSchedulesIdExecutionsError.Create(response, ct);
}

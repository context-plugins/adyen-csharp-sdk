using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsIdTransferLimitsCurrentError : ApiError
{
    private readonly Optional<BalanceAccountsTransferLimitsCurrent404Error1> _balanceAccountsTransferLimitsCurrent404Error1Value;

    private readonly Optional<BalanceAccountsTransferLimitsCurrent422Error1> _balanceAccountsTransferLimitsCurrent422Error1Value;

    private GetBalanceAccountsIdTransferLimitsCurrentError(Optional<BalanceAccountsTransferLimitsCurrent404Error1> balanceAccountsTransferLimitsCurrent404Error1Value,
        Optional<BalanceAccountsTransferLimitsCurrent422Error1> balanceAccountsTransferLimitsCurrent422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsTransferLimitsCurrent404Error1Value = balanceAccountsTransferLimitsCurrent404Error1Value;
        _balanceAccountsTransferLimitsCurrent422Error1Value = balanceAccountsTransferLimitsCurrent422Error1Value;
    }

    private static GetBalanceAccountsIdTransferLimitsCurrentError AsBalanceAccountsTransferLimitsCurrent404Error1(BalanceAccountsTransferLimitsCurrent404Error1 value) =>
        new(Optional<BalanceAccountsTransferLimitsCurrent404Error1>.Some(value), default, default);

    private static GetBalanceAccountsIdTransferLimitsCurrentError AsBalanceAccountsTransferLimitsCurrent422Error1(BalanceAccountsTransferLimitsCurrent422Error1 value) =>
        new(default, Optional<BalanceAccountsTransferLimitsCurrent422Error1>.Some(value), default);

    private static GetBalanceAccountsIdTransferLimitsCurrentError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsTransferLimitsCurrent404Error1(out BalanceAccountsTransferLimitsCurrent404Error1 value) =>
        _balanceAccountsTransferLimitsCurrent404Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimitsCurrent422Error1(out BalanceAccountsTransferLimitsCurrent422Error1 value) =>
        _balanceAccountsTransferLimitsCurrent422Error1Value.TryGetValue(out value);

    internal static Task<GetBalanceAccountsIdTransferLimitsCurrentError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<BalanceAccountsTransferLimitsCurrent404Error1>(response, ct).As(AsBalanceAccountsTransferLimitsCurrent404Error1),
            422 => FromJson<BalanceAccountsTransferLimitsCurrent422Error1>(response, ct).As(AsBalanceAccountsTransferLimitsCurrent422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsIdTransferLimitsCurrentErrorResponse : IErrorResponse<GetBalanceAccountsIdTransferLimitsCurrentError>
{
    public static GetBalanceAccountsIdTransferLimitsCurrentErrorResponse Instance { get; } = new();

    private GetBalanceAccountsIdTransferLimitsCurrentErrorResponse()
    {
    }

    public Task<GetBalanceAccountsIdTransferLimitsCurrentError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetBalanceAccountsIdTransferLimitsCurrentError.Create(response, ct);
}

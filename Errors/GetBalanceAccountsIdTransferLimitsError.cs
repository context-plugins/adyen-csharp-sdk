using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceAccountsIdTransferLimitsError : ApiError
{
    private readonly Optional<BalanceAccountsTransferLimits404Error1> _balanceAccountsTransferLimits404Error1Value;

    private readonly Optional<BalanceAccountsTransferLimits422Error1> _balanceAccountsTransferLimits422Error1Value;

    private GetBalanceAccountsIdTransferLimitsError(Optional<BalanceAccountsTransferLimits404Error1> balanceAccountsTransferLimits404Error1Value,
        Optional<BalanceAccountsTransferLimits422Error1> balanceAccountsTransferLimits422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceAccountsTransferLimits404Error1Value = balanceAccountsTransferLimits404Error1Value;
        _balanceAccountsTransferLimits422Error1Value = balanceAccountsTransferLimits422Error1Value;
    }

    private static GetBalanceAccountsIdTransferLimitsError AsBalanceAccountsTransferLimits404Error1(BalanceAccountsTransferLimits404Error1 value) =>
        new(Optional<BalanceAccountsTransferLimits404Error1>.Some(value), default, default);

    private static GetBalanceAccountsIdTransferLimitsError AsBalanceAccountsTransferLimits422Error1(BalanceAccountsTransferLimits422Error1 value) =>
        new(default, Optional<BalanceAccountsTransferLimits422Error1>.Some(value), default);

    private static GetBalanceAccountsIdTransferLimitsError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceAccountsTransferLimits404Error1(out BalanceAccountsTransferLimits404Error1 value) =>
        _balanceAccountsTransferLimits404Error1Value.TryGetValue(out value);

    public bool TryGetBalanceAccountsTransferLimits422Error1(out BalanceAccountsTransferLimits422Error1 value) =>
        _balanceAccountsTransferLimits422Error1Value.TryGetValue(out value);

    internal static Task<GetBalanceAccountsIdTransferLimitsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<BalanceAccountsTransferLimits404Error1>(response, ct).As(AsBalanceAccountsTransferLimits404Error1),
            422 => FromJson<BalanceAccountsTransferLimits422Error1>(response, ct).As(AsBalanceAccountsTransferLimits422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceAccountsIdTransferLimitsErrorResponse : IErrorResponse<GetBalanceAccountsIdTransferLimitsError>
{
    public static GetBalanceAccountsIdTransferLimitsErrorResponse Instance { get; } = new();

    private GetBalanceAccountsIdTransferLimitsErrorResponse()
    {
    }

    public Task<GetBalanceAccountsIdTransferLimitsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetBalanceAccountsIdTransferLimitsError.Create(response, ct);
}

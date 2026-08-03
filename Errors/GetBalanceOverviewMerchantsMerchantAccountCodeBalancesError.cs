using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError : ApiError
{
    private readonly Optional<BalanceOverviewMerchantsBalances401Error1> _balanceOverviewMerchantsBalances401Error1Value;

    private readonly Optional<BalanceOverviewMerchantsBalances403Error1> _balanceOverviewMerchantsBalances403Error1Value;

    private readonly Optional<BalanceOverviewMerchantsBalances422Error1> _balanceOverviewMerchantsBalances422Error1Value;

    private GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError(Optional<BalanceOverviewMerchantsBalances401Error1> balanceOverviewMerchantsBalances401Error1Value,
        Optional<BalanceOverviewMerchantsBalances403Error1> balanceOverviewMerchantsBalances403Error1Value,
        Optional<BalanceOverviewMerchantsBalances422Error1> balanceOverviewMerchantsBalances422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceOverviewMerchantsBalances401Error1Value = balanceOverviewMerchantsBalances401Error1Value;
        _balanceOverviewMerchantsBalances403Error1Value = balanceOverviewMerchantsBalances403Error1Value;
        _balanceOverviewMerchantsBalances422Error1Value = balanceOverviewMerchantsBalances422Error1Value;
    }

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsBalanceOverviewMerchantsBalances401Error1(BalanceOverviewMerchantsBalances401Error1 value) =>
        new(Optional<BalanceOverviewMerchantsBalances401Error1>.Some(value), default, default, default);

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsBalanceOverviewMerchantsBalances403Error1(BalanceOverviewMerchantsBalances403Error1 value) =>
        new(default, Optional<BalanceOverviewMerchantsBalances403Error1>.Some(value), default, default);

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsBalanceOverviewMerchantsBalances422Error1(BalanceOverviewMerchantsBalances422Error1 value) =>
        new(default, default, Optional<BalanceOverviewMerchantsBalances422Error1>.Some(value), default);

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceOverviewMerchantsBalances401Error1(out BalanceOverviewMerchantsBalances401Error1 value) =>
        _balanceOverviewMerchantsBalances401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceOverviewMerchantsBalances403Error1(out BalanceOverviewMerchantsBalances403Error1 value) =>
        _balanceOverviewMerchantsBalances403Error1Value.TryGetValue(out value);

    public bool TryGetBalanceOverviewMerchantsBalances422Error1(out BalanceOverviewMerchantsBalances422Error1 value) =>
        _balanceOverviewMerchantsBalances422Error1Value.TryGetValue(out value);

    internal static Task<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceOverviewMerchantsBalances401Error1>(response, ct).As(AsBalanceOverviewMerchantsBalances401Error1),
            403 => FromJson<BalanceOverviewMerchantsBalances403Error1>(response, ct).As(AsBalanceOverviewMerchantsBalances403Error1),
            422 => FromJson<BalanceOverviewMerchantsBalances422Error1>(response, ct).As(AsBalanceOverviewMerchantsBalances422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceOverviewMerchantsMerchantAccountCodeBalancesErrorResponse : IErrorResponse<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError>
{
    public static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesErrorResponse Instance { get; } = new();

    private GetBalanceOverviewMerchantsMerchantAccountCodeBalancesErrorResponse()
    {
    }

    public Task<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError.Create(response, ct);
}

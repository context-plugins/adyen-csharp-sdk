using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError : ApiError
{
    private readonly Optional<BalanceOverviewCompaniesBalances401Error1> _balanceOverviewCompaniesBalances401Error1Value;

    private readonly Optional<BalanceOverviewCompaniesBalances403Error1> _balanceOverviewCompaniesBalances403Error1Value;

    private readonly Optional<BalanceOverviewCompaniesBalances422Error1> _balanceOverviewCompaniesBalances422Error1Value;

    private GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError(Optional<BalanceOverviewCompaniesBalances401Error1> balanceOverviewCompaniesBalances401Error1Value,
        Optional<BalanceOverviewCompaniesBalances403Error1> balanceOverviewCompaniesBalances403Error1Value,
        Optional<BalanceOverviewCompaniesBalances422Error1> balanceOverviewCompaniesBalances422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _balanceOverviewCompaniesBalances401Error1Value = balanceOverviewCompaniesBalances401Error1Value;
        _balanceOverviewCompaniesBalances403Error1Value = balanceOverviewCompaniesBalances403Error1Value;
        _balanceOverviewCompaniesBalances422Error1Value = balanceOverviewCompaniesBalances422Error1Value;
    }

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsBalanceOverviewCompaniesBalances401Error1(BalanceOverviewCompaniesBalances401Error1 value) =>
        new(Optional<BalanceOverviewCompaniesBalances401Error1>.Some(value), default, default, default);

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsBalanceOverviewCompaniesBalances403Error1(BalanceOverviewCompaniesBalances403Error1 value) =>
        new(default, Optional<BalanceOverviewCompaniesBalances403Error1>.Some(value), default, default);

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsBalanceOverviewCompaniesBalances422Error1(BalanceOverviewCompaniesBalances422Error1 value) =>
        new(default, default, Optional<BalanceOverviewCompaniesBalances422Error1>.Some(value), default);

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetBalanceOverviewCompaniesBalances401Error1(out BalanceOverviewCompaniesBalances401Error1 value) =>
        _balanceOverviewCompaniesBalances401Error1Value.TryGetValue(out value);

    public bool TryGetBalanceOverviewCompaniesBalances403Error1(out BalanceOverviewCompaniesBalances403Error1 value) =>
        _balanceOverviewCompaniesBalances403Error1Value.TryGetValue(out value);

    public bool TryGetBalanceOverviewCompaniesBalances422Error1(out BalanceOverviewCompaniesBalances422Error1 value) =>
        _balanceOverviewCompaniesBalances422Error1Value.TryGetValue(out value);

    internal static Task<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<BalanceOverviewCompaniesBalances401Error1>(response, ct).As(AsBalanceOverviewCompaniesBalances401Error1),
            403 => FromJson<BalanceOverviewCompaniesBalances403Error1>(response, ct).As(AsBalanceOverviewCompaniesBalances403Error1),
            422 => FromJson<BalanceOverviewCompaniesBalances422Error1>(response, ct).As(AsBalanceOverviewCompaniesBalances422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetBalanceOverviewCompaniesCompanyAccountCodeBalancesErrorResponse : IErrorResponse<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError>
{
    public static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesErrorResponse Instance { get; } = new();

    private GetBalanceOverviewCompaniesCompanyAccountCodeBalancesErrorResponse()
    {
    }

    public Task<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError.Create(response, ct);
}

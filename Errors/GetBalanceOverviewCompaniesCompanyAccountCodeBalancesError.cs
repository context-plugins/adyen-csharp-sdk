using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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

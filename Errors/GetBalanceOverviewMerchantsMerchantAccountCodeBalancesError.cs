using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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

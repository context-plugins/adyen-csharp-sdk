using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsErrorResponse : IErrorResponse<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError>
{
    public static GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsError.Create(response, ct);
}

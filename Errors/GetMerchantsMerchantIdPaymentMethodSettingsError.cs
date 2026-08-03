using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdPaymentMethodSettingsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdPaymentMethodSettingsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdPaymentMethodSettingsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdPaymentMethodSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdPaymentMethodSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 429 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdPaymentMethodSettingsErrorResponse : IErrorResponse<GetMerchantsMerchantIdPaymentMethodSettingsError>
{
    public static GetMerchantsMerchantIdPaymentMethodSettingsErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdPaymentMethodSettingsErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdPaymentMethodSettingsError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetMerchantsMerchantIdPaymentMethodSettingsError.Create(response, ct);
}

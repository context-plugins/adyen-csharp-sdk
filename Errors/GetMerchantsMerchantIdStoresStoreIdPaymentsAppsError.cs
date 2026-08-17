using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdStoresStoreIdPaymentsAppsErrorResponse : IErrorResponse<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError>
{
    public static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdStoresStoreIdPaymentsAppsErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError : ApiError
{
    private readonly Optional<MerchantsStoresPaymentsApps400Error1> _merchantsStoresPaymentsApps400Error1Value;

    private readonly Optional<MerchantsStoresPaymentsApps401Error1> _merchantsStoresPaymentsApps401Error1Value;

    private readonly Optional<MerchantsStoresPaymentsApps403Error1> _merchantsStoresPaymentsApps403Error1Value;

    private readonly Optional<MerchantsStoresPaymentsApps422Error1> _merchantsStoresPaymentsApps422Error1Value;

    private readonly Optional<MerchantsStoresPaymentsApps500Error1> _merchantsStoresPaymentsApps500Error1Value;

    private GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError(Optional<MerchantsStoresPaymentsApps400Error1> merchantsStoresPaymentsApps400Error1Value,
        Optional<MerchantsStoresPaymentsApps401Error1> merchantsStoresPaymentsApps401Error1Value,
        Optional<MerchantsStoresPaymentsApps403Error1> merchantsStoresPaymentsApps403Error1Value,
        Optional<MerchantsStoresPaymentsApps422Error1> merchantsStoresPaymentsApps422Error1Value,
        Optional<MerchantsStoresPaymentsApps500Error1> merchantsStoresPaymentsApps500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsStoresPaymentsApps400Error1Value = merchantsStoresPaymentsApps400Error1Value;
        _merchantsStoresPaymentsApps401Error1Value = merchantsStoresPaymentsApps401Error1Value;
        _merchantsStoresPaymentsApps403Error1Value = merchantsStoresPaymentsApps403Error1Value;
        _merchantsStoresPaymentsApps422Error1Value = merchantsStoresPaymentsApps422Error1Value;
        _merchantsStoresPaymentsApps500Error1Value = merchantsStoresPaymentsApps500Error1Value;
    }

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsMerchantsStoresPaymentsApps400Error1(MerchantsStoresPaymentsApps400Error1 value) =>
        new(Optional<MerchantsStoresPaymentsApps400Error1>.Some(value), default, default, default, default, default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsMerchantsStoresPaymentsApps401Error1(MerchantsStoresPaymentsApps401Error1 value) =>
        new(default, Optional<MerchantsStoresPaymentsApps401Error1>.Some(value), default, default, default, default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsMerchantsStoresPaymentsApps403Error1(MerchantsStoresPaymentsApps403Error1 value) =>
        new(default, default, Optional<MerchantsStoresPaymentsApps403Error1>.Some(value), default, default, default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsMerchantsStoresPaymentsApps422Error1(MerchantsStoresPaymentsApps422Error1 value) =>
        new(default, default, default, Optional<MerchantsStoresPaymentsApps422Error1>.Some(value), default, default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsMerchantsStoresPaymentsApps500Error1(MerchantsStoresPaymentsApps500Error1 value) =>
        new(default, default, default, default, Optional<MerchantsStoresPaymentsApps500Error1>.Some(value), default);

    private static GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsStoresPaymentsApps400Error1(out MerchantsStoresPaymentsApps400Error1 value) =>
        _merchantsStoresPaymentsApps400Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresPaymentsApps401Error1(out MerchantsStoresPaymentsApps401Error1 value) =>
        _merchantsStoresPaymentsApps401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresPaymentsApps403Error1(out MerchantsStoresPaymentsApps403Error1 value) =>
        _merchantsStoresPaymentsApps403Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresPaymentsApps422Error1(out MerchantsStoresPaymentsApps422Error1 value) =>
        _merchantsStoresPaymentsApps422Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresPaymentsApps500Error1(out MerchantsStoresPaymentsApps500Error1 value) =>
        _merchantsStoresPaymentsApps500Error1Value.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<MerchantsStoresPaymentsApps400Error1>(response, ct).As(AsMerchantsStoresPaymentsApps400Error1),
            401 => FromJson<MerchantsStoresPaymentsApps401Error1>(response, ct).As(AsMerchantsStoresPaymentsApps401Error1),
            403 => FromJson<MerchantsStoresPaymentsApps403Error1>(response, ct).As(AsMerchantsStoresPaymentsApps403Error1),
            422 => FromJson<MerchantsStoresPaymentsApps422Error1>(response, ct).As(AsMerchantsStoresPaymentsApps422Error1),
            500 => FromJson<MerchantsStoresPaymentsApps500Error1>(response, ct).As(AsMerchantsStoresPaymentsApps500Error1),
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

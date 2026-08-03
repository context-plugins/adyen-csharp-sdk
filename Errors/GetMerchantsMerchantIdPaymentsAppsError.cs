using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdPaymentsAppsError : ApiError
{
    private readonly Optional<MerchantsPaymentsApps400Error1> _merchantsPaymentsApps400Error1Value;

    private readonly Optional<MerchantsPaymentsApps401Error1> _merchantsPaymentsApps401Error1Value;

    private readonly Optional<MerchantsPaymentsApps403Error1> _merchantsPaymentsApps403Error1Value;

    private readonly Optional<MerchantsPaymentsApps422Error1> _merchantsPaymentsApps422Error1Value;

    private readonly Optional<MerchantsPaymentsApps500Error1> _merchantsPaymentsApps500Error1Value;

    private GetMerchantsMerchantIdPaymentsAppsError(Optional<MerchantsPaymentsApps400Error1> merchantsPaymentsApps400Error1Value,
        Optional<MerchantsPaymentsApps401Error1> merchantsPaymentsApps401Error1Value,
        Optional<MerchantsPaymentsApps403Error1> merchantsPaymentsApps403Error1Value,
        Optional<MerchantsPaymentsApps422Error1> merchantsPaymentsApps422Error1Value,
        Optional<MerchantsPaymentsApps500Error1> merchantsPaymentsApps500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsPaymentsApps400Error1Value = merchantsPaymentsApps400Error1Value;
        _merchantsPaymentsApps401Error1Value = merchantsPaymentsApps401Error1Value;
        _merchantsPaymentsApps403Error1Value = merchantsPaymentsApps403Error1Value;
        _merchantsPaymentsApps422Error1Value = merchantsPaymentsApps422Error1Value;
        _merchantsPaymentsApps500Error1Value = merchantsPaymentsApps500Error1Value;
    }

    private static GetMerchantsMerchantIdPaymentsAppsError AsMerchantsPaymentsApps400Error1(MerchantsPaymentsApps400Error1 value) =>
        new(Optional<MerchantsPaymentsApps400Error1>.Some(value), default, default, default, default, default);

    private static GetMerchantsMerchantIdPaymentsAppsError AsMerchantsPaymentsApps401Error1(MerchantsPaymentsApps401Error1 value) =>
        new(default, Optional<MerchantsPaymentsApps401Error1>.Some(value), default, default, default, default);

    private static GetMerchantsMerchantIdPaymentsAppsError AsMerchantsPaymentsApps403Error1(MerchantsPaymentsApps403Error1 value) =>
        new(default, default, Optional<MerchantsPaymentsApps403Error1>.Some(value), default, default, default);

    private static GetMerchantsMerchantIdPaymentsAppsError AsMerchantsPaymentsApps422Error1(MerchantsPaymentsApps422Error1 value) =>
        new(default, default, default, Optional<MerchantsPaymentsApps422Error1>.Some(value), default, default);

    private static GetMerchantsMerchantIdPaymentsAppsError AsMerchantsPaymentsApps500Error1(MerchantsPaymentsApps500Error1 value) =>
        new(default, default, default, default, Optional<MerchantsPaymentsApps500Error1>.Some(value), default);

    private static GetMerchantsMerchantIdPaymentsAppsError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsPaymentsApps400Error1(out MerchantsPaymentsApps400Error1 value) =>
        _merchantsPaymentsApps400Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsApps401Error1(out MerchantsPaymentsApps401Error1 value) =>
        _merchantsPaymentsApps401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsApps403Error1(out MerchantsPaymentsApps403Error1 value) =>
        _merchantsPaymentsApps403Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsApps422Error1(out MerchantsPaymentsApps422Error1 value) =>
        _merchantsPaymentsApps422Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsPaymentsApps500Error1(out MerchantsPaymentsApps500Error1 value) =>
        _merchantsPaymentsApps500Error1Value.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdPaymentsAppsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<MerchantsPaymentsApps400Error1>(response, ct).As(AsMerchantsPaymentsApps400Error1),
            401 => FromJson<MerchantsPaymentsApps401Error1>(response, ct).As(AsMerchantsPaymentsApps401Error1),
            403 => FromJson<MerchantsPaymentsApps403Error1>(response, ct).As(AsMerchantsPaymentsApps403Error1),
            422 => FromJson<MerchantsPaymentsApps422Error1>(response, ct).As(AsMerchantsPaymentsApps422Error1),
            500 => FromJson<MerchantsPaymentsApps500Error1>(response, ct).As(AsMerchantsPaymentsApps500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdPaymentsAppsErrorResponse : IErrorResponse<GetMerchantsMerchantIdPaymentsAppsError>
{
    public static GetMerchantsMerchantIdPaymentsAppsErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdPaymentsAppsErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdPaymentsAppsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetMerchantsMerchantIdPaymentsAppsError.Create(response, ct);
}

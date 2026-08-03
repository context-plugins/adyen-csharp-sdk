using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantAccountConnectedDevicesError : ApiError
{
    private readonly Optional<MerchantsConnectedDevices401Error1> _merchantsConnectedDevices401Error1Value;

    private readonly Optional<MerchantsConnectedDevices403Error1> _merchantsConnectedDevices403Error1Value;

    private GetMerchantsMerchantAccountConnectedDevicesError(Optional<MerchantsConnectedDevices401Error1> merchantsConnectedDevices401Error1Value,
        Optional<MerchantsConnectedDevices403Error1> merchantsConnectedDevices403Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsConnectedDevices401Error1Value = merchantsConnectedDevices401Error1Value;
        _merchantsConnectedDevices403Error1Value = merchantsConnectedDevices403Error1Value;
    }

    private static GetMerchantsMerchantAccountConnectedDevicesError AsMerchantsConnectedDevices401Error1(MerchantsConnectedDevices401Error1 value) =>
        new(Optional<MerchantsConnectedDevices401Error1>.Some(value), default, default);

    private static GetMerchantsMerchantAccountConnectedDevicesError AsMerchantsConnectedDevices403Error1(MerchantsConnectedDevices403Error1 value) =>
        new(default, Optional<MerchantsConnectedDevices403Error1>.Some(value), default);

    private static GetMerchantsMerchantAccountConnectedDevicesError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsConnectedDevices401Error1(out MerchantsConnectedDevices401Error1 value) =>
        _merchantsConnectedDevices401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsConnectedDevices403Error1(out MerchantsConnectedDevices403Error1 value) =>
        _merchantsConnectedDevices403Error1Value.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantAccountConnectedDevicesError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<MerchantsConnectedDevices401Error1>(response, ct).As(AsMerchantsConnectedDevices401Error1),
            403 => FromJson<MerchantsConnectedDevices403Error1>(response, ct).As(AsMerchantsConnectedDevices403Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantAccountConnectedDevicesErrorResponse : IErrorResponse<GetMerchantsMerchantAccountConnectedDevicesError>
{
    public static GetMerchantsMerchantAccountConnectedDevicesErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantAccountConnectedDevicesErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantAccountConnectedDevicesError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetMerchantsMerchantAccountConnectedDevicesError.Create(response, ct);
}

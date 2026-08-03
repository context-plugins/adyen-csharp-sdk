using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantAccountDevicesDeviceIdStatusError : ApiError
{
    private readonly Optional<MerchantsDevicesStatus401Error1> _merchantsDevicesStatus401Error1Value;

    private readonly Optional<MerchantsDevicesStatus403Error1> _merchantsDevicesStatus403Error1Value;

    private GetMerchantsMerchantAccountDevicesDeviceIdStatusError(Optional<MerchantsDevicesStatus401Error1> merchantsDevicesStatus401Error1Value,
        Optional<MerchantsDevicesStatus403Error1> merchantsDevicesStatus403Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsDevicesStatus401Error1Value = merchantsDevicesStatus401Error1Value;
        _merchantsDevicesStatus403Error1Value = merchantsDevicesStatus403Error1Value;
    }

    private static GetMerchantsMerchantAccountDevicesDeviceIdStatusError AsMerchantsDevicesStatus401Error1(MerchantsDevicesStatus401Error1 value) =>
        new(Optional<MerchantsDevicesStatus401Error1>.Some(value), default, default);

    private static GetMerchantsMerchantAccountDevicesDeviceIdStatusError AsMerchantsDevicesStatus403Error1(MerchantsDevicesStatus403Error1 value) =>
        new(default, Optional<MerchantsDevicesStatus403Error1>.Some(value), default);

    private static GetMerchantsMerchantAccountDevicesDeviceIdStatusError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsDevicesStatus401Error1(out MerchantsDevicesStatus401Error1 value) =>
        _merchantsDevicesStatus401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsDevicesStatus403Error1(out MerchantsDevicesStatus403Error1 value) =>
        _merchantsDevicesStatus403Error1Value.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantAccountDevicesDeviceIdStatusError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<MerchantsDevicesStatus401Error1>(response, ct).As(AsMerchantsDevicesStatus401Error1),
            403 => FromJson<MerchantsDevicesStatus403Error1>(response, ct).As(AsMerchantsDevicesStatus403Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantAccountDevicesDeviceIdStatusErrorResponse : IErrorResponse<GetMerchantsMerchantAccountDevicesDeviceIdStatusError>
{
    public static GetMerchantsMerchantAccountDevicesDeviceIdStatusErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantAccountDevicesDeviceIdStatusErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantAccountDevicesDeviceIdStatusError> Map(HttpResponseMessage response,
        CancellationToken ct) => GetMerchantsMerchantAccountDevicesDeviceIdStatusError.Create(response, ct);
}

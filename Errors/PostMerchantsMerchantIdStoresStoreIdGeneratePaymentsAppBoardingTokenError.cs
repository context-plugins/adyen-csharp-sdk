using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError : ApiError
{
    private readonly Optional<MerchantsStoresGeneratePaymentsAppBoardingToken400Error1> _merchantsStoresGeneratePaymentsAppBoardingToken400Error1Value;

    private readonly Optional<MerchantsStoresGeneratePaymentsAppBoardingToken401Error1> _merchantsStoresGeneratePaymentsAppBoardingToken401Error1Value;

    private readonly Optional<MerchantsStoresGeneratePaymentsAppBoardingToken403Error1> _merchantsStoresGeneratePaymentsAppBoardingToken403Error1Value;

    private readonly Optional<MerchantsStoresGeneratePaymentsAppBoardingToken422Error1> _merchantsStoresGeneratePaymentsAppBoardingToken422Error1Value;

    private readonly Optional<MerchantsStoresGeneratePaymentsAppBoardingToken500Error1> _merchantsStoresGeneratePaymentsAppBoardingToken500Error1Value;

    private PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError(Optional<MerchantsStoresGeneratePaymentsAppBoardingToken400Error1> merchantsStoresGeneratePaymentsAppBoardingToken400Error1Value,
        Optional<MerchantsStoresGeneratePaymentsAppBoardingToken401Error1> merchantsStoresGeneratePaymentsAppBoardingToken401Error1Value,
        Optional<MerchantsStoresGeneratePaymentsAppBoardingToken403Error1> merchantsStoresGeneratePaymentsAppBoardingToken403Error1Value,
        Optional<MerchantsStoresGeneratePaymentsAppBoardingToken422Error1> merchantsStoresGeneratePaymentsAppBoardingToken422Error1Value,
        Optional<MerchantsStoresGeneratePaymentsAppBoardingToken500Error1> merchantsStoresGeneratePaymentsAppBoardingToken500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsStoresGeneratePaymentsAppBoardingToken400Error1Value =
            merchantsStoresGeneratePaymentsAppBoardingToken400Error1Value;
        _merchantsStoresGeneratePaymentsAppBoardingToken401Error1Value =
            merchantsStoresGeneratePaymentsAppBoardingToken401Error1Value;
        _merchantsStoresGeneratePaymentsAppBoardingToken403Error1Value =
            merchantsStoresGeneratePaymentsAppBoardingToken403Error1Value;
        _merchantsStoresGeneratePaymentsAppBoardingToken422Error1Value =
            merchantsStoresGeneratePaymentsAppBoardingToken422Error1Value;
        _merchantsStoresGeneratePaymentsAppBoardingToken500Error1Value =
            merchantsStoresGeneratePaymentsAppBoardingToken500Error1Value;
    }

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsMerchantsStoresGeneratePaymentsAppBoardingToken400Error1(MerchantsStoresGeneratePaymentsAppBoardingToken400Error1 value) =>
        new(Optional<MerchantsStoresGeneratePaymentsAppBoardingToken400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsMerchantsStoresGeneratePaymentsAppBoardingToken401Error1(MerchantsStoresGeneratePaymentsAppBoardingToken401Error1 value) =>
        new(default,
            Optional<MerchantsStoresGeneratePaymentsAppBoardingToken401Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsMerchantsStoresGeneratePaymentsAppBoardingToken403Error1(MerchantsStoresGeneratePaymentsAppBoardingToken403Error1 value) =>
        new(default,
            default,
            Optional<MerchantsStoresGeneratePaymentsAppBoardingToken403Error1>.Some(value),
            default,
            default,
            default);

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsMerchantsStoresGeneratePaymentsAppBoardingToken422Error1(MerchantsStoresGeneratePaymentsAppBoardingToken422Error1 value) =>
        new(default,
            default,
            default,
            Optional<MerchantsStoresGeneratePaymentsAppBoardingToken422Error1>.Some(value),
            default,
            default);

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsMerchantsStoresGeneratePaymentsAppBoardingToken500Error1(MerchantsStoresGeneratePaymentsAppBoardingToken500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<MerchantsStoresGeneratePaymentsAppBoardingToken500Error1>.Some(value),
            default);

    private static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsStoresGeneratePaymentsAppBoardingToken400Error1(out MerchantsStoresGeneratePaymentsAppBoardingToken400Error1 value) =>
        _merchantsStoresGeneratePaymentsAppBoardingToken400Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresGeneratePaymentsAppBoardingToken401Error1(out MerchantsStoresGeneratePaymentsAppBoardingToken401Error1 value) =>
        _merchantsStoresGeneratePaymentsAppBoardingToken401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresGeneratePaymentsAppBoardingToken403Error1(out MerchantsStoresGeneratePaymentsAppBoardingToken403Error1 value) =>
        _merchantsStoresGeneratePaymentsAppBoardingToken403Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresGeneratePaymentsAppBoardingToken422Error1(out MerchantsStoresGeneratePaymentsAppBoardingToken422Error1 value) =>
        _merchantsStoresGeneratePaymentsAppBoardingToken422Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsStoresGeneratePaymentsAppBoardingToken500Error1(out MerchantsStoresGeneratePaymentsAppBoardingToken500Error1 value) =>
        _merchantsStoresGeneratePaymentsAppBoardingToken500Error1Value.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<MerchantsStoresGeneratePaymentsAppBoardingToken400Error1>(response, ct).As(AsMerchantsStoresGeneratePaymentsAppBoardingToken400Error1),
            401 => FromJson<MerchantsStoresGeneratePaymentsAppBoardingToken401Error1>(response, ct).As(AsMerchantsStoresGeneratePaymentsAppBoardingToken401Error1),
            403 => FromJson<MerchantsStoresGeneratePaymentsAppBoardingToken403Error1>(response, ct).As(AsMerchantsStoresGeneratePaymentsAppBoardingToken403Error1),
            422 => FromJson<MerchantsStoresGeneratePaymentsAppBoardingToken422Error1>(response, ct).As(AsMerchantsStoresGeneratePaymentsAppBoardingToken422Error1),
            500 => FromJson<MerchantsStoresGeneratePaymentsAppBoardingToken500Error1>(response, ct).As(AsMerchantsStoresGeneratePaymentsAppBoardingToken500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenErrorResponse : IErrorResponse<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError>
{
    public static PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenErrorResponse Instance { get; } = new();

    private PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenErrorResponse()
    {
    }

    public Task<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError.Create(response, ct);
}

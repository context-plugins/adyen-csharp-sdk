using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError : ApiError
{
    private readonly Optional<MerchantsGeneratePaymentsAppBoardingToken400Error1> _merchantsGeneratePaymentsAppBoardingToken400Error1Value;

    private readonly Optional<MerchantsGeneratePaymentsAppBoardingToken401Error1> _merchantsGeneratePaymentsAppBoardingToken401Error1Value;

    private readonly Optional<MerchantsGeneratePaymentsAppBoardingToken403Error1> _merchantsGeneratePaymentsAppBoardingToken403Error1Value;

    private readonly Optional<MerchantsGeneratePaymentsAppBoardingToken422Error1> _merchantsGeneratePaymentsAppBoardingToken422Error1Value;

    private readonly Optional<MerchantsGeneratePaymentsAppBoardingToken500Error1> _merchantsGeneratePaymentsAppBoardingToken500Error1Value;

    private PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError(Optional<MerchantsGeneratePaymentsAppBoardingToken400Error1> merchantsGeneratePaymentsAppBoardingToken400Error1Value,
        Optional<MerchantsGeneratePaymentsAppBoardingToken401Error1> merchantsGeneratePaymentsAppBoardingToken401Error1Value,
        Optional<MerchantsGeneratePaymentsAppBoardingToken403Error1> merchantsGeneratePaymentsAppBoardingToken403Error1Value,
        Optional<MerchantsGeneratePaymentsAppBoardingToken422Error1> merchantsGeneratePaymentsAppBoardingToken422Error1Value,
        Optional<MerchantsGeneratePaymentsAppBoardingToken500Error1> merchantsGeneratePaymentsAppBoardingToken500Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _merchantsGeneratePaymentsAppBoardingToken400Error1Value = merchantsGeneratePaymentsAppBoardingToken400Error1Value;
        _merchantsGeneratePaymentsAppBoardingToken401Error1Value = merchantsGeneratePaymentsAppBoardingToken401Error1Value;
        _merchantsGeneratePaymentsAppBoardingToken403Error1Value = merchantsGeneratePaymentsAppBoardingToken403Error1Value;
        _merchantsGeneratePaymentsAppBoardingToken422Error1Value = merchantsGeneratePaymentsAppBoardingToken422Error1Value;
        _merchantsGeneratePaymentsAppBoardingToken500Error1Value = merchantsGeneratePaymentsAppBoardingToken500Error1Value;
    }

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsMerchantsGeneratePaymentsAppBoardingToken400Error1(MerchantsGeneratePaymentsAppBoardingToken400Error1 value) =>
        new(Optional<MerchantsGeneratePaymentsAppBoardingToken400Error1>.Some(value),
            default,
            default,
            default,
            default,
            default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsMerchantsGeneratePaymentsAppBoardingToken401Error1(MerchantsGeneratePaymentsAppBoardingToken401Error1 value) =>
        new(default,
            Optional<MerchantsGeneratePaymentsAppBoardingToken401Error1>.Some(value),
            default,
            default,
            default,
            default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsMerchantsGeneratePaymentsAppBoardingToken403Error1(MerchantsGeneratePaymentsAppBoardingToken403Error1 value) =>
        new(default,
            default,
            Optional<MerchantsGeneratePaymentsAppBoardingToken403Error1>.Some(value),
            default,
            default,
            default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsMerchantsGeneratePaymentsAppBoardingToken422Error1(MerchantsGeneratePaymentsAppBoardingToken422Error1 value) =>
        new(default,
            default,
            default,
            Optional<MerchantsGeneratePaymentsAppBoardingToken422Error1>.Some(value),
            default,
            default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsMerchantsGeneratePaymentsAppBoardingToken500Error1(MerchantsGeneratePaymentsAppBoardingToken500Error1 value) =>
        new(default,
            default,
            default,
            default,
            Optional<MerchantsGeneratePaymentsAppBoardingToken500Error1>.Some(value),
            default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsFallback(RawError value) =>
        new(default, default, default, default, default, Optional<RawError>.Some(value));

    public bool TryGetMerchantsGeneratePaymentsAppBoardingToken400Error1(out MerchantsGeneratePaymentsAppBoardingToken400Error1 value) =>
        _merchantsGeneratePaymentsAppBoardingToken400Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsGeneratePaymentsAppBoardingToken401Error1(out MerchantsGeneratePaymentsAppBoardingToken401Error1 value) =>
        _merchantsGeneratePaymentsAppBoardingToken401Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsGeneratePaymentsAppBoardingToken403Error1(out MerchantsGeneratePaymentsAppBoardingToken403Error1 value) =>
        _merchantsGeneratePaymentsAppBoardingToken403Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsGeneratePaymentsAppBoardingToken422Error1(out MerchantsGeneratePaymentsAppBoardingToken422Error1 value) =>
        _merchantsGeneratePaymentsAppBoardingToken422Error1Value.TryGetValue(out value);

    public bool TryGetMerchantsGeneratePaymentsAppBoardingToken500Error1(out MerchantsGeneratePaymentsAppBoardingToken500Error1 value) =>
        _merchantsGeneratePaymentsAppBoardingToken500Error1Value.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<MerchantsGeneratePaymentsAppBoardingToken400Error1>(response, ct).As(AsMerchantsGeneratePaymentsAppBoardingToken400Error1),
            401 => FromJson<MerchantsGeneratePaymentsAppBoardingToken401Error1>(response, ct).As(AsMerchantsGeneratePaymentsAppBoardingToken401Error1),
            403 => FromJson<MerchantsGeneratePaymentsAppBoardingToken403Error1>(response, ct).As(AsMerchantsGeneratePaymentsAppBoardingToken403Error1),
            422 => FromJson<MerchantsGeneratePaymentsAppBoardingToken422Error1>(response, ct).As(AsMerchantsGeneratePaymentsAppBoardingToken422Error1),
            500 => FromJson<MerchantsGeneratePaymentsAppBoardingToken500Error1>(response, ct).As(AsMerchantsGeneratePaymentsAppBoardingToken500Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenErrorResponse : IErrorResponse<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError>
{
    public static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenErrorResponse Instance { get; } = new();

    private PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenErrorResponse()
    {
    }

    public Task<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError.Create(response, ct);
}

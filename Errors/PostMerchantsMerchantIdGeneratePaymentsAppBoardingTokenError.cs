using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError : ApiError
{
    private readonly Optional<DefaultErrorResponseEntity> _defaultErrorResponseEntityValue;

    private PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError(Optional<DefaultErrorResponseEntity> defaultErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _defaultErrorResponseEntityValue = defaultErrorResponseEntityValue;
    }

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsDefaultErrorResponseEntity(DefaultErrorResponseEntity value) =>
        new(Optional<DefaultErrorResponseEntity>.Some(value), default);

    private static PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity value) =>
        _defaultErrorResponseEntityValue.TryGetValue(out value);

    internal static Task<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<DefaultErrorResponseEntity>(response, ct).As(AsDefaultErrorResponseEntity),
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

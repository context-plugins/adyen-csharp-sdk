using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostValidateShopperIdError : ApiError
{
    private readonly Optional<CheckoutErrorResponseEntity> _checkoutErrorResponseEntityValue;

    private PostValidateShopperIdError(Optional<CheckoutErrorResponseEntity> checkoutErrorResponseEntityValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _checkoutErrorResponseEntityValue = checkoutErrorResponseEntityValue;
    }

    private static PostValidateShopperIdError AsCheckoutErrorResponseEntity(CheckoutErrorResponseEntity value) =>
        new(Optional<CheckoutErrorResponseEntity>.Some(value), default);

    private static PostValidateShopperIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetCheckoutErrorResponseEntity(out CheckoutErrorResponseEntity value) =>
        _checkoutErrorResponseEntityValue.TryGetValue(out value);

    private static Task<PostValidateShopperIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => response.Json<CheckoutErrorResponseEntity>().As(
                AsCheckoutErrorResponseEntity),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostValidateShopperIdError> Response { get; } = new(Create);
}

using System.Net.Http;
using System.Threading;
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

    internal static Task<PostValidateShopperIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<CheckoutErrorResponseEntity>(response, ct).As(AsCheckoutErrorResponseEntity),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostValidateShopperIdErrorResponse : IErrorResponse<PostValidateShopperIdError>
{
    public static PostValidateShopperIdErrorResponse Instance { get; } = new();

    private PostValidateShopperIdErrorResponse()
    {
    }

    public Task<PostValidateShopperIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostValidateShopperIdError.Create(response, ct);
}

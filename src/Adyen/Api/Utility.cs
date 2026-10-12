using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.Utility;

namespace Adyen.Api;

public sealed class Utility
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Utility(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get an Apple Pay session
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApplePaySessionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// You need to use this endpoint if you have an API-only integration with Apple Pay which uses Adyen's Apple Pay certificate.
    /// <para>
    /// The endpoint returns the Apple Pay session data which you need to complete the <see href="https://docs.adyen.com/payment-methods/apple-pay/api-only?tab=adyen-certificate-validation_1#complete-apple-pay-session-validation">Apple Pay session validation</see>.
    /// </para>
    /// </remarks>
    public Task<ApplePaySessionResponse> PostApplePaySessions(PostApplePaySessionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/applePay/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ApplePaySessionResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create originKey values for domains
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UtilityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostOriginKeysError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This operation takes the origin domains and returns a JSON object containing the corresponding origin keys for the domains.
    /// &gt; If you're still using origin key for your Web Drop-in or Components integration, we recommend <see href="https://docs.adyen.com/development-resources/client-side-authentication/migrate-from-origin-key-to-client-key">switching to client key</see>. This allows you to use a single key for all origins, add or remove origins without generating a new key, and detect the card type from the number entered in your payment form.
    /// </remarks>
    public Task<UtilityResponse> PostOriginKeys(PostOriginKeysRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/originKeys"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UtilityResponse>(),
            PostOriginKeysError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Updates the order for PayPal Express Checkout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaypalUpdateOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaypalUpdateOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the order for PayPal Express Checkout. This can be used to update the PayPal lightbox with an updated amount and delivery methods based on the delivery address.
    /// </remarks>
    public Task<PaypalUpdateOrderResponse> PostPaypalUpdateOrder(PostPaypalUpdateOrderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paypal/updateOrder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaypalUpdateOrderResponse>(),
            PostPaypalUpdateOrderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Validates shopper Id
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ValidateShopperIdResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostValidateShopperIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Validates the shopperId.
    /// </remarks>
    public Task<ValidateShopperIdResponse> PostValidateShopperId(PostValidateShopperIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/validateShopperId"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ValidateShopperIdResponse>(),
            PostValidateShopperIdError.Response,
            [],
            requestOptions,
            cancellationToken);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class Orders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Orders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Create an order
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order to be used for partial payments. Make a POST <c>/orders</c> call before making a <c>/payments</c> call when processing payments with different payment methods.
    /// </remarks>
    public Task<CreateOrderResponse> PostOrders(string? idempotencyKey,
        CreateOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateOrderResponse>(),
            PostOrdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel an order
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostOrdersCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels an order. Cancellation of an order results in an automatic rollback of all payments made in the order, either by canceling or refunding the payment, depending on the type of payment method.
    /// </remarks>
    public Task<CancelOrderResponse> PostOrdersCancel(string? idempotencyKey,
        CancelOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/orders/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelOrderResponse>(),
            PostOrdersCancelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the balance of a gift card
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceCheckResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentMethodsBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the balance remaining on a shopper's gift card. To check a gift card's balance, make a POST <c>/paymentMethods/balance</c> call and include the gift card's details inside a <c>paymentMethod</c> object.
    /// </remarks>
    public Task<BalanceCheckResponse> PostPaymentMethodsBalance(string? idempotencyKey,
        BalanceCheckRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentMethods/balance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceCheckResponse>(),
            PostPaymentMethodsBalanceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

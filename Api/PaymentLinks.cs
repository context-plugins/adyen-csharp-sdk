using System;
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

public sealed class PaymentLinks
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentLinks(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a payment link
    /// </summary>
    /// <param name="linkId">Unique identifier of the payment link.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentLinksLinkIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the payment link details using the payment link <c>id</c>.
    /// </remarks>
    public Task<PaymentLinkResponse> GetPaymentLinksLinkId(string linkId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentLinks/{linkId}"),
            [new TemplateParam("linkId", linkId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentLinkResponse>(),
            GetPaymentLinksLinkIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update the status of a payment link
    /// </summary>
    /// <param name="linkId">Unique identifier of the payment link.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchPaymentLinksLinkIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the status of a payment link. Use this endpoint to <see href="https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status">force the expiry of a payment link</see>.
    /// </remarks>
    public Task<PaymentLinkResponse> PatchPaymentLinksLinkId(string linkId,
        UpdatePaymentLinkRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentLinks/{linkId}"),
            [new TemplateParam("linkId", linkId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentLinkResponse>(),
            PatchPaymentLinksLinkIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a payment link
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentLinksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment link to a <see href="https://docs.adyen.com/unified-commerce/pay-by-link/">Pay by Link</see> page where the shopper can pay. The list of payment methods presented to the shopper depends on the <c>currency</c> and <c>country</c> parameters sent in the request.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api">Pay by Link documentation</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentLinkResponse> PostPaymentLinks(string? idempotencyKey,
        PaymentLinkRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentLinks"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentLinkResponse>(),
            PostPaymentLinksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

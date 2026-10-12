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
using Adyen.Requests.PaymentLinks;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentLinksLinkIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the payment link details using the payment link <c>id</c>.
    /// </remarks>
    public Task<PaymentLinkResponse> GetPaymentLinksLinkId(GetPaymentLinksLinkIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentLinks/{linkId}"),
            [new TemplateParam("linkId", request.LinkId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentLinkResponse>(),
            GetPaymentLinksLinkIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update the status of a payment link
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchPaymentLinksLinkIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the status of a payment link. Use this endpoint to <see href="https://docs.adyen.com/online-payments/pay-by-link#update-payment-link-status">force the expiry of a payment link</see>.
    /// </remarks>
    public Task<PaymentLinkResponse> PatchPaymentLinksLinkId(PatchPaymentLinksLinkIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentLinks/{linkId}"),
            [new TemplateParam("linkId", request.LinkId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentLinkResponse>(),
            PatchPaymentLinksLinkIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a payment link
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentLinkResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentLinksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment link to a <see href="https://docs.adyen.com/unified-commerce/pay-by-link/">Pay by Link</see> page where the shopper can pay. The list of payment methods presented to the shopper depends on the <c>currency</c> and <c>country</c> parameters sent in the request.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/pay-by-link#create-payment-links-through-api">Pay by Link documentation</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentLinkResponse> PostPaymentLinks(PostPaymentLinksRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/paymentLinks"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentLinkResponse>(),
            PostPaymentLinksError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

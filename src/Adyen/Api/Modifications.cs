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
using Adyen.Requests.Modifications;

namespace Adyen.Api;

public sealed class Modifications
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Modifications(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Change the authorised amount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAdjustAuthorisationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Allows you to increase or decrease the authorised amount after the initial authorisation has taken place. This functionality enables for example tipping, improving the chances your authorisation will be valid, or charging the shopper when they have already left the merchant premises.
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference"><c>/payments/{paymentPspReference}/amountUpdates</c></see>/amountUpdates) endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt;The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostAdjustAuthorisation(PostAdjustAuthorisationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/adjustAuthorisation"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostAdjustAuthorisationError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an authorisation
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the authorisation hold on a payment, returning a unique reference for this request. You can cancel payments after authorisation only for payment methods that support distinct authorisations and captures.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel">Cancel</see>.
    /// </para>
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference"><c>/payments/{paymentPspReference}/cancels</c></see>/cancels) endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostCancel(PostCancelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostCancelError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel or refund a payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCancelOrRefundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels a payment if it has not been captured yet, or refunds it if it has already been captured. This is useful when it is not certain if the payment has been captured or not (for example, when using auto-capture).
    /// <para>
    /// Do not use this endpoint for payments that involve:
    ///  * <see href="https://docs.adyen.com/online-payments/capture">Multiple partial captures</see>.
    ///  * <see href="https://docs.adyen.com/classic-platforms/processing-payments#providing-split-information">Split data</see> either at time of payment or capture for Adyen for Platforms.
    /// </para>
    /// <para>
    ///  Instead, check if the payment has been captured and make a corresponding <see href="https://docs.adyen.com/api-explorer/#/Payment/refund"><c>/refund</c></see> or <see href="https://docs.adyen.com/api-explorer/#/Payment/cancel"><c>/cancel</c></see> call.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel-or-refund">Cancel or refund</see>.
    /// </para>
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference"><c>/payments/{paymentPspReference}/reversals</c></see>/reversals) endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostCancelOrRefund(PostCancelOrRefundRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/cancelOrRefund"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostCancelOrRefundError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StandalonePaymentCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCancelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the authorisation on a payment that has not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/cancel#cancellation-webhook"><b>TECHNICAL_CANCEL</b> webhook</see>.
    /// <para>
    /// If you want to cancel a payment using the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see>, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels"><c>/payments/{paymentPspReference}/cancels</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// If you want to cancel a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/cancel">Cancel</see>.
    /// </para>
    /// </remarks>
    public Task<StandalonePaymentCancelResponse> PostCancels(PostCancelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/cancels"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StandalonePaymentCancelResponse>(),
            PostCancelsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Capture an authorisation
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCaptureError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures the authorisation hold on a payment, returning a unique reference for this request. Usually the full authorisation amount is captured, however it's also possible to capture a smaller amount, which results in cancelling the remaining authorisation balance.
    /// <para>
    /// Payment methods that are captured automatically after authorisation don't need to be captured. However, submitting a capture request on these transactions will not result in double charges. If immediate or delayed auto-capture is enabled, calling the capture method is not necessary.
    /// </para>
    /// <para>
    /// For more information refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/modify-payments/capture">Capture</see>.
    /// </para>
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference"><c>/payments/{paymentPspReference}/captures</c></see>/captures) endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostCapture(PostCaptureRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/capture"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostCaptureError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a donation
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDonateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a new payment to be created (including a new authorisation request) for the specified donation using the payment details of the original payment.
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/donations"><c>/donations</c></see> endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostDonate(PostDonateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/donate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostDonateError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an authorised amount
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentAmountUpdateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentsPaymentPspReferenceAmountUpdatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Increases or decreases the authorised payment amount and returns a unique reference for this request. You get the outcome of the request asynchronously, in an <see href="https://docs.adyen.com/development-resources/webhooks/webhook-types/#event-codes"><b>AUTHORISATION_ADJUSTMENT</b> webhook</see>.
    /// <para>
    /// You can only update authorised amounts that have not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>.
    /// </para>
    /// <para>
    /// The amount you specify in the request is the updated amount, which is larger or smaller than the initial authorised amount.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/adjust-authorisation#use-cases">Authorisation adjustment</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentAmountUpdateResponse> PostPaymentsPaymentPspReferenceAmountUpdates(PostPaymentsPaymentPspReferenceAmountUpdatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/amountUpdates"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentAmountUpdateResponse>(),
            PostPaymentsPaymentPspReferenceAmountUpdatesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentCancelResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentsPaymentPspReferenceCancelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the authorisation on a payment that has not yet been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/cancel#cancellation-webhook"><b>CANCELLATION</b> webhook</see>.
    /// <para>
    /// If you want to cancel a payment but don't have the <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments#responses-200-pspReference"><c>pspReference</c></see>, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cancels"><c>/cancels</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// If you want to cancel a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/cancel">Cancel</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentCancelResponse> PostPaymentsPaymentPspReferenceCancels(PostPaymentsPaymentPspReferenceCancelsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/cancels"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentCancelResponse>(),
            PostPaymentsPaymentPspReferenceCancelsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Capture an authorised payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentCaptureResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentsPaymentPspReferenceCapturesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Captures an authorised payment and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/capture#capture-notification"><b>CAPTURE</b> webhook</see>.
    /// <para>
    /// You can capture either the full authorised amount or a part of the authorised amount. By default, any unclaimed amount after a partial capture gets cancelled. This does not apply if you enabled multiple partial captures on your account and the payment method supports multiple partial captures.
    /// </para>
    /// <para>
    /// <see href="https://docs.adyen.com/online-payments/capture#automatic-capture">Automatic capture</see> is the default setting for most payment methods. In these cases, you don't need to make capture requests. However, making capture requests for payments that are captured automatically does not result in double charges.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/capture">Capture</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentCaptureResponse> PostPaymentsPaymentPspReferenceCaptures(PostPaymentsPaymentPspReferenceCapturesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/captures"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentCaptureResponse>(),
            PostPaymentsPaymentPspReferenceCapturesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund a captured payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentRefundResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentsPaymentPspReferenceRefundsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment that has been <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/captures">captured</see>, and returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/refund#refund-webhook"><b>REFUND</b> webhook</see>.
    /// <para>
    /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
    /// </para>
    /// <para>
    /// &gt; Some payment methods do not support partial refunds. To learn if a payment method supports partial refunds, refer to the payment method page such as <see href="https://docs.adyen.com/payment-methods/cards#supported-cards">cards</see>, <see href="https://docs.adyen.com/payment-methods/ideal">iDEAL</see>, or <see href="https://docs.adyen.com/payment-methods/klarna">Klarna</see>.
    /// </para>
    /// <para>
    /// If you want to refund a payment but are not sure whether it has been captured, use the <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/reversals"><c>/payments/{paymentPspReference}/reversals</c></see> endpoint instead.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/refund">Refund</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentRefundResponse> PostPaymentsPaymentPspReferenceRefunds(PostPaymentsPaymentPspReferenceRefundsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/refunds"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentRefundResponse>(),
            PostPaymentsPaymentPspReferenceRefundsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund or cancel a payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentReversalResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentsPaymentPspReferenceReversalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/refunds">Refunds</see> a payment if it has already been captured, and <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/payments/{paymentPspReference}/cancels">cancels</see> a payment if it has not yet been captured. Returns a unique reference for this request. You get the outcome of the request asynchronously, in a <see href="https://docs.adyen.com/online-payments/reversal/#cancel-or-refund-webhook"><b>CANCEL_OR_REFUND</b> webhook</see>.
    /// <para>
    /// The reversed amount is always the full payment amount.
    /// &gt; Do not use this request for payments that involve multiple partial captures.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/reversal">Reversal</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentReversalResponse> PostPaymentsPaymentPspReferenceReversals(PostPaymentsPaymentPspReferenceReversalsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/payments/{paymentPspReference}/reversals"),
            [new TemplateParam("paymentPspReference", request.PaymentPspReference)],
            [],
            [new HeaderParam("Idempotency-Key", request.IdempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentReversalResponse>(),
            PostPaymentsPaymentPspReferenceReversalsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund a captured payment
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRefundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds a payment that has previously been captured, returning a unique reference for this request. Refunding can be done on the full captured amount or a partial amount. Multiple (partial) refunds will be accepted as long as their sum doesn't exceed the captured amount. Payments which have been authorised, but not captured, cannot be refunded, use the /cancel method instead.
    /// <para>
    /// Some payment methods/gateways do not support partial/multiple refunds.
    /// A margin above the captured limit can be configured to cover shipping/handling costs.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/modify-payments/refund">Refund</see>.
    /// </para>
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/(paymentPspReference"><c>/payments/{paymentPspReference}/refunds</c></see>/refunds) endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostRefund(PostRefundRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/refund"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostRefundError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an authorisation using your reference
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTechnicalCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to cancel a payment if you do not have the PSP reference of the original payment request available.
    /// <para>
    /// In your call, refer to the original payment by using the <c>reference</c> that you specified in your payment request.
    /// </para>
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/online-payments/classic-integrations/modify-payments/cancel#technical-cancel">Technical cancel</see>.
    /// </para>
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/cancels"><c>/cancels</c></see> endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostTechnicalCancel(PostTechnicalCancelRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/technicalCancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostTechnicalCancelError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Cancel an in-person refund
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ModificationResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostVoidPendingRefundError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// This endpoint allows you to cancel an unreferenced refund request before it has been completed.
    /// <para>
    /// In your call, you can refer to the original refund request either by using the <c>tenderReference</c>, or the <c>pspReference</c>. We recommend implementing based on the <c>tenderReference</c>, as this is generated for both offline and online transactions.
    /// </para>
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/point-of-sale/basic-tapi-integration/refund-payment/cancel-unreferenced">Cancel an unreferenced refund</see>.
    /// </para>
    /// </remarks>
    public Task<ModificationResult> PostVoidPendingRefund(PostVoidPendingRefundRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default1("/voidPendingRefund"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ModificationResult>(),
            PostVoidPendingRefundError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

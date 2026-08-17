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
using Adyen.Models.AllOf;

namespace Adyen.Api;

public sealed class Payments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Payments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get the result of a payment session
    /// </summary>
    /// <param name="sessionId">A unique identifier of the session.</param>
    /// <param name="sessionResult">The <c>sessionResult</c> value from the Drop-in or Component.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SessionResultResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the status of the payment session with the <c>sessionId</c> and <c>sessionResult</c> specified in the path.
    /// </remarks>
    public Task<SessionResultResponse> GetSessionsSessionId(string sessionId,
        string sessionResult,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sessions/{sessionId}"),
            [new TemplateParam("sessionId", sessionId)],
            [new Param("sessionResult", sessionResult)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SessionResultResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an authorisation
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAuthoriseError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment with a unique reference (<c>pspReference</c>) and attempts to obtain an authorisation hold. For cards, this amount can be captured or cancelled later. Non-card payment methods typically don't support this and will automatically capture as part of the authorisation.
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments"><c>/payments</c></see> endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt;The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<PaymentResult> PostAuthorise(PaymentRequest1? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/authorise"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentResult>(),
            PostAuthoriseErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Complete a 3DS authorisation
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAuthorise3DError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For an authenticated 3D Secure session, completes the payment authorisation. This endpoint must receive the <c>md</c> and <c>paResponse</c> parameters that you get from the card issuer after a shopper pays via 3D Secure.
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details"><c>/payments/details</c></see> endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt; The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<PaymentResult> PostAuthorise3D(PaymentRequest3D? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/authorise3d"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentResult>(),
            PostAuthorise3DErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Complete a 3DS2 authorisation
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAuthorise3Ds2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// For an authenticated 3D Secure 2 session, completes the payment authorisation. This endpoint must receive the <c>threeDS2Token</c> and <c>threeDS2Result</c> parameters.
    /// <para>
    /// &gt; This endpoint is <see href="https://docs.adyen.com/online-payments/upgrade-your-integration#checkout-api-lifecycle">inactive</see> and is no longer supported for new integrations.
    /// &gt; * If you are building a new integration, use the Checkout API <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/payments/details"><c>/payments/details</c></see> endpoint instead.
    /// &gt; * If you have an existing integration using this endpoint, reach out to your Adyen contact and <see href="https://docs.adyen.com/online-payments/upgrade-your-integration/migrate-to-checkout-api">migrate to the Checkout API</see>.
    /// </para>
    /// <para>
    /// &gt;The Checkout API enables your <see href="https://docs.adyen.com/online-payments">online payments</see> integration to accept all supported payment methods, use the latest features, and access more benefits.
    /// </para>
    /// </remarks>
    public Task<PaymentResult> PostAuthorise3Ds2(PaymentRequest3Ds2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/authorise3ds2"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentResult>(),
            PostAuthorise3Ds2ErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the brands and other details of a card
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Use this endpoint to get information about the card or network token that enables you to decide on the routing of the transaction and the eligibility of the card for the type of transaction.
    /// <para>
    /// If you include <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/latest/post/cardDetails__reqParam_supportedBrands">your supported brands</see> in the request, the response also tells you if you support each <see href="https://docs.adyen.com/api-explorer/Checkout/latest/post/cardDetails#responses-200-brands">brand that was identified on the card</see>.
    /// </para>
    /// <para>
    /// If you have an API-only integration and collect card data, use this endpoint to find out if the shopper's card is co-bad. For co-badged cards, you must let the shopper choose the brand to pay with  if you support both brands.
    /// </para>
    /// <para>
    /// ## Server-side API libraries
    /// We provide open-source <see href="https://docs.adyen.com/development-resources/libraries/">server-side API libraries</see> in several languages:
    /// - PHP
    /// - Java
    /// - Node.js
    /// - .NET
    /// - Go
    /// - Python
    /// - Ruby
    /// - Apex (beta)
    /// </para>
    /// <para>
    /// See our <see href="https://github.com/adyen-examples#%EF%B8%8F-official-integration-examples">integration examples</see> for example uses of the libraries.
    /// </para>
    /// <para>
    /// ## Developer resources
    /// BIN Lookup API is available through a Postman collection. Click the button below to create a fork, then set the environment variables at <b>Environments</b>&amp;nbsp;&gt;&amp;nbsp;<b>Adyen&amp;nbsp;APIs</b>.
    /// </para>
    /// <para>
    /// <see href="https://run.pstmn.io/button.svg">![Run in Postman</see>](https://god.gw.postman.com/run-collection/25716737-677c7679-a695-4ebb-91da-68b4e7c9228a?action=collection%2Ffork&amp;source=rip_markdown&amp;collection-url=entityId%3D25716737-677c7679-a695-4ebb-91da-68b4e7c9228a%26entityType%3Dcollection%26workspaceId%3Da8d63f9f-cfc7-4810-90c5-9e0c60030d3e#?env%5BAdyen%20APIs%5D=W3sia2V5IjoiWC1BUEktS2V5IiwidmFsdWUiOiIiLCJlbmFibGVkIjp0cnVlLCJ0eXBlIjoic2VjcmV0In0seyJrZXkiOiJZT1VSX01FUkNIQU5UX0FDQ09VTlQiLCJ2YWx1ZSI6IiIsImVuYWJsZWQiOnRydWUsInR5cGUiOiJkZWZhdWx0In0seyJrZXkiOiJZT1VSX0NPTVBBTllfQUNDT1VOVCIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifSx7ImtleSI6IllPVVJfQkFMQU5DRV9QTEFURk9STSIsInZhbHVlIjoiIiwiZW5hYmxlZCI6dHJ1ZSwidHlwZSI6ImRlZmF1bHQifV0=)
    /// </para>
    /// </remarks>
    public Task<CardDetailsResponse> PostCardDetails(string? idempotencyKey,
        CardDetailsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cardDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CardDetailsResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the 3DS authentication result
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthenticationResultResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetAuthenticationResultError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Return the authentication result after doing a 3D Secure authentication only.
    /// </remarks>
    public Task<AuthenticationResultResponse> PostGetAuthenticationResult(AuthenticationResultRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/getAuthenticationResult"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AuthenticationResultResponse>(),
            PostGetAuthenticationResultErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of available payment methods
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentMethodsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentMethodsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the list of available payment methods for the transaction, based on the transaction information like amount, country, and currency.
    /// </remarks>
    public Task<PaymentMethodsResponse> PostPaymentMethods(string? idempotencyKey,
        PaymentMethodsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentMethods"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentMethodsResponse>(),
            PostPaymentMethodsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Start a transaction
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends payment parameters (like amount, country, and currency) together with other required input details collected from the shopper. To know more about required parameters for specific payment methods, refer to our <see href="https://docs.adyen.com/payment-methods">payment method guides</see>.
    /// The response depends on the <see href="https://docs.adyen.com/payment-methods#payment-flow">payment flow</see>:
    /// * For a direct flow, the response includes a <c>pspReference</c> and a <c>resultCode</c> with the payment result, for example <b>Authorised</b> or <b>Refused</b>.
    /// * For a redirect or additional action, the response contains an <c>action</c> object.
    /// </remarks>
    public Task<PaymentResponse> PostPayments(string? idempotencyKey,
        PaymentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentResponse>(),
            PostPaymentsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel payment
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CancelPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentsCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the payment. Returns a URL for user redirection.
    /// </remarks>
    public Task<CancelPaymentResponse> PostPaymentsCancel(CancelPaymentRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default20("/payments/cancel"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CancelPaymentResponse>(),
            PostPaymentsCancelErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Confirm payment
    /// </summary>
    /// <param name="wwwAuthenticate">Header for authenticating through SCA: Contains information for an SCA challenge for A2A payments.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ConfirmPaymentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentsConfirmError"/> when the server returns an error response.</exception>
    /// <remarks>
    ///     Confirms the payment using Strong Customer Authentication (SCA).
    /// <para>
    ///     To confirm a payment you must make this request two times:
    /// </para>
    /// <para>
    ///     1. Make this request to initiate SCA and receive the WWW-Authenticate header.
    ///     2. After the user completes the SCA challenge, make this request again, including the updated WWW-Authenticate header.
    /// </para>
    /// <para>
    ///     The second response provides a redirection URL that guides the user to a payment success or failure page.
    /// For more information, see our <see href="https://docs.adyen.com/business-accounts/send-funds-ideal-integration">documentation</see>.
    /// </para>
    /// </remarks>
    public Task<ConfirmPaymentResponse> PostPaymentsConfirm(string? wwwAuthenticate,
        ConfirmPaymentRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default20("/payments/confirm"),
            [],
            [],
            [new HeaderParam("WWW-Authenticate", wwwAuthenticate),
                new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ConfirmPaymentResponse>(),
            PostPaymentsConfirmErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Submit details for a payment
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentsDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Submits details for a payment created using <c>/payments</c>. This step is only needed when no final state has been reached on the <c>/payments</c> request, for example when the shopper was redirected to another page to complete the payment.
    /// </remarks>
    public Task<PaymentDetailsResponse> PostPaymentsDetails(string? idempotencyKey,
        PaymentDetailsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payments/details"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentDetailsResponse>(),
            PostPaymentsDetailsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Retrieve payment details
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentDetailsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentsDetails1Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of an open payment, which you must show to the user. Also provides a token required to <see href="https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/confirm">confirm</see> or <see href="https://docs.adyen.com/api-explorer/a2a-payments/latest/post/payments/cancel">cancel</see> the payment.
    /// </remarks>
    public Task<PaymentDetailsResponse1> PostPaymentsDetails1(IdealPaymentDetailsRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default20("/payments/details"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentDetailsResponse1>(),
            PostPaymentsDetails1ErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Get the 3DS2 authentication result
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ThreeDs2ResultResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRetrieve3Ds2ResultError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the <c>threeDS2Result</c> after doing a 3D Secure 2 authentication only.
    /// </remarks>
    public Task<ThreeDs2ResultResponse> PostRetrieve3Ds2Result(ThreeDs2ResultRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default1("/retrieve3ds2Result"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ThreeDs2ResultResponse>(),
            PostRetrieve3Ds2ResultErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a payment session
    /// </summary>
    /// <param name="idempotencyKey">A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCheckoutSessionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment session for <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Drop-in">Drop-in</see>, <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Components">Components</see>, and <see href="https://docs.adyen.com/online-payments/build-your-integration/sessions-flow/?platform=Web&amp;integration=Hosted+Checkout">Hosted Checkout</see> integrations.
    /// <para>
    /// The response contains encrypted payment session data. The front end then uses the session data to make any required server-side calls for the payment flow.
    /// </para>
    /// <para>
    /// You get the payment outcome asynchronously, in an <see href="https://docs.adyen.com/api-explorer/#/Webhooks/latest/post/AUTHORISATION">AUTHORISATION</see> webhook.
    /// </para>
    /// </remarks>
    public Task<CreateCheckoutSessionResponse> PostSessions(string? idempotencyKey,
        CreateCheckoutSessionRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", idempotencyKey)],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCheckoutSessionResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

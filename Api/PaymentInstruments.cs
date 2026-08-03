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

public sealed class PaymentInstruments
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentInstruments(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-paymentInstruments-id
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a payment instrument.
    /// </remarks>
    public Task<PaymentInstrument> GetPaymentInstrumentsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument>(),
            GetPaymentInstrumentsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-paymentInstruments-id-networkTokenActivationData
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworkTokenActivationDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentsIdNetworkTokenActivationDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the network token activation data for a payment instrument.
    /// </remarks>
    public Task<NetworkTokenActivationDataResponse> GetPaymentInstrumentsIdNetworkTokenActivationData(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}/networkTokenActivationData"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NetworkTokenActivationDataResponse>(),
            GetPaymentInstrumentsIdNetworkTokenActivationDataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-paymentInstruments-id-networkTokens
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListNetworkTokensResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentsIdNetworkTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the network tokens connected to a payment instrument.
    /// </remarks>
    public Task<ListNetworkTokensResponse> GetPaymentInstrumentsIdNetworkTokens(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}/networkTokens"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListNetworkTokensResponse>(),
            GetPaymentInstrumentsIdNetworkTokensErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-paymentInstruments-id-reveal
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentRevealInfo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentsIdRevealError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the primary account number (PAN) of a payment instrument.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Balance Platform BCL PCI role</description></item>
    /// </list>
    /// </remarks>
    public Task<PaymentInstrumentRevealInfo> GetPaymentInstrumentsIdReveal(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}/reveal"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrumentRevealInfo>(),
            GetPaymentInstrumentsIdRevealErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-paymentInstruments-id-transactionRules
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a payment instrument.
    /// </remarks>
    public Task<TransactionRulesResponse> GetPaymentInstrumentsIdTransactionRules(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}/transactionRules"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetPaymentInstrumentsIdTransactionRulesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-paymentInstruments-id
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdatePaymentInstrument"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchPaymentInstrumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with <b>inactive</b> status, you can still update the balance account associated with the card.
    /// </remarks>
    public Task<UpdatePaymentInstrument> PatchPaymentInstrumentsId(string id,
        PaymentInstrumentUpdateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<UpdatePaymentInstrument>(),
            PatchPaymentInstrumentsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-paymentInstruments
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentInstrumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.
    /// <para>
    ///  For more information, refer to <see href="https://docs.adyen.com/issuing/create-cards">Issue cards</see> or <see href="https://docs.adyen.com/platforms/business-accounts">Issue business accounts</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentInstrument> PostPaymentInstruments(PaymentInstrumentInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInstrument>(),
            PostPaymentInstrumentsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-paymentInstruments-id-networkTokenActivationData
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworkTokenActivationDataResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentInstrumentsIdNetworkTokenActivationDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create provisioning data for a network token. Use the provisioning data to add a user's payment instrument to their digital wallet.
    /// </remarks>
    public Task<NetworkTokenActivationDataResponse> PostPaymentInstrumentsIdNetworkTokenActivationData(string id,
        NetworkTokenActivationDataRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/{id}/networkTokenActivationData"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<NetworkTokenActivationDataResponse>(),
            PostPaymentInstrumentsIdNetworkTokenActivationDataErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-paymentInstruments-reveal
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentRevealResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentInstrumentsRevealError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the encrypted data of a specified payment instrument. These data include:
    /// <list type="bullet">
    ///   <item><description>The primary account number (PAN)</description></item>
    ///   <item><description>The card verification code (CVC)</description></item>
    ///   <item><description>The expiry date</description></item>
    /// </list>
    /// <para>
    /// You can decrypt the data to reveal it in your user interface.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following role:
    /// * Bank Issuing PAN Reveal Webservice role
    /// </para>
    /// </remarks>
    public Task<PaymentInstrumentRevealResponse> PostPaymentInstrumentsReveal(PaymentInstrumentRevealRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/paymentInstruments/reveal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInstrumentRevealResponse>(),
            PostPaymentInstrumentsRevealErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

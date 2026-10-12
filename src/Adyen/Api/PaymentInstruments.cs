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
using Adyen.Requests.PaymentInstruments;

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
    /// Get a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a payment instrument.
    /// </remarks>
    public Task<PaymentInstrument1> GetPaymentInstrumentsId(GetPaymentInstrumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrument1>(),
            GetPaymentInstrumentsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get network token activation data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworkTokenActivationDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsIdNetworkTokenActivationDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the network token activation data for a payment instrument.
    /// </remarks>
    public Task<NetworkTokenActivationDataResponse> GetPaymentInstrumentsIdNetworkTokenActivationData(GetPaymentInstrumentsIdNetworkTokenActivationDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}/networkTokenActivationData"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<NetworkTokenActivationDataResponse>(),
            GetPaymentInstrumentsIdNetworkTokenActivationDataError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List network tokens
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListNetworkTokensResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsIdNetworkTokensError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// List the network tokens connected to a payment instrument.
    /// </remarks>
    public Task<ListNetworkTokensResponse> GetPaymentInstrumentsIdNetworkTokens(GetPaymentInstrumentsIdNetworkTokensRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}/networkTokens"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListNetworkTokensResponse>(),
            GetPaymentInstrumentsIdNetworkTokensError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the PAN of a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentRevealInfo"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsIdRevealError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the primary account number (PAN) of a payment instrument.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/issuing/manage-access/api-credentials-web-service#api-permissions">role</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Balance Platform BCL PCI role</description></item>
    /// </list>
    /// </remarks>
    public Task<PaymentInstrumentRevealInfo> GetPaymentInstrumentsIdReveal(GetPaymentInstrumentsIdRevealRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}/reveal"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrumentRevealInfo>(),
            GetPaymentInstrumentsIdRevealError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all transaction rules for a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetPaymentInstrumentsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with a payment instrument.
    /// </remarks>
    public Task<TransactionRulesResponse> GetPaymentInstrumentsIdTransactionRules(GetPaymentInstrumentsIdTransactionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}/transactionRules"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetPaymentInstrumentsIdTransactionRulesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdatePaymentInstrument"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchPaymentInstrumentsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a payment instrument. Once a payment instrument is already active, you can only update its status. However, for cards created with <b>inactive</b> status, you can still update the balance account associated with the card.
    /// </remarks>
    public Task<UpdatePaymentInstrument> PatchPaymentInstrumentsId(PatchPaymentInstrumentsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdatePaymentInstrument>(),
            PatchPaymentInstrumentsIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrument1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentInstrumentsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment instrument to issue a physical card, a virtual card, or a business account to your user.
    /// <para>
    ///  For more information, refer to <see href="https://docs.adyen.com/issuing/create-cards">Issue cards</see> or <see href="https://docs.adyen.com/platforms/business-accounts">Issue business accounts</see>.
    /// </para>
    /// </remarks>
    public Task<PaymentInstrument1> PostPaymentInstruments(PostPaymentInstrumentsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentInstrument1>(),
            PostPaymentInstrumentsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create network token provisioning data
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NetworkTokenActivationDataResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentInstrumentsIdNetworkTokenActivationDataError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create provisioning data for a network token. Use the provisioning data to add a user's payment instrument to their digital wallet.
    /// </remarks>
    public Task<NetworkTokenActivationDataResponse> PostPaymentInstrumentsIdNetworkTokenActivationData(PostPaymentInstrumentsIdNetworkTokenActivationDataRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/{id}/networkTokenActivationData"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<NetworkTokenActivationDataResponse>(),
            PostPaymentInstrumentsIdNetworkTokenActivationDataError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Reveal the data of a payment instrument
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentRevealResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPaymentInstrumentsRevealError"/> when the server returns an error response.</exception>
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
    public Task<PaymentInstrumentRevealResponse> PostPaymentInstrumentsReveal(PostPaymentInstrumentsRevealRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/paymentInstruments/reveal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PaymentInstrumentRevealResponse>(),
            PostPaymentInstrumentsRevealError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

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

public sealed class PaymentInstrumentGroups
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PaymentInstrumentGroups(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a payment instrument group
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument group.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentGroup"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentGroupsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a payment instrument group.
    /// </remarks>
    public Task<PaymentInstrumentGroup> GetPaymentInstrumentGroupsId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/paymentInstrumentGroups/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaymentInstrumentGroup>(),
            GetPaymentInstrumentGroupsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get all transaction rules for a payment instrument group
    /// </summary>
    /// <param name="id">The unique identifier of the payment instrument group.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetPaymentInstrumentGroupsIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all the transaction rules associated with a payment instrument group.
    /// </remarks>
    public Task<TransactionRulesResponse> GetPaymentInstrumentGroupsIdTransactionRules(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/paymentInstrumentGroups/{id}/transactionRules"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetPaymentInstrumentGroupsIdTransactionRulesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a payment instrument group
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentInstrumentGroup"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPaymentInstrumentGroupsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a payment instrument group to associate and group payment instrument resources together. You can apply a transaction rule to a payment instrument group.
    /// </remarks>
    public Task<PaymentInstrumentGroup> PostPaymentInstrumentGroups(PaymentInstrumentGroupInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/paymentInstrumentGroups"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentInstrumentGroup>(),
            PostPaymentInstrumentGroupsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

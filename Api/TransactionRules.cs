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

public sealed class TransactionRules
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TransactionRules(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-transactionRules-transactionRuleId
    /// </summary>
    /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a transaction rule.
    /// </remarks>
    public Task<TransactionRule> DeleteTransactionRulesTransactionRuleId(string transactionRuleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", transactionRuleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRule>(),
            DeleteTransactionRulesTransactionRuleIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-transactionRules-transactionRuleId
    /// </summary>
    /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRuleResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a transaction rule.
    /// </remarks>
    public Task<TransactionRuleResponse> GetTransactionRulesTransactionRuleId(string transactionRuleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", transactionRuleId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRuleResponse>(),
            GetTransactionRulesTransactionRuleIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-transactionRules-transactionRuleId
    /// </summary>
    /// <param name="transactionRuleId">The unique identifier of the transaction rule.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a transaction rule.
    /// <list type="bullet">
    ///   <item><description>To update only the status of a transaction rule, send only the <c>status</c> parameter. All other parameters not provided in the request are left unchanged.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>When updating any other parameter, you need to send all existing resource parameters. If you omit a parameter in the request, that parameter is removed from the resource.</description></item>
    /// </list>
    /// </remarks>
    public Task<TransactionRule> PatchTransactionRulesTransactionRuleId(string transactionRuleId,
        TransactionRuleInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", transactionRuleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionRule>(),
            PatchTransactionRulesTransactionRuleIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-transactionRules
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a <see href="https://docs.adyen.com/issuing/transaction-rules">transaction rule</see>. When your user makes a transaction with their Adyen-issued card, the transaction is allowed or declined based on the conditions and outcome defined in the transaction rule. You can apply the transaction rule to several cards, such as all the cards in your platform, or to a specific card. For use cases, see <see href="https://docs.adyen.com/issuing/transaction-rules/examples">examples</see>.
    /// </remarks>
    public Task<TransactionRule> PostTransactionRules(TransactionRuleInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactionRules"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionRule>(),
            PostTransactionRulesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

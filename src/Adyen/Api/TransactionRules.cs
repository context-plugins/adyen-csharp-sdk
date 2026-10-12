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
using Adyen.Requests.TransactionRules;

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
    /// Delete a transaction rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a transaction rule.
    /// </remarks>
    public Task<TransactionRule> DeleteTransactionRulesTransactionRuleId(DeleteTransactionRulesTransactionRuleIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", request.TransactionRuleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRule>(),
            DeleteTransactionRulesTransactionRuleIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a transaction rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRuleResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a transaction rule.
    /// </remarks>
    public Task<TransactionRuleResponse> GetTransactionRulesTransactionRuleId(GetTransactionRulesTransactionRuleIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", request.TransactionRuleId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRuleResponse>(),
            GetTransactionRulesTransactionRuleIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a transaction rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchTransactionRulesTransactionRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates a transaction rule.
    /// <list type="bullet">
    ///   <item><description>To update only the status of a transaction rule, send only the <c>status</c> parameter. All other parameters not provided in the request are left unchanged.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>When updating any other parameter, you need to send all existing resource parameters. If you omit a parameter in the request, that parameter is removed from the resource.</description></item>
    /// </list>
    /// </remarks>
    public Task<TransactionRule> PatchTransactionRulesTransactionRuleId(PatchTransactionRulesTransactionRuleIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/transactionRules/{transactionRuleId}"),
            [new TemplateParam("transactionRuleId", request.TransactionRuleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransactionRule>(),
            PatchTransactionRulesTransactionRuleIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a transaction rule
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRule"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a <see href="https://docs.adyen.com/issuing/transaction-rules">transaction rule</see>. When your user makes a transaction with their Adyen-issued card, the transaction is allowed or declined based on the conditions and outcome defined in the transaction rule. You can apply the transaction rule to several cards, such as all the cards in your platform, or to a specific card. For use cases, see <see href="https://docs.adyen.com/issuing/transaction-rules/examples">examples</see>.
    /// </remarks>
    public Task<TransactionRule> PostTransactionRules(PostTransactionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/transactionRules"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransactionRule>(),
            PostTransactionRulesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

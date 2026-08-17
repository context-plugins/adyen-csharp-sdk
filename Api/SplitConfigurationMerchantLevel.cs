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

public sealed class SplitConfigurationMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal SplitConfigurationMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a split configuration profile
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId,
        string splitConfigurationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a rule
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="ruleId"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the rule specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(string merchantId,
        string splitConfigurationId,
        string ruleId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId),
                new TemplateParam("ruleId", ruleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            DeleteMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of split configuration profiles
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfigurationList"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdSplitConfigurationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of split configuration profiles for the merchant account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfigurationList> GetMerchantsMerchantIdSplitConfigurations(string merchantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfigurationList>(),
            GetMerchantsMerchantIdSplitConfigurationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a split configuration profile
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId,
        string splitConfigurationId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<SplitConfiguration>(),
            GetMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update the description of the split configuration profile
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the description of the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId,
        string splitConfigurationId,
        UpdateSplitConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<SplitConfiguration>(),
            PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update the split conditions
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The identifier of the split configuration.</param>
    /// <param name="ruleId">The unique identifier of the split configuration rule.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-condition">split conditions of the rule</see> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleId(string merchantId,
        string splitConfigurationId,
        string ruleId,
        UpdateSplitConfigurationRuleRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId),
                new TemplateParam("ruleId", ruleId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<SplitConfiguration>(),
            PatchMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdRulesRuleIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update the split logic
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="ruleId">The unique identifier of the split configuration rule.</param>
    /// <param name="splitLogicId">The unique identifier of the split configuration split.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsSplitConfigurationsRulesSplitLogicError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#update-split-logic">split logic</see> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> PatchMerchantsSplitConfigurationsRulesSplitLogic(string merchantId,
        string splitConfigurationId,
        string ruleId,
        string splitLogicId,
        UpdateSplitConfigurationLogicRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}/rules/{ruleId}/splitLogic/{splitLogicId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId),
                new TemplateParam("ruleId", ruleId),
                new TemplateParam("splitLogicId", splitLogicId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<SplitConfiguration>(),
            PatchMerchantsSplitConfigurationsRulesSplitLogicErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a split configuration profile
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdSplitConfigurationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a split configuration profile to <see href="https://docs.adyen.com/platforms/automatic-split-configuration/">split payments automatically</see>. After you <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId">associate it with a store</see>/stores/(storeId)#request-splitConfiguration) in your merchant account, it splits the funds of all transactions processed through that store between your liable balance account and <see href="https://docs.adyen.com/api-explorer/Management/latest/patch/merchants/(merchantId">your user's balance account</see>/stores/(storeId)#request-splitConfiguration-balanceAccountId).
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> PostMerchantsMerchantIdSplitConfigurations(string merchantId,
        SplitConfiguration? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SplitConfiguration>(),
            PostMerchantsMerchantIdSplitConfigurationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a rule
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="splitConfigurationId">The unique identifier of the split configuration.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SplitConfiguration"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// <see href="https://docs.adyen.com/platforms/automatic-split-configuration/manage-split-configurations/api/#create-rule">Creates a rule</see> in the split configuration profile specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API - SplitConfiguration read and write
    /// </para>
    /// </remarks>
    public Task<SplitConfiguration> PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationId(string merchantId,
        string splitConfigurationId,
        SplitConfigurationRule? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/splitConfigurations/{splitConfigurationId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("splitConfigurationId", splitConfigurationId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SplitConfiguration>(),
            PostMerchantsMerchantIdSplitConfigurationsSplitConfigurationIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

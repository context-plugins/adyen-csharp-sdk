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

public sealed class PayoutSettingsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PayoutSettingsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-merchants-merchantId-payoutSettings-payoutSettingsId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes the payout setting identified in the path.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Management API—Payout account settings read and write</description></item>
    /// </list>
    /// </remarks>
    public Task DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId,
        string payoutSettingsId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("payoutSettingsId", payoutSettingsId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId-payoutSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettingsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPayoutSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of payout settings for the merchant account identified in the path.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Payout account settings read
    /// </para>
    /// </remarks>
    public Task<PayoutSettingsResponse> GetMerchantsMerchantIdPayoutSettings(string merchantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/payoutSettings"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutSettingsResponse>(),
            GetMerchantsMerchantIdPayoutSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId-payoutSettings-payoutSettingsId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payout setting identified in the path.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Payout account settings read
    /// </para>
    /// </remarks>
    public Task<PayoutSettings> GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId,
        string payoutSettingsId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("payoutSettingsId", payoutSettingsId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutSettings>(),
            GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-merchants-merchantId-payoutSettings-payoutSettingsId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="payoutSettingsId">The unique identifier of the payout setting.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the payout setting identified in the path. You can enable or disable the payout setting.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Management API—Payout account settings read and write</description></item>
    /// </list>
    /// </remarks>
    public Task<PayoutSettings> PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(string merchantId,
        string payoutSettingsId,
        UpdatePayoutSettingsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("payoutSettingsId", payoutSettingsId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<PayoutSettings>(),
            PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantId-payoutSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdPayoutSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to add a payout setting for the merchant account specified in the path. A payout setting links the merchant account to the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments">transfer instrument</see> that contains the details of the payout bank account. Adyen verifies the bank account before allowing and enabling the payout setting.
    /// <para>
    /// If you're accepting payments in multiple currencies, you may add multiple payout settings for the merchant account.
    /// </para>
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Management API—Payout account settings read and write</description></item>
    /// </list>
    /// </remarks>
    public Task<PayoutSettings> PostMerchantsMerchantIdPayoutSettings(string merchantId,
        PayoutSettingsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/payoutSettings"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PayoutSettings>(),
            PostMerchantsMerchantIdPayoutSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

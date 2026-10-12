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
using Adyen.Requests.PayoutSettingsMerchantLevel;

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
    /// Delete a payout setting
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
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
    public Task DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsId(DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("payoutSettingsId", request.PayoutSettingsId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of payout settings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettingsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPayoutSettingsError"/> when the server returns an error response.</exception>
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
    public Task<PayoutSettingsResponse> GetMerchantsMerchantIdPayoutSettings(GetMerchantsMerchantIdPayoutSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/payoutSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutSettingsResponse>(),
            GetMerchantsMerchantIdPayoutSettingsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a payout setting
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
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
    public Task<PayoutSettings> GetMerchantsMerchantIdPayoutSettingsPayoutSettingsId(GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("payoutSettingsId", request.PayoutSettingsId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PayoutSettings>(),
            GetMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a payout setting
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError"/> when the server returns an error response.</exception>
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
    public Task<PayoutSettings> PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsId(PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/payoutSettings/{payoutSettingsId}"),
            [
                new TemplateParam("merchantId", request.MerchantId),
                new TemplateParam("payoutSettingsId", request.PayoutSettingsId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PayoutSettings>(),
            PatchMerchantsMerchantIdPayoutSettingsPayoutSettingsIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Add a payout setting
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdPayoutSettingsError"/> when the server returns an error response.</exception>
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
    public Task<PayoutSettings> PostMerchantsMerchantIdPayoutSettings(PostMerchantsMerchantIdPayoutSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/payoutSettings"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PayoutSettings>(),
            PostMerchantsMerchantIdPayoutSettingsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

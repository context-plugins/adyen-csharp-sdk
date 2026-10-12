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
using Adyen.Requests.WebhooksMerchantLevel;

namespace Adyen.Api;

public sealed class WebhooksMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal WebhooksMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Remove a webhook
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteMerchantsMerchantIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove the configuration for the webhook identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task DeleteMerchantsMerchantIdWebhooksWebhookId(DeleteMerchantsMerchantIdWebhooksWebhookIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks/{webhookId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("webhookId", request.WebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMerchantsMerchantIdWebhooksWebhookIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// List all webhooks
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListWebhooksResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdWebhooksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all webhook configurations for the merchant account.
    /// <para>
    /// &gt; This call does not return webhook configurations for the company account to which the specified merchant account belongs. You can see these in your Customer Area under <b>Developers</b> &gt; <b>Webhooks</b>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<ListWebhooksResponse> GetMerchantsMerchantIdWebhooks(GetMerchantsMerchantIdWebhooksRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListWebhooksResponse>(),
            GetMerchantsMerchantIdWebhooksError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a webhook
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetMerchantsMerchantIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the configuration for the webhook identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> GetMerchantsMerchantIdWebhooksWebhookId(GetMerchantsMerchantIdWebhooksWebhookIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks/{webhookId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("webhookId", request.WebhookId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Webhook>(),
            GetMerchantsMerchantIdWebhooksWebhookIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a webhook
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchMerchantsMerchantIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> PatchMerchantsMerchantIdWebhooksWebhookId(PatchMerchantsMerchantIdWebhooksWebhookIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks/{webhookId}"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("webhookId", request.WebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Webhook>(),
            PatchMerchantsMerchantIdWebhooksWebhookIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Set up a webhook
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdWebhooksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Subscribe to receive webhook notifications about events related to your merchant account. You can add basic authentication to make sure the data is secure.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> PostMerchantsMerchantIdWebhooks(PostMerchantsMerchantIdWebhooksRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks"),
            [new TemplateParam("merchantId", request.MerchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<Webhook>(),
            PostMerchantsMerchantIdWebhooksError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Generate an HMAC key
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateHmacKeyResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an <see href="https://en.wikipedia.org/wiki/HMAC">HMAC key</see> for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving <see href="https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures">HMAC-signed notifications</see> from Adyen. Find out more about how to <see href="https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures">verify HMAC signatures</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<GenerateHmacKeyResponse> PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmac(PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks/{webhookId}/generateHmac"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("webhookId", request.WebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateHmacKeyResponse>(),
            PostMerchantsMerchantIdWebhooksWebhookIdGenerateHmacError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Test a webhook
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TestWebhookResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMerchantsMerchantIdWebhooksWebhookIdTestError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends sample notifications to test if the webhook is set up correctly.
    /// <para>
    /// We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.
    /// </para>
    /// <para>
    /// The response describes the result of the test. The <c>status</c> field tells you if the test was successful or not. You can use the other fields to troubleshoot unsuccessful tests.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<TestWebhookResponse> PostMerchantsMerchantIdWebhooksWebhookIdTest(PostMerchantsMerchantIdWebhooksWebhookIdTestRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/merchants/{merchantId}/webhooks/{webhookId}/test"),
            [new TemplateParam("merchantId", request.MerchantId), new TemplateParam("webhookId", request.WebhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TestWebhookResponse>(),
            PostMerchantsMerchantIdWebhooksWebhookIdTestError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

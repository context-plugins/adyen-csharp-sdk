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

public sealed class WebhooksCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal WebhooksCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// delete-companies-companyId-webhooks-webhookId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCompaniesCompanyIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Remove the configuration for the webhook identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task DeleteCompaniesCompanyIdWebhooksWebhookId(string companyId,
        string webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks/{webhookId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("webhookId", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCompaniesCompanyIdWebhooksWebhookIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-webhooks
    /// </summary>
    /// <param name="companyId">Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListWebhooksResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdWebhooksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists all webhook configurations for the company account.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<ListWebhooksResponse> GetCompaniesCompanyIdWebhooks(string companyId,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListWebhooksResponse>(),
            GetCompaniesCompanyIdWebhooksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-webhooks-webhookId
    /// </summary>
    /// <param name="companyId">Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.</param>
    /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the configuration for the webhook identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> GetCompaniesCompanyIdWebhooksWebhookId(string companyId,
        string webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks/{webhookId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("webhookId", webhookId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Webhook>(),
            GetCompaniesCompanyIdWebhooksWebhookIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-companies-companyId-webhooks-webhookId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdWebhooksWebhookIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Make changes to the configuration of the webhook identified in the path. The request contains the new values you want to have in the webhook configuration. The response contains the full configuration for the webhook, which includes the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> PatchCompaniesCompanyIdWebhooksWebhookId(string companyId,
        string webhookId,
        UpdateCompanyWebhookRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks/{webhookId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("webhookId", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Webhook>(),
            PatchCompaniesCompanyIdWebhooksWebhookIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-webhooks
    /// </summary>
    /// <param name="companyId">Unique identifier of the <see href="https://docs.adyen.com/account/account-structure#company-account">company account</see>.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Webhook"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdWebhooksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Subscribe to receive webhook notifications about events related to your company account. You can add basic authentication to make sure the data is secure.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<Webhook> PostCompaniesCompanyIdWebhooks(string companyId,
        CreateCompanyWebhookRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Webhook>(),
            PostCompaniesCompanyIdWebhooksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-webhooks-webhookId-generateHmac
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateHmacKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an <see href="https://en.wikipedia.org/wiki/HMAC">HMAC key</see> for the webhook identified in the path. This key allows you to check the integrity and the origin of the notifications you receive.By creating an HMAC key, you start receiving <see href="https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures#enable-hmac-signatures">HMAC-signed notifications</see> from Adyen. Find out more about how to <see href="https://docs.adyen.com/development-resources/webhooks/verify-hmac-signatures">verify HMAC signatures</see>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<GenerateHmacKeyResponse> PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmac(string companyId,
        string webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks/{webhookId}/generateHmac"),
            [new TemplateParam("companyId", companyId), new TemplateParam("webhookId", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateHmacKeyResponse>(),
            PostCompaniesCompanyIdWebhooksWebhookIdGenerateHmacErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-webhooks-webhookId-test
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="webhookId">Unique identifier of the webhook configuration.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TestWebhookResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdWebhooksWebhookIdTestError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends sample notifications to test if the webhook is set up correctly.
    /// <para>
    /// We send sample notifications for maximum 20 of the merchant accounts that the webhook is configured for. If the webhook is configured for more than 20 merchant accounts, use the <c>merchantIds</c> array to specify a subset of the merchant accounts for which to send test notifications.
    /// </para>
    /// <para>
    /// We send four test notifications for each event code you choose. They cover success and failure scenarios for the hard-coded currencies EUR and GBP, regardless of the currencies configured in the merchant accounts. For custom notifications, we only send the specified custom notification.
    /// </para>
    /// <para>
    /// The response describes the result of the test. The <c>status</c> field tells you if the test was successful or not. You can use the other response fields to troubleshoot unsuccessful tests.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Webhooks read and write
    /// </para>
    /// </remarks>
    public Task<TestWebhookResponse> PostCompaniesCompanyIdWebhooksWebhookIdTest(string companyId,
        string webhookId,
        TestCompanyWebhookRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/webhooks/{webhookId}/test"),
            [new TemplateParam("companyId", companyId), new TemplateParam("webhookId", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TestWebhookResponse>(),
            PostCompaniesCompanyIdWebhooksWebhookIdTestErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

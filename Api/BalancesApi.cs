using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class BalancesApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal BalancesApi(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// delete-balancePlatforms-balancePlatformId-webhooks-webhookId-settings-settingId
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="webhookId">The unique identifier of the balance webhook.</param>
    /// <param name="settingId">The unique identifier of the balance webhook setting.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a balance webhook setting that contains the conditions for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<object> DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId,
        string webhookId,
        string settingId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [new TemplateParam("balancePlatformId", balancePlatformId),
                new TemplateParam("webhookId", webhookId),
                new TemplateParam("settingId", settingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<object>(),
            DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-balancePlatforms-balancePlatformId-webhooks-webhookId-settings
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="webhookId">The unique identifier of the balance webhook.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all balance webhook settings configured for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<WebhookSettings> GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(string balancePlatformId,
        string webhookId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings"),
            [new TemplateParam("balancePlatformId", balancePlatformId), new TemplateParam("webhookId", webhookId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<WebhookSettings>(),
            GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// get-balancePlatforms-balancePlatformId-webhooks-webhookId-settings-settingId
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="webhookId">The unique identifier of the balance webhook.</param>
    /// <param name="settingId">The unique identifier of the balance webhook setting.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a specific balance webhook setting configured for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<WebhookSetting> GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId,
        string webhookId,
        string settingId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [new TemplateParam("balancePlatformId", balancePlatformId),
                new TemplateParam("webhookId", webhookId),
                new TemplateParam("settingId", settingId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<WebhookSetting>(),
            GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// patch-balancePlatforms-balancePlatformId-webhooks-webhookId-settings-settingId
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="webhookId">The unique identifier of the balance webhook.</param>
    /// <param name="settingId">The unique identifier of the balance webhook setting.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the conditions the balance change needs to meet for Adyen to send a <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhook</see>.
    /// </remarks>
    public Task<WebhookSetting> PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(string balancePlatformId,
        string webhookId,
        string settingId,
        BalanceWebhookSettingInfoUpdate body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [new TemplateParam("balancePlatformId", balancePlatformId),
                new TemplateParam("webhookId", webhookId),
                new TemplateParam("settingId", settingId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<WebhookSetting>(),
            PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// post-balancePlatforms-balancePlatformId-webhooks-webhookId-settings
    /// </summary>
    /// <param name="balancePlatformId">The unique identifier of the balance platform.</param>
    /// <param name="webhookId">The unique identifier of the balance webhook.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Configures the criteria for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/1/post/balancePlatform.balanceAccount.balance.updated">balance webhooks</see>.
    /// <para>
    /// Adyen sends balance webhooks to notify you of balance changes in your balance platform. They can be triggered when the balance reaches, exceeds, or drops below a specific value in a specific currency.
    /// </para>
    /// <para>
    /// You can get notified about balance changes in your entire balance platform, in the balance accounts of a specific user, or a specific balance account. The hierarchy between the webhook settings are based on the following business logic:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Settings on a higher level apply to all lower level resources (balance platform &gt; account holder &gt; balance acocunt).</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The most granular setting overrides higher level settings (balance account &gt; account holder &gt; balance platform).</description></item>
    /// </list>
    /// </remarks>
    public Task<WebhookSetting> PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(string balancePlatformId,
        string webhookId,
        BalanceWebhookSettingInfo body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings"),
            [new TemplateParam("balancePlatformId", balancePlatformId), new TemplateParam("webhookId", webhookId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<WebhookSetting>(),
            PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

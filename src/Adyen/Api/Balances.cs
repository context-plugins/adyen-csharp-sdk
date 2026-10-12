using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.Balances;

namespace Adyen.Api;

public sealed class Balances
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal Balances(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete a balance webhook setting by id
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="JsonElement"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a balance webhook setting that contains the conditions for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<JsonElement> DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [
                new TemplateParam("balancePlatformId", request.BalancePlatformId),
                new TemplateParam("webhookId", request.WebhookId),
                new TemplateParam("settingId", request.SettingId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<JsonElement>(),
            DeleteBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all balance webhook settings
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSettings"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns all balance webhook settings configured for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<WebhookSettings> GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings"),
            [
                new TemplateParam("balancePlatformId", request.BalancePlatformId),
                new TemplateParam("webhookId", request.WebhookId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<WebhookSettings>(),
            GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a balance webhook setting by id
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a specific balance webhook setting configured for triggering <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhooks</see>.
    /// </remarks>
    public Task<WebhookSetting> GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [
                new TemplateParam("balancePlatformId", request.BalancePlatformId),
                new TemplateParam("webhookId", request.WebhookId),
                new TemplateParam("settingId", request.SettingId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<WebhookSetting>(),
            GetBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a balance webhook setting by id
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the conditions the balance change needs to meet for Adyen to send a <see href="https://docs.adyen.com/api-explorer/balance-webhooks/latest/post/balanceAccount.balance.updated">balance webhook</see>.
    /// </remarks>
    public Task<WebhookSetting> PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingId(PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings/{settingId}"),
            [
                new TemplateParam("balancePlatformId", request.BalancePlatformId),
                new TemplateParam("webhookId", request.WebhookId),
                new TemplateParam("settingId", request.SettingId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<WebhookSetting>(),
            PatchBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsSettingIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a balance webhook setting
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="WebhookSetting"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError"/> when the server returns an error response.</exception>
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
    public Task<WebhookSetting> PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettings(PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/balancePlatforms/{balancePlatformId}/webhooks/{webhookId}/settings"),
            [
                new TemplateParam("balancePlatformId", request.BalancePlatformId),
                new TemplateParam("webhookId", request.WebhookId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<WebhookSetting>(),
            PostBalancePlatformsBalancePlatformIdWebhooksWebhookIdSettingsError.Response,
            [],
            requestOptions,
            cancellationToken);
}

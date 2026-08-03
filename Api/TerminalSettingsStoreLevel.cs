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

public sealed class TerminalSettingsStoreLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalSettingsStoreLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-merchants-merchantId-stores-reference-terminalLogos
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="reference">The reference that identifies the store.</param>
    /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdStoresReferenceTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the logo that is configured for a specific payment terminal model at the store identified in the path.
    /// The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.
    /// This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> GetMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId,
        string reference,
        string model,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/stores/{reference}/terminalLogos"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("reference", reference)],
            [new Param("model", model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Logo>(),
            GetMerchantsMerchantIdStoresReferenceTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId-stores-reference-terminalSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="reference">The reference that identifies the store.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdStoresReferenceTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> GetMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId,
        string reference,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/stores/{reference}/terminalSettings"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("reference", reference)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalSettings>(),
            GetMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-stores-storeId-terminalLogos
    /// </summary>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetStoresStoreIdTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the logo that is configured for a specific payment terminal model at the store identified in the path.
    /// The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.
    /// This logo applies to all terminals of that model under the store unless a different logo is configured for an individual terminal.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> GetStoresStoreIdTerminalLogos(string storeId,
        string model,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stores/{storeId}/terminalLogos"),
            [new TemplateParam("storeId", storeId)],
            [new Param("model", model)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Logo>(),
            GetStoresStoreIdTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-stores-storeId-terminalSettings
    /// </summary>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetStoresStoreIdTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminal settings that are configured for the store identified in the path. These settings apply to all terminals under the store unless different values are configured for an individual terminal.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> GetStoresStoreIdTerminalSettings(string storeId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stores/{storeId}/terminalSettings"),
            [new TemplateParam("storeId", storeId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalSettings>(),
            GetStoresStoreIdTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-merchants-merchantId-stores-reference-terminalLogos
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="reference">The reference that identifies the store.</param>
    /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdStoresReferenceTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
    /// This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.
    /// <list type="bullet">
    ///   <item><description>To change the logo, specify the image file as a Base64-encoded string.</description></item>
    ///   <item><description>To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> PatchMerchantsMerchantIdStoresReferenceTerminalLogos(string merchantId,
        string reference,
        string model,
        Logo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/stores/{reference}/terminalLogos"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("reference", reference)],
            [new Param("model", model)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Logo>(),
            PatchMerchantsMerchantIdStoresReferenceTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-merchants-merchantId-stores-reference-terminalSettings
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="reference">The reference that identifies the store.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.
    /// <list type="bullet">
    ///   <item><description>To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.</description></item>
    ///   <item><description>To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.</description></item>
    ///   <item><description>Objects that are not included in the request are not updated.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> PatchMerchantsMerchantIdStoresReferenceTerminalSettings(string merchantId,
        string reference,
        TerminalSettings? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/stores/{reference}/terminalSettings"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("reference", reference)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalSettings>(),
            PatchMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-stores-storeId-terminalLogos
    /// </summary>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="model">The terminal model. Possible values: E355, VX675WIFIBT, VX680, VX690, VX700, VX820, M400, MX925, P400Plus, UX300, UX410, V200cPlus, V240mPlus, V400cPlus, V400m, e280, e285, e285p, S1E, S1EL, S1F2, S1L, S1U, S7T.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchStoresStoreIdTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the logo that is configured for a specific payment terminal model at the store identified in the path. You can update the logo for only one terminal model at a time.
    /// This logo applies to all terminals of the specified model under the store, unless a different logo is configured for an individual terminal.
    /// <list type="bullet">
    ///   <item><description>To change the logo, specify the image file as a Base64-encoded string.</description></item>
    ///   <item><description>To restore the logo inherited from a higher level (merchant or company account), specify an empty logo value.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> PatchStoresStoreIdTerminalLogos(string storeId,
        string model,
        Logo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stores/{storeId}/terminalLogos"),
            [new TemplateParam("storeId", storeId)],
            [new Param("model", model)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Logo>(),
            PatchStoresStoreIdTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-stores-storeId-terminalSettings
    /// </summary>
    /// <param name="storeId">The unique identifier of the store.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchStoresStoreIdTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates payment terminal settings for the store identified in the path. These settings apply to all terminals under the store, unless different values are configured for an individual terminal.
    /// <list type="bullet">
    ///   <item><description>To change a parameter value, include the full object that contains the parameter, even if you don't want to change all parameters in the object.</description></item>
    ///   <item><description>To restore a parameter value inherited from a higher level, include the full object that contains the parameter, and specify an empty value for the parameter or omit the parameter.</description></item>
    ///   <item><description>Objects that are not included in the request are not updated.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/configure-terminals-api#sensitive-terminal-settings">sensitive terminal settings</see>, your API credential must have the following role:
    /// * Management API—Terminal settings Advanced read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalSettings> PatchStoresStoreIdTerminalSettings(string storeId,
        TerminalSettings? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/stores/{storeId}/terminalSettings"),
            [new TemplateParam("storeId", storeId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalSettings>(),
            PatchStoresStoreIdTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

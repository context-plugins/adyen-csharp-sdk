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

public sealed class TerminalSettingsTerminalLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalSettingsTerminalLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-terminals-terminalId-terminalLogos
    /// </summary>
    /// <param name="terminalId">The unique identifier of the payment terminal.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTerminalsTerminalIdTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the logo that is configured for the payment terminal identified in the path.
    /// The logo is returned as a Base64-encoded string. You need to Base64-decode the string to get the actual image file.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal settings read
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> GetTerminalsTerminalIdTerminalLogos(string terminalId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/terminals/{terminalId}/terminalLogos"),
            [new TemplateParam("terminalId", terminalId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Logo>(),
            GetTerminalsTerminalIdTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-terminals-terminalId-terminalSettings
    /// </summary>
    /// <param name="terminalId">The unique identifier of the payment terminal.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetTerminalsTerminalIdTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the settings that are configured for the payment terminal identified in the path.
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
    public Task<TerminalSettings> GetTerminalsTerminalIdTerminalSettings(string terminalId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/terminals/{terminalId}/terminalSettings"),
            [new TemplateParam("terminalId", terminalId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalSettings>(),
            GetTerminalsTerminalIdTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-terminals-terminalId-terminalLogos
    /// </summary>
    /// <param name="terminalId">The unique identifier of the payment terminal.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Logo"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchTerminalsTerminalIdTerminalLogosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the logo for the payment terminal identified in the path.
    /// <list type="bullet">
    ///   <item><description>To change the logo, specify the image file as a Base64-encoded string.</description></item>
    ///   <item><description>To restore the logo inherited from a higher level (store, merchant account, or company account), specify an empty logo value.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal settings read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<Logo> PatchTerminalsTerminalIdTerminalLogos(string terminalId,
        Logo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/terminals/{terminalId}/terminalLogos"),
            [new TemplateParam("terminalId", terminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Logo>(),
            PatchTerminalsTerminalIdTerminalLogosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-terminals-terminalId-terminalSettings
    /// </summary>
    /// <param name="terminalId">The unique identifier of the payment terminal.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalSettings"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchTerminalsTerminalIdTerminalSettingsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the settings that are configured for the payment terminal identified in the path.
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
    public Task<TerminalSettings> PatchTerminalsTerminalIdTerminalSettings(string terminalId,
        TerminalSettings? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/terminals/{terminalId}/terminalSettings"),
            [new TemplateParam("terminalId", terminalId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalSettings>(),
            PatchTerminalsTerminalIdTerminalSettingsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

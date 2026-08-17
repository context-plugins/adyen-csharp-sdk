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

public sealed class TerminalActionsCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalActionsCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of terminal actions
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
    /// <param name="status">Returns terminal actions with the specified status.  Allowed values: <b>pending</b>, <b>successful</b>, <b>failed</b>, <b>cancelled</b>, <b>tryLater</b>.</param>
    /// <param name="type">Returns terminal actions of the specified type.  Allowed values: <b>InstallAndroidApp</b>, <b>UninstallAndroidApp</b>, <b>InstallAndroidCertificate</b>, <b>UninstallAndroidCertificate</b>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListExternalTerminalActionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see> that have been scheduled for the company identified in the path.The response doesn't include actions that are scheduled by Adyen.
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ListExternalTerminalActionsResponse> GetCompaniesCompanyIdTerminalActions(string companyId,
        int? pageNumber,
        int? pageSize,
        string? status,
        string? type,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/terminalActions"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize),
                new Param("status", status),
                new Param("type", type)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListExternalTerminalActionsResponse>(),
            GetCompaniesCompanyIdTerminalActionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get terminal action
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="actionId">The unique identifier of the terminal action.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ExternalTerminalAction"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalActionsActionIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal action</see> identified in the path.
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ExternalTerminalAction> GetCompaniesCompanyIdTerminalActionsActionId(string companyId,
        string actionId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/terminalActions/{actionId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("actionId", actionId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ExternalTerminalAction>(),
            GetCompaniesCompanyIdTerminalActionsActionIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

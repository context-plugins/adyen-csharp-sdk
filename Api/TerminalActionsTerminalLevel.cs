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

public sealed class TerminalActionsTerminalLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalActionsTerminalLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// post-terminals-scheduleActions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ScheduleTerminalActionsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTerminalsScheduleActionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Schedules a <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal action</see> by specifying the action and the terminals that the action must be applied to.
    /// <para>
    /// The following restrictions apply:
    /// * You can schedule only one action at a time. For example, to install a new app version and remove an old app version, you have to make two API requests.
    /// * The maximum number of terminals in a request is <b>100</b>. For example, to apply an action to 250 terminals, you have to divide the terminals over three API requests.
    /// * If there is an error with one or more terminal IDs in the request, the action is scheduled for none of the terminals. You need to fix the error and try again.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal actions read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ScheduleTerminalActionsResponse> PostTerminalsScheduleActions(ScheduleTerminalActionsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/terminals/scheduleActions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ScheduleTerminalActionsResponse>(),
            PostTerminalsScheduleActionsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

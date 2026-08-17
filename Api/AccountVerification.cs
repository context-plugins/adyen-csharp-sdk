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

public sealed class AccountVerification
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal AccountVerification(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Get account verification report
    /// </summary>
    /// <param name="code">The unique code you receive after a successful open banking flow that is included as a query parameter in the <c>redirectUrl</c> callback.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountVerificationReportResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetAccountVerificationReportsCodeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get the account verification report using a unique code from a successful open banking connection. This report provides identity verification and bank account details.
    /// </remarks>
    public Task<AccountVerificationReportResponse> GetAccountVerificationReportsCode(string code,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default21("/accountVerification/reports/{code}"),
            [new TemplateParam("code", code)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountVerificationReportResponse>(),
            GetAccountVerificationReportsCodeErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create routes for account verification
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountVerificationRoutesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAccountVerificationRoutesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a list of routes for verifying bank accounts of third-party individuals. Successful connections generate a unique code used for requesting bank reports and verifying identity.
    /// </remarks>
    public Task<AccountVerificationRoutesResponse> PostAccountVerificationRoutes(AccountVerificationRoutesRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default21("/accountVerification/routes"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountVerificationRoutesResponse>(),
            PostAccountVerificationRoutesErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

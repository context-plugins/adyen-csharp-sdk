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

public sealed class PciComplianceQuestionnairePage
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PciComplianceQuestionnairePage(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// post-getPciQuestionnaireUrl
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciUrlResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetPciQuestionnaireUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a link to a PCI compliance questionnaire that you can send to your account holder.
    ///  &gt; You should only use this endpoint if you have a <see href="https://docs.adyen.com/classic-platforms/platforms-for-partners">partner platform setup</see>.
    /// </remarks>
    public Task<GetPciUrlResponse> PostGetPciQuestionnaireUrl(GetPciUrlRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/getPciQuestionnaireUrl"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetPciUrlResponse>(),
            PostGetPciQuestionnaireUrlErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

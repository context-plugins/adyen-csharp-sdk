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
using Adyen.Requests.PciComplianceQuestionnairePage;

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
    /// Get a link to a PCI compliance questionnaire
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciUrlResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetPciQuestionnaireUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a link to a PCI compliance questionnaire that you can send to your account holder.
    ///  &gt; You should only use this endpoint if you have a <see href="https://docs.adyen.com/classic-platforms/platforms-for-partners">partner platform setup</see>.
    /// </remarks>
    public Task<GetPciUrlResponse> PostGetPciQuestionnaireUrl(PostGetPciQuestionnaireUrlRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default19("/getPciQuestionnaireUrl"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetPciUrlResponse>(),
            PostGetPciQuestionnaireUrlError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

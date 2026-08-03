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

public sealed class HostedOnboardingPage
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HostedOnboardingPage(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// post-getOnboardingUrl
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetOnboardingUrlResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetOnboardingUrlError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a link to an Adyen-hosted onboarding page (HOP) that you can send to your account holder. For more information on how to use HOP, refer to <see href="https://docs.adyen.com/classic-platforms/onboard-users/hosted-onboarding-page">Hosted onboarding</see>.
    /// </remarks>
    public Task<GetOnboardingUrlResponse> PostGetOnboardingUrl(GetOnboardingUrlRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/getOnboardingUrl"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetOnboardingUrlResponse>(),
            PostGetOnboardingUrlErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

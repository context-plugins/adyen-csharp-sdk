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

public sealed class SessionAuthentication
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal SessionAuthentication(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Create a communication session
    /// </summary>
    /// <param name="xApiKey">The API key to authenticate API requests.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CertificateLoadingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAuthCertificateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a secure communication session between the Mobile SDK and the Adyen payments platform, through mutual authentication. The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
    /// </remarks>
    public Task<CertificateLoadingResponse> PostAuthCertificate(string? xApiKey,
        CertificateLoadingRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default25("/auth/certificate"),
            [],
            [],
            [new HeaderParam("X-API-Key", xApiKey), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CertificateLoadingResponse>(),
            PostAuthCertificateErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a session token
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AuthenticationSessionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostSessions2Error"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a session token that is required to integrate <see href="https://docs.adyen.com/platforms/components-overview">components</see>.
    /// <para>
    /// The response contains encrypted session data. The front end then uses the session data to make the required server-side calls for the component.
    /// </para>
    /// <para>
    /// To create a token, you must meet specific requirements. These requirements vary depending on the type of component. For more information, see the documentation for <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding</see> and <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience</see> components.
    /// </para>
    /// </remarks>
    public Task<AuthenticationSessionResponse> PostSessions2(AuthenticationSessionRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default17("/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AuthenticationSessionResponse>(),
            PostSessions2ErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

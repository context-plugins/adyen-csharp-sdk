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
    /// post-auth-certificate
    /// </summary>
    /// <param name="xApiKey">The API key to authenticate API requests.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateSessionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAuthCertificateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a secure communication session between the Mobile SDK and the Adyen payments platform, through mutual authentication. The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
    /// </remarks>
    public Task<CreateSessionResponse> PostAuthCertificate(string? xApiKey,
        CertificateLoadingRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/auth/certificate"),
            [],
            [],
            [new HeaderParam("X-API-Key", xApiKey), new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateSessionResponse>(),
            PostAuthCertificateErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

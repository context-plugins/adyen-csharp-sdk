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
using Adyen.Requests.IDealProfiles;

namespace Adyen.Api;

public sealed class IDealProfiles
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal IDealProfiles(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Manage an iDEAL profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdealAuthLinkResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostIdealProfileAuthLinkError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Manage an already registered iDEAL profile. Generates a redirection URL to manage the iDEAL profile linked to the account holder from the request.
    /// </remarks>
    public Task<IdealAuthLinkResponse> PostIdealProfileAuthLink(PostIdealProfileAuthLinkRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default20("/ideal/profile/auth-link"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IdealAuthLinkResponse>(),
            PostIdealProfileAuthLinkError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Authenticate iDEAL profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IdealAuthenticateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostIdealProfileAuthenticateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates an redirection URL to finish the authentication flow when requested by iDEAL. Before calling this endpoint, make sure that your user has completed multi-factor authentication.
    /// </remarks>
    public Task<IdealAuthenticateResponse> PostIdealProfileAuthenticate(PostIdealProfileAuthenticateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default20("/ideal/profile/authenticate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<IdealAuthenticateResponse>(),
            PostIdealProfileAuthenticateError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Register an iDEAL profile
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ProfileRegistrationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostIdealProfileRegisterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Register a new iDEAL profile. The profile is linked to the account holder and payment instruments included in the request. The user must be redirected to the URL in the response to finish their IDEAL profile registration.
    /// </remarks>
    public Task<ProfileRegistrationResponse> PostIdealProfileRegister(PostIdealProfileRegisterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default20("/ideal/profile/register"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ProfileRegistrationResponse>(),
            PostIdealProfileRegisterError.Response,
            [],
            requestOptions,
            cancellationToken);
}

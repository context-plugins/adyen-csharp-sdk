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

public sealed class MyApiCredential
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal MyApiCredential(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Remove allowed origin
    /// </summary>
    /// <param name="originId">Unique identifier of the allowed origin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteMeAllowedOriginsOriginIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> specified in the path.
    /// The API key from the request is used to identify the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see>.
    /// <para>
    /// You can make this request with any of the Management API roles.
    /// </para>
    /// </remarks>
    public Task DeleteMeAllowedOriginsOriginId(string originId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me/allowedOrigins/{originId}"),
            [new TemplateParam("originId", originId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMeAllowedOriginsOriginIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get API credential details
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="MeApiCredential"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns your <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> details based on the API Key you used in the request.
    /// <para>
    /// You can make this request with any of the Management API roles.
    /// </para>
    /// </remarks>
    public Task<MeApiCredential> GetMe(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<MeApiCredential>(),
            GetMeErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get allowed origins
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOriginsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMeAllowedOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> of your <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> based on the API key you used in the request.
    /// <para>
    /// You can make this request with any of the Management API roles.
    /// </para>
    /// </remarks>
    public Task<AllowedOriginsResponse> GetMeAllowedOrigins(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me/allowedOrigins"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOriginsResponse>(),
            GetMeAllowedOriginsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get allowed origin details
    /// </summary>
    /// <param name="originId">Unique identifier of the allowed origin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMeAllowedOriginsOriginIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> specified in the path.
    /// The API key from the request is used to identify the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see>.
    /// <para>
    /// You can make this request with any of the Management API roles.
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> GetMeAllowedOriginsOriginId(string originId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me/allowedOrigins/{originId}"),
            [new TemplateParam("originId", originId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOrigin>(),
            GetMeAllowedOriginsOriginIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Add allowed origin
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMeAllowedOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds an allowed origin to the list of <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> of your API credential.
    /// The API key from the request is used to identify the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see>.
    /// <para>
    /// You can make this request with any of the Management API roles.
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> PostMeAllowedOrigins(CreateAllowedOriginRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me/allowedOrigins"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AllowedOrigin>(),
            PostMeAllowedOriginsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Generate a client key
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenerateClientKeyResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMeGenerateClientKeyError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a new <see href="https://docs.adyen.com/development-resources/client-side-authentication/">client key</see> used to authenticate requests from your payment environment.
    /// You can use the new client key a few minutes after generating it.
    /// The old client key stops working 24 hours after generating a new one.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<GenerateClientKeyResponse> PostMeGenerateClientKey(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/me/generateClientKey"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<GenerateClientKeyResponse>(),
            PostMeGenerateClientKeyErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

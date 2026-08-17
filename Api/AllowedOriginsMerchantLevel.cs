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

public sealed class AllowedOriginsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AllowedOriginsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete an allowed origin
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="originId">Unique identifier of the allowed origin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> identified in the path. As soon as an allowed origin is removed, we no longer accept client-side requests from that domain.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId,
        string apiCredentialId,
        string originId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("apiCredentialId", apiCredentialId),
                new TemplateParam("originId", originId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of allowed origins
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOriginsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origins</see> for the API credential identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOriginsResponse> GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId,
        string apiCredentialId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOriginsResponse>(),
            GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an allowed origin
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="originId">Unique identifier of the allowed origin.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginId(string merchantId,
        string apiCredentialId,
        string originId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins/{originId}"),
            [new TemplateParam("merchantId", merchantId),
                new TemplateParam("apiCredentialId", apiCredentialId),
                new TemplateParam("originId", originId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AllowedOrigin>(),
            GetMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsOriginIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an allowed origin
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AllowedOrigin"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Adds a new <see href="https://docs.adyen.com/development-resources/client-side-authentication#allowed-origins">allowed origin</see> to the API credential's list of allowed origins.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<AllowedOrigin> PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOrigins(string merchantId,
        string apiCredentialId,
        AllowedOrigin? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}/allowedOrigins"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AllowedOrigin>(),
            PostMerchantsMerchantIdApiCredentialsApiCredentialIdAllowedOriginsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

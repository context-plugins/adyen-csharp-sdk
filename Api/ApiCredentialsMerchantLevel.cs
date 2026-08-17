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

public sealed class ApiCredentialsMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiCredentialsMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of API credentials
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantApiCredentialsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/api-credentials">API credentials</see> for the merchant account. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ListMerchantApiCredentialsResponse> GetMerchantsMerchantIdApiCredentials(string merchantId,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantApiCredentialsResponse>(),
            GetMerchantsMerchantIdApiCredentialsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an API credential
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiCredential"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ApiCredential> GetMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId,
        string apiCredentialId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ApiCredential>(),
            GetMerchantsMerchantIdApiCredentialsApiCredentialIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an API credential
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ApiCredential"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the API credential's roles, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ApiCredential> PatchMerchantsMerchantIdApiCredentialsApiCredentialId(string merchantId,
        string apiCredentialId,
        UpdateMerchantApiCredentialRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials/{apiCredentialId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<ApiCredential>(),
            PatchMerchantsMerchantIdApiCredentialsApiCredentialIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an API credential
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateApiCredentialResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> for the company account identified in the path. In the request, you can specify the roles and allowed origins for the new API credential.
    /// <para>
    /// The response includes the:
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#api-key-authentication">API key</see>: used for API request authentication.
    /// * <see href="https://docs.adyen.com/development-resources/client-side-authentication#how-it-works">Client key</see>: public key used for client-side authentication.
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication">Username and password</see>: used for basic authentication.
    /// </para>
    /// <para>
    /// &gt; Make sure you store the API key securely in your system. You won't be able to retrieve it later.
    /// </para>
    /// <para>
    /// If your API key is lost or compromised, you need to <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey">generate a new API key</see>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CreateApiCredentialResponse> PostMerchantsMerchantIdApiCredentials(string merchantId,
        CreateMerchantApiCredentialRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/apiCredentials"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateApiCredentialResponse>(),
            PostMerchantsMerchantIdApiCredentialsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

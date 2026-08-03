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

public sealed class ApiCredentialsCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal ApiCredentialsCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-companies-companyId-apiCredentials
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyApiCredentialsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/api-credentials">API credentials</see> for the company account. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ListCompanyApiCredentialsResponse> GetCompaniesCompanyIdApiCredentials(string companyId,
        int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/apiCredentials"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyApiCredentialsResponse>(),
            GetCompaniesCompanyIdApiCredentialsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-apiCredentials-apiCredentialId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyApiCredential"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CompanyApiCredential> GetCompaniesCompanyIdApiCredentialsApiCredentialId(string companyId,
        string apiCredentialId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/apiCredentials/{apiCredentialId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyApiCredential>(),
            GetCompaniesCompanyIdApiCredentialsApiCredentialIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-companies-companyId-apiCredentials-apiCredentialId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyApiCredential"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CompanyApiCredential> PatchCompaniesCompanyIdApiCredentialsApiCredentialId(string companyId,
        string apiCredentialId,
        UpdateCompanyApiCredentialRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/apiCredentials/{apiCredentialId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("apiCredentialId", apiCredentialId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<CompanyApiCredential>(),
            PatchCompaniesCompanyIdApiCredentialsApiCredentialIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-apiCredentials
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCompanyApiCredentialResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> for the company account identified in the path. In the request, you can specify which merchant accounts the new API credential will have access to, as well as its roles and allowed origins.
    /// <para>
    /// The response includes several types of authentication details:
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#api-key-authentication">API key</see>: used for API request authentication.
    /// * <see href="https://docs.adyen.com/development-resources/client-side-authentication#how-it-works">Client key</see>: public key used for client-side authentication.
    /// * <see href="https://docs.adyen.com/development-resources/api-authentication#using-basic-authentication">Username and password</see>: used for basic authentication.
    /// </para>
    /// <para>
    /// &gt; Make sure you store the API key securely in your system. You won't be able to retrieve it later.
    /// </para>
    /// <para>
    /// If your API key is lost or compromised, you need to <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/apiCredentials/{apiCredentialId}/generateApiKey">generate a new API key</see>.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CreateCompanyApiCredentialResponse> PostCompaniesCompanyIdApiCredentials(string companyId,
        CreateCompanyApiCredentialRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/apiCredentials"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCompanyApiCredentialResponse>(),
            PostCompaniesCompanyIdApiCredentialsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

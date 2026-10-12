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
using Adyen.Requests.ApiCredentialsCompanyLevel;

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
    /// Get a list of API credentials
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyApiCredentialsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompaniesCompanyIdApiCredentialsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of <see href="https://docs.adyen.com/development-resources/api-credentials">API credentials</see> for the company account. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<ListCompanyApiCredentialsResponse> GetCompaniesCompanyIdApiCredentials(GetCompaniesCompanyIdApiCredentialsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/apiCredentials"),
            [new TemplateParam("companyId", request.CompanyId)],
            [new Param("pageNumber", request.PageNumber), new Param("pageSize", request.PageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyApiCredentialsResponse>(),
            GetCompaniesCompanyIdApiCredentialsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an API credential
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyApiCredential"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompaniesCompanyIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the <see href="https://docs.adyen.com/development-resources/api-credentials">API credential</see> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CompanyApiCredential> GetCompaniesCompanyIdApiCredentialsApiCredentialId(GetCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/apiCredentials/{apiCredentialId}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyApiCredential>(),
            GetCompaniesCompanyIdApiCredentialsApiCredentialIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an API credential.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyApiCredential"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the API credential's roles, merchant account access, or allowed origins. The request has the new values for the fields you want to change. The response contains the full updated API credential, including the new values from the request.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—API credentials read and write
    /// </para>
    /// </remarks>
    public Task<CompanyApiCredential> PatchCompaniesCompanyIdApiCredentialsApiCredentialId(PatchCompaniesCompanyIdApiCredentialsApiCredentialIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/apiCredentials/{apiCredentialId}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("apiCredentialId", request.ApiCredentialId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CompanyApiCredential>(),
            PatchCompaniesCompanyIdApiCredentialsApiCredentialIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create an API credential.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCompanyApiCredentialResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCompaniesCompanyIdApiCredentialsError"/> when the server returns an error response.</exception>
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
    public Task<CreateCompanyApiCredentialResponse> PostCompaniesCompanyIdApiCredentials(PostCompaniesCompanyIdApiCredentialsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/apiCredentials"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateCompanyApiCredentialResponse>(),
            PostCompaniesCompanyIdApiCredentialsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

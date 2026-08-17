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

public sealed class UsersCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of users
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to return.</param>
    /// <param name="pageSize">The number of items to have on a page. Maximum value is <b>100</b>. The default is <b>10</b> items on a page.</param>
    /// <param name="username">The partial or complete username to select all users that match.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListCompanyUsersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of users for the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<ListCompanyUsersResponse> GetCompaniesCompanyIdUsers(string companyId,
        int? pageNumber,
        int? pageSize,
        string? username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/users"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize), new Param("username", username)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListCompanyUsersResponse>(),
            GetCompaniesCompanyIdUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get user details
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="userId">The unique identifier of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyUser"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdUsersUserIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns user details for the <c>userId</c> and the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CompanyUser> GetCompaniesCompanyIdUsersUserId(string companyId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/users/{userId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("userId", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CompanyUser>(),
            GetCompaniesCompanyIdUsersUserIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update user details
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="userId">The unique identifier of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CompanyUser"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdUsersUserIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates user details for the <c>userId</c> and the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CompanyUser> PatchCompaniesCompanyIdUsersUserId(string companyId,
        string userId,
        UpdateCompanyUserRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/users/{userId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("userId", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<CompanyUser>(),
            PatchCompaniesCompanyIdUsersUserIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new user
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateCompanyUserResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates the user for the <c>companyId</c> identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CreateCompanyUserResponse> PostCompaniesCompanyIdUsers(string companyId,
        CreateCompanyUserRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/companies/{companyId}/users"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateCompanyUserResponse>(),
            PostCompaniesCompanyIdUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

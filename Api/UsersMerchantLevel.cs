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

public sealed class UsersMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal UsersMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of users
    /// </summary>
    /// <param name="merchantId">Unique identifier of the merchant.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page. Maximum value is <b>100</b>. The default is <b>10</b> items on a page.</param>
    /// <param name="username">The partial or complete username to select all users that match.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantUsersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of users associated with the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<ListMerchantUsersResponse> GetMerchantsMerchantIdUsers(string merchantId,
        int? pageNumber,
        int? pageSize,
        string? username,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/users"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize), new Param("username", username)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantUsersResponse>(),
            GetMerchantsMerchantIdUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get user details
    /// </summary>
    /// <param name="merchantId">Unique identifier of the merchant.</param>
    /// <param name="userId">Unique identifier of the user.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdUsersUserIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns user details for the <c>userId</c> and the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<User> GetMerchantsMerchantIdUsersUserId(string merchantId,
        string userId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/users/{userId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("userId", userId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<User>(),
            GetMerchantsMerchantIdUsersUserIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update a user
    /// </summary>
    /// <param name="merchantId">Unique identifier of the merchant.</param>
    /// <param name="userId">Unique identifier of the user.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="User"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdUsersUserIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates user details for the <c>userId</c> and the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<User> PatchMerchantsMerchantIdUsersUserId(string merchantId,
        string userId,
        UpdateMerchantUserRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/users/{userId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("userId", userId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<User>(),
            PatchMerchantsMerchantIdUsersUserIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new user
    /// </summary>
    /// <param name="merchantId">Unique identifier of the merchant.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateUserResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdUsersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a user for the <c>merchantId</c> specified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Users read and write
    /// </para>
    /// </remarks>
    public Task<CreateUserResponse> PostMerchantsMerchantIdUsers(string merchantId,
        CreateMerchantUserRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/users"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateUserResponse>(),
            PostMerchantsMerchantIdUsersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

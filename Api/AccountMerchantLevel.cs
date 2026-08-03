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

public sealed class AccountMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-merchants
    /// </summary>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListMerchantResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of merchant accounts that your API credential has access to. The list is grouped into pages as defined by the query parameters.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<ListMerchantResponse> GetMerchants(int? pageNumber,
        int? pageSize,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants"),
            [],
            [new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListMerchantResponse>(),
            GetMerchantsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-merchants-merchantId
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Merchant"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the merchant account specified in the path. Your API credential must have access to the merchant account.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Account read
    /// </para>
    /// </remarks>
    public Task<Merchant> GetMerchantsMerchantId(string merchantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Merchant>(),
            GetMerchantsMerchantIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateMerchantResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a merchant account for the company account specified in the request.
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Accounts read and write
    /// </para>
    /// </remarks>
    public Task<CreateMerchantResponse> PostMerchants(CreateMerchantRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateMerchantResponse>(),
            PostMerchantsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-merchants-merchantId-activate
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RequestActivationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdActivateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to activate the merchant account identified in the path.
    /// <para>
    /// You get the result of the activation asynchronously through a <see href="https://docs.adyen.com/api-explorer/ManagementNotification/latest/post/merchant.updated"><c>merchant.updated</c></see> webhook. Once the merchant account is activated, you can start using it to accept payments and payouts.
    /// </para>
    /// <para>
    /// Use this endpoint if your integration requires it, such as Adyen for Platforms Manage. Your Adyen contact will set up your access.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Accounts read and write
    /// </para>
    /// </remarks>
    public Task<RequestActivationResponse> PostMerchantsMerchantIdActivate(string merchantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/merchants/{merchantId}/activate"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<RequestActivationResponse>(),
            PostMerchantsMerchantIdActivateErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

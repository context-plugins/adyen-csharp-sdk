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

public sealed class TerminalOrdersCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalOrdersCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-companies-companyId-billingEntities
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="name">The name of the billing entity.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingEntitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdBillingEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the billing entities of the company identified in the path and all merchant accounts belonging to the company.
    /// A billing entity is a legal entity where we charge orders to. An order for terminal products must contain the ID of a billing entity.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<BillingEntitiesResponse> GetCompaniesCompanyIdBillingEntities(string companyId,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/billingEntities"),
            [new TemplateParam("companyId", companyId)],
            [new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingEntitiesResponse>(),
            GetCompaniesCompanyIdBillingEntitiesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-shippingLocations
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="name">The name of the shipping location.</param>
    /// <param name="offset">The number of locations to skip.</param>
    /// <param name="limit">The number of locations to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdShippingLocationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the shipping locations for the company identified in the path and all merchant accounts belonging to the company.
    /// A shipping location includes the address where orders can be delivered, and an ID which you need to specify when ordering terminal products.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ShippingLocationsResponse> GetCompaniesCompanyIdShippingLocations(string companyId,
        string? name,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/shippingLocations"),
            [new TemplateParam("companyId", companyId)],
            [new Param("name", name), new Param("offset", offset), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ShippingLocationsResponse>(),
            GetCompaniesCompanyIdShippingLocationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-terminalModels
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalModelsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalModelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of payment terminal models that the company identified in the path has access to.
    /// The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalModelsResponse> GetCompaniesCompanyIdTerminalModels(string companyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalModels"),
            [new TemplateParam("companyId", companyId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalModelsResponse>(),
            GetCompaniesCompanyIdTerminalModelsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-terminalOrders
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="customerOrderReference">Your purchase order number.</param>
    /// <param name="status">The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</param>
    /// <param name="offset">The number of orders to skip.</param>
    /// <param name="limit">The number of orders to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a lists of terminal products orders for the company identified in the path.
    /// To filter the list, use one or more of the query parameters.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrdersResponse> GetCompaniesCompanyIdTerminalOrders(string companyId,
        string? customerOrderReference,
        string? status,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalOrders"),
            [new TemplateParam("companyId", companyId)],
            [new Param("customerOrderReference", customerOrderReference),
                new Param("status", status),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrdersResponse>(),
            GetCompaniesCompanyIdTerminalOrdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-terminalOrders-orderId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalOrdersOrderIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the terminal products order identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> GetCompaniesCompanyIdTerminalOrdersOrderId(string companyId,
        string orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalOrders/{orderId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("orderId", orderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            GetCompaniesCompanyIdTerminalOrdersOrderIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-terminalProducts
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="country">The country to return products for, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format. For example, <b>US</b></param>
    /// <param name="terminalModelId">The terminal model to return products for. Use the ID returned in the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels">GET <c>/terminalModels</c></see> response. For example, <b>Verifone.M400</b></param>
    /// <param name="offset">The number of products to skip.</param>
    /// <param name="limit">The number of products to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalProductsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdTerminalProductsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a country-specific list of payment terminal packages and parts that the company identified in the path has access to.
    ///
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalProductsResponse> GetCompaniesCompanyIdTerminalProducts(string companyId,
        string country,
        string? terminalModelId,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalProducts"),
            [new TemplateParam("companyId", companyId)],
            [new Param("country", country),
                new Param("terminalModelId", terminalModelId),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalProductsResponse>(),
            GetCompaniesCompanyIdTerminalProductsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-companies-companyId-terminalOrders-orderId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdTerminalOrdersOrderIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the terminal products order identified in the path.
    /// Updating is only possible while the order has the status <b>Placed</b>.
    /// <para>
    /// The request body only needs to contain what you want to change.
    /// However, to update the products in the <c>items</c> array, you must provide the entire array. For example, if the array has three items:
    ///  To remove one item, the array must include the remaining two items. Or to add one item, the array must include all four items.
    /// </para>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> PatchCompaniesCompanyIdTerminalOrdersOrderId(string companyId,
        string orderId,
        TerminalOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalOrders/{orderId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("orderId", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalOrder>(),
            PatchCompaniesCompanyIdTerminalOrdersOrderIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-shippingLocations
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocation"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdShippingLocationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a shipping location for the company identified in the path. A shipping location defines an address where orders can be delivered.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ShippingLocation> PostCompaniesCompanyIdShippingLocations(string companyId,
        ShippingLocation? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/shippingLocations"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ShippingLocation>(),
            PostCompaniesCompanyIdShippingLocationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-terminalOrders
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdTerminalOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order for payment terminal products for the company identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// &gt;Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to <see href="https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps">submit a sales order</see> in your Customer Area.
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> PostCompaniesCompanyIdTerminalOrders(string companyId,
        TerminalOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalOrders"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalOrder>(),
            PostCompaniesCompanyIdTerminalOrdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-terminalOrders-orderId-cancel
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Cancels the terminal products order identified in the path.
    /// Cancelling is only possible while the order has the status <b>Placed</b>.
    /// To cancel an order, make a POST call without a request body. The response returns the full order details, but with the status changed to <b>Cancelled</b>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(string companyId,
        string orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/terminalOrders/{orderId}/cancel"),
            [new TemplateParam("companyId", companyId), new TemplateParam("orderId", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            PostCompaniesCompanyIdTerminalOrdersOrderIdCancelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

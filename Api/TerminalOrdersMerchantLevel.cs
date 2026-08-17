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

public sealed class TerminalOrdersMerchantLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TerminalOrdersMerchantLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of billing entities
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="name">The name of the billing entity.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BillingEntitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdBillingEntitiesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the billing entities of the merchant account identified in the path.
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
    public Task<BillingEntitiesResponse> GetMerchantsMerchantIdBillingEntities(string merchantId,
        string? name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/billingEntities"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<BillingEntitiesResponse>(),
            GetMerchantsMerchantIdBillingEntitiesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of shipping locations
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="name">The name of the shipping location.</param>
    /// <param name="offset">The number of locations to skip.</param>
    /// <param name="limit">The number of locations to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocationsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdShippingLocationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the shipping locations for the merchant account identified in the path.
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
    public Task<ShippingLocationsResponse> GetMerchantsMerchantIdShippingLocations(string merchantId,
        string? name,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/shippingLocations"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("name", name), new Param("offset", offset), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ShippingLocationsResponse>(),
            GetMerchantsMerchantIdShippingLocationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of terminal models
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalModelsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdTerminalModelsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the payment terminal models that the merchant account identified in the path has access to. The response includes the terminal model ID, which can be used as a query parameter when getting a list of terminals or a list of products for ordering.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalModelsResponse> GetMerchantsMerchantIdTerminalModels(string merchantId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalModels"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalModelsResponse>(),
            GetMerchantsMerchantIdTerminalModelsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of orders
    /// </summary>
    /// <param name="merchantId"></param>
    /// <param name="customerOrderReference">Your purchase order number.</param>
    /// <param name="status">The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.</param>
    /// <param name="offset">The number of orders to skip.</param>
    /// <param name="limit">The number of orders to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrdersResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdTerminalOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of terminal products orders for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrdersResponse> GetMerchantsMerchantIdTerminalOrders(string merchantId,
        string? customerOrderReference,
        string? status,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalOrders"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("customerOrderReference", customerOrderReference),
                new Param("status", status),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrdersResponse>(),
            GetMerchantsMerchantIdTerminalOrdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get an order
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdTerminalOrdersOrderIdError"/> when the server returns an error response.</exception>
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
    public Task<TerminalOrder> GetMerchantsMerchantIdTerminalOrdersOrderId(string merchantId,
        string orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalOrders/{orderId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("orderId", orderId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            GetMerchantsMerchantIdTerminalOrdersOrderIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of terminal products
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="country">The country to return products for, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format. For example, <b>US</b></param>
    /// <param name="terminalModelId">The terminal model to return products for. Use the ID returned in the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels">GET <c>/terminalModels</c></see> response. For example, <b>Verifone.M400</b></param>
    /// <param name="offset">The number of products to skip.</param>
    /// <param name="limit">The number of products to return.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalProductsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetMerchantsMerchantIdTerminalProductsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a country-specific list of payment terminal packages and parts that the merchant account identified in the path has access to.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Terminal ordering read
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalProductsResponse> GetMerchantsMerchantIdTerminalProducts(string merchantId,
        string country,
        string? terminalModelId,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalProducts"),
            [new TemplateParam("merchantId", merchantId)],
            [new Param("country", country),
                new Param("terminalModelId", terminalModelId),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalProductsResponse>(),
            GetMerchantsMerchantIdTerminalProductsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update an order
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchMerchantsMerchantIdTerminalOrdersOrderIdError"/> when the server returns an error response.</exception>
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
    public Task<TerminalOrder> PatchMerchantsMerchantIdTerminalOrdersOrderId(string merchantId,
        string orderId,
        TerminalOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalOrders/{orderId}"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("orderId", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalOrder>(),
            PatchMerchantsMerchantIdTerminalOrdersOrderIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a shipping location
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ShippingLocation"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdShippingLocationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a shipping location for the merchant account identified in the path. A shipping location defines an address where orders can be shipped to.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<ShippingLocation> PostMerchantsMerchantIdShippingLocations(string merchantId,
        ShippingLocation? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/shippingLocations"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ShippingLocation>(),
            PostMerchantsMerchantIdShippingLocationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create an order
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdTerminalOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an order for payment terminal products for the merchant account identified in the path.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Terminal ordering read and write
    /// &gt;Requests to the Management API test endpoint do not create actual orders for test terminals. To order test terminals, you need to <see href="https://docs.adyen.com/point-of-sale/managing-terminals/order-terminals/#sales-order-steps">submit a sales order</see> in your Customer Area.
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<TerminalOrder> PostMerchantsMerchantIdTerminalOrders(string merchantId,
        TerminalOrderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalOrders"),
            [new TemplateParam("merchantId", merchantId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TerminalOrder>(),
            PostMerchantsMerchantIdTerminalOrdersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Cancel an order
    /// </summary>
    /// <param name="merchantId">The unique identifier of the merchant account.</param>
    /// <param name="orderId">The unique identifier of the order.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TerminalOrder"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError"/> when the server returns an error response.</exception>
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
    public Task<TerminalOrder> PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(string merchantId,
        string orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default9("/merchants/{merchantId}/terminalOrders/{orderId}/cancel"),
            [new TemplateParam("merchantId", merchantId), new TemplateParam("orderId", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<TerminalOrder>(),
            PostMerchantsMerchantIdTerminalOrdersOrderIdCancelErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

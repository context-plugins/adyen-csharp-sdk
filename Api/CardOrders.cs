using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Extensions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class CardOrders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CardOrders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get a list of card orders
    /// </summary>
    /// <param name="id">The unique identifier of the card order.</param>
    /// <param name="cardManufacturingProfileId">The unique identifier of the card manufacturer profile.</param>
    /// <param name="status">The status of the card order.</param>
    /// <param name="txVariantCode">The unique code of the card manufacturer profile.  Possible values: <b>mcmaestro</b>, <b>mc</b>, <b>visa</b>, <b>mcdebit</b>.</param>
    /// <param name="createdSince">Only include card orders that have been created on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="createdUntil">Only include card orders that have been created on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="lockedSince">Only include card orders that have been locked on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="lockedUntil">Only include card orders that have been locked on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.</param>
    /// <param name="serviceCenter">The service center at which the card is issued. The value is case-sensitive.</param>
    /// <param name="offset">Specifies the position of an element in a list of card orders. The response includes a list of card orders that starts at the specified offset.  <b>Default:</b> 0, which means that the response contains all the elements in the list of card orders.</param>
    /// <param name="limit">The number of card orders returned per page. <b>Default:</b> 10.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedGetCardOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCardordersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of card orders.
    /// </remarks>
    public Task<PaginatedGetCardOrderResponse> GetCardorders(string? id,
        string? cardManufacturingProfileId,
        string? status,
        string? txVariantCode,
        DateTimeOffset? createdSince,
        DateTimeOffset? createdUntil,
        DateTimeOffset? lockedSince,
        DateTimeOffset? lockedUntil,
        string? serviceCenter,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/cardorders"),
            [],
            [new Param("id", id),
                new Param("cardManufacturingProfileId", cardManufacturingProfileId),
                new Param("status", status),
                new Param("txVariantCode", txVariantCode),
                new Param("createdSince", createdSince?.ToIso8601()),
                new Param("createdUntil", createdUntil?.ToIso8601()),
                new Param("lockedSince", lockedSince?.ToIso8601()),
                new Param("lockedUntil", lockedUntil?.ToIso8601()),
                new Param("serviceCenter", serviceCenter),
                new Param("offset", offset),
                new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedGetCardOrderResponse>(),
            GetCardordersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get card order items
    /// </summary>
    /// <param name="id">The unique identifier of the card order.</param>
    /// <param name="offset">Specifies the position of an element in a list of card orders. The response includes a list of card order items that starts at the specified offset.  <b>Default:</b> 0, which means that the response contains all the elements in the list of card order items.</param>
    /// <param name="limit">The number of card order items returned per page. <b>Default:</b> 10.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedGetCardOrderItemResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCardordersIdItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the item list of a specific card order.
    /// </remarks>
    public Task<PaginatedGetCardOrderItemResponse> GetCardordersIdItems(string id,
        int? offset,
        int? limit,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/cardorders/{id}/items"),
            [new TemplateParam("id", id)],
            [new Param("offset", offset), new Param("limit", limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedGetCardOrderItemResponse>(),
            GetCardordersIdItemsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

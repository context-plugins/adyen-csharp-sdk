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
using Adyen.Requests.CardOrders;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedGetCardOrderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCardordersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of card orders.
    /// </remarks>
    public Task<PaginatedGetCardOrderResponse> GetCardorders(GetCardordersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/cardorders"),
            [],
            [
                new Param("id", request.Id),
                new Param("cardManufacturingProfileId", request.CardManufacturingProfileId),
                new Param("status", request.Status),
                new Param("txVariantCode", request.TxVariantCode),
                new Param("createdSince", request.CreatedSince?.ToIso8601()),
                new Param("createdUntil", request.CreatedUntil?.ToIso8601()),
                new Param("lockedSince", request.LockedSince?.ToIso8601()),
                new Param("lockedUntil", request.LockedUntil?.ToIso8601()),
                new Param("serviceCenter", request.ServiceCenter),
                new Param("offset", request.Offset),
                new Param("limit", request.Limit),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedGetCardOrderResponse>(),
            GetCardordersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get card order items
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedGetCardOrderItemResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCardordersIdItemsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the item list of a specific card order.
    /// </remarks>
    public Task<PaginatedGetCardOrderItemResponse> GetCardordersIdItems(GetCardordersIdItemsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/cardorders/{id}/items"),
            [new TemplateParam("id", request.Id)],
            [new Param("offset", request.Offset), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedGetCardOrderItemResponse>(),
            GetCardordersIdItemsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

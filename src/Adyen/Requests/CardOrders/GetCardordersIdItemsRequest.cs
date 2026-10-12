namespace Adyen.Requests.CardOrders;

/// <summary>
/// The inputs of the GetCardordersIdItems operation.
/// </summary>
public sealed record GetCardordersIdItemsRequest
{
    /// <summary>
    /// The unique identifier of the card order.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// Specifies the position of an element in a list of card orders. The response includes a list of card order items that starts at the specified offset.
    /// <para>
    /// <b>Default:</b> 0, which means that the response contains all the elements in the list of card order items.
    /// </para>
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of card order items returned per page. <b>Default:</b> 10.
    /// </summary>
    public int? Limit { get; init; }
}

using System;

namespace Adyen.Requests.CardOrders;

/// <summary>
/// The inputs of the GetCardorders operation.
/// </summary>
public sealed record GetCardordersRequest
{
    /// <summary>
    /// The unique identifier of the card order.
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// The unique identifier of the card manufacturer profile.
    /// </summary>
    public string? CardManufacturingProfileId { get; init; }

    /// <summary>
    /// The status of the card order.
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// The unique code of the card manufacturer profile.
    /// <para>
    /// Possible values: <b>mcmaestro</b>, <b>mc</b>, <b>visa</b>, <b>mcdebit</b>.
    /// </para>
    /// </summary>
    public string? TxVariantCode { get; init; }

    /// <summary>
    /// Only include card orders that have been created on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public DateTimeOffset? CreatedSince { get; init; }

    /// <summary>
    /// Only include card orders that have been created on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public DateTimeOffset? CreatedUntil { get; init; }

    /// <summary>
    /// Only include card orders that have been locked on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public DateTimeOffset? LockedSince { get; init; }

    /// <summary>
    /// Only include card orders that have been locked on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public DateTimeOffset? LockedUntil { get; init; }

    /// <summary>
    /// The service center at which the card is issued. The value is case-sensitive.
    /// </summary>
    public string? ServiceCenter { get; init; }

    /// <summary>
    /// Specifies the position of an element in a list of card orders. The response includes a list of card orders that starts at the specified offset.
    /// <para>
    /// <b>Default:</b> 0, which means that the response contains all the elements in the list of card orders.
    /// </para>
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of card orders returned per page. <b>Default:</b> 10.
    /// </summary>
    public int? Limit { get; init; }
}

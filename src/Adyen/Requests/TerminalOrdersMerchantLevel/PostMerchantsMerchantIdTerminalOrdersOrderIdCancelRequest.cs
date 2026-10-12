namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdTerminalOrdersOrderIdCancel operation.
/// </summary>
public sealed record PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }
}

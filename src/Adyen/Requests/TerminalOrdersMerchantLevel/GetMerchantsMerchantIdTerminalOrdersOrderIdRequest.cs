namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdTerminalOrdersOrderId operation.
/// </summary>
public sealed record GetMerchantsMerchantIdTerminalOrdersOrderIdRequest
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

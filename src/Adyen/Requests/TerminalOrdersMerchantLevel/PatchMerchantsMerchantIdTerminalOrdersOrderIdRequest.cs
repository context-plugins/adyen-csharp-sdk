using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdTerminalOrdersOrderId operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}

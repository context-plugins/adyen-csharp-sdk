using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdTerminalOrders operation.
/// </summary>
public sealed record PostMerchantsMerchantIdTerminalOrdersRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public TerminalOrderRequest? Body { get; init; }
}

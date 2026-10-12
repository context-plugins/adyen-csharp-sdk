using Adyen.Models;

namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdShippingLocations operation.
/// </summary>
public sealed record PostMerchantsMerchantIdShippingLocationsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public ShippingLocation? Body { get; init; }
}

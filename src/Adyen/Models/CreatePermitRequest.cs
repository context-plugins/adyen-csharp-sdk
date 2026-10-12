using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreatePermitRequest
{
    /// <summary>
    /// The merchant account identifier, with which you want to process the transaction.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The permits to create for this recurring contract.
    /// </summary>
    [JsonPropertyName("permits")]
    public required IReadOnlyList<Permit> Permits { get; init; }

    /// <summary>
    /// The recurring contract the new permits will use.
    /// </summary>
    [JsonPropertyName("recurringDetailReference")]
    public required string RecurringDetailReference { get; init; }

    /// <summary>
    /// The shopper's reference to uniquely identify this shopper (e.g. user ID or account ID).
    /// </summary>
    [JsonPropertyName("shopperReference")]
    public required string ShopperReference { get; init; }
}

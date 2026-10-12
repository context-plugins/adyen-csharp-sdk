using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetTerminalsUnderAccountResponse
{
    /// <summary>
    /// Your company account.
    /// </summary>
    [JsonPropertyName("companyAccount")]
    public required string CompanyAccount { get; init; }

    /// <summary>
    /// Array that returns a list of all terminals that are in the inventory of the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventoryTerminals")]
    public IReadOnlyList<string>? InventoryTerminals { get; init; }

    /// <summary>
    /// Array that returns a list of all merchant accounts belonging to the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccounts")]
    public IReadOnlyList<MerchantAccount>? MerchantAccounts { get; init; }
}

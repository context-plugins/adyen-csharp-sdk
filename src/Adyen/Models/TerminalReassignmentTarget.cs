using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalReassignmentTarget
{
    /// <summary>
    /// The unique identifier of the company account to which the terminal is reassigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; init; }

    /// <summary>
    /// Indicates if the terminal is reassigned to the inventory of the merchant account.
    /// - If <b>true</b>, the terminal is in the inventory of the merchant account and cannot process transactions.
    /// - If <b>false</b>, the terminal is reassigned directly to the merchant account and can process transactions.
    /// </summary>
    [JsonPropertyName("inventory")]
    public required bool Inventory { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account to which the terminal is reassigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store to which the terminal is reassigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }
}

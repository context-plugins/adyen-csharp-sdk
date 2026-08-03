using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalReassignmentRequest
{
    /// <summary>
    /// The unique identifier of the company account to which the terminal is reassigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; init; }

    /// <summary>
    /// Must be specified when reassigning terminals to a merchant account:
    /// <list type="bullet">
    ///   <item><description>If set to <b>true</b>, reassigns terminals to the inventory of the merchant account and the terminals cannot process transactions.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>If set to <b>false</b>, reassigns terminals directly to the merchant account and the terminals can process transactions.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inventory")]
    public bool? Inventory { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account to which the terminal is reassigned. When reassigning terminals to a merchant account, you must specify the <c>inventory</c> field.
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

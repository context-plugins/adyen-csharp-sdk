using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Indicates the account level to which the terminal is assigned, the <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/assign-terminals-api">assignment status</see>, and where the terminals is in the process of being reassigned to.
/// </summary>
public record TerminalAssignment2
{
    /// <summary>
    /// The unique identifier of the company account to which terminal is assigned.
    /// </summary>
    [JsonPropertyName("companyId")]
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account to which terminal is assigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// Indicates where the terminal is in the process of being reassigned to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reassignmentTarget")]
    public TerminalReassignmentTarget2? ReassignmentTarget { get; init; }

    /// <summary>
    /// The status of the reassignment. Possible values:
    ///  * <c>reassignmentInProgress</c>: the terminal was boarded and is now scheduled to remove the configuration. Wait for the terminal to synchronize with the Adyen platform.
    ///  * <c>deployed</c>: the terminal is deployed and reassigned.
    ///  * <c>inventory</c>: the terminal is in inventory and cannot process transactions.
    ///  * <c>boarded</c>: the terminal is boarded to a store, or a merchant account representing a store, and can process transactions.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status21 Status { get; init; }

    /// <summary>
    /// The unique identifier of the store to which terminal is assigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }
}

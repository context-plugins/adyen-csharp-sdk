using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TerminalAssignment
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reassignmentTarget")]
    public TerminalReassignmentTarget? ReassignmentTarget { get; init; }

    [JsonPropertyName("status")]
    public required Status24 Status { get; init; }

    /// <summary>
    /// The unique identifier of the store to which terminal is assigned.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }
}

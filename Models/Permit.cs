using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Permit
{
    /// <summary>
    /// Partner ID (when using the permit-per-partner token sharing model).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; init; }

    /// <summary>
    /// The profile to apply to this permit (when using the shared permits model).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileReference")]
    public string? ProfileReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restriction")]
    public PermitRestriction? Restriction { get; init; }

    /// <summary>
    /// The key to link permit requests to permit results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultKey")]
    public string? ResultKey { get; init; }

    /// <summary>
    /// The expiry date for this permit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validTillDate")]
    public DateTimeOffset? ValidTillDate { get; init; }
}

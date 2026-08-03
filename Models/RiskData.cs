using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RiskData
{
    /// <summary>
    /// Contains client-side data, like the device fingerprint, cookies, and specific browser settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("clientData")]
    [MaxLength(5000)]
    public string? ClientData { get; init; }

    /// <summary>
    /// Any custom fields used as part of the input to configured risk rules.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customFields")]
    public IReadOnlyDictionary<string, string>? CustomFields { get; init; }

    /// <summary>
    /// An integer value that is added to the normal fraud score. The value can be either positive or negative.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudOffset")]
    public int? FraudOffset { get; init; }

    /// <summary>
    /// The risk profile to assign to this payment. When left empty, the merchant-level account's default risk profile will be applied.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profileReference")]
    public string? ProfileReference { get; init; }
}

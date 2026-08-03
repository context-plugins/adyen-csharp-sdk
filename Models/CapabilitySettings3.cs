using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// A JSON object containing the settings that are allowed for the account holder.
/// </summary>
public record CapabilitySettings3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountPerIndustry")]
    public IReadOnlyDictionary<string, Amount3>? AmountPerIndustry { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizedCardUsers")]
    public bool? AuthorizedCardUsers { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public IReadOnlyList<FundingSource>? FundingSource { get; init; }

    /// <summary>
    /// The period when the rule conditions apply.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interval")]
    public Interval? Interval { get; init; }

    /// <summary>
    /// The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public Amount3? MaxAmount { get; init; }
}

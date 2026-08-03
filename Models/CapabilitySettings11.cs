using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The settings that are allowed for the legal entity.
/// </summary>
public record CapabilitySettings11
{
    /// <summary>
    /// The maximum amount a card holder can spend per industry.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amountPerIndustry")]
    public IReadOnlyDictionary<string, PatchableAmountDto>? AmountPerIndustry { get; init; }

    /// <summary>
    /// The number of card holders who can use the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorizedCardUsers")]
    public bool? AuthorizedCardUsers { get; init; }

    /// <summary>
    /// The funding source of the card, for example <b>debit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public IReadOnlyList<FundingSource>? FundingSource { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interval")]
    public Interval? Interval { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public MaxAmount? MaxAmount { get; init; }
}

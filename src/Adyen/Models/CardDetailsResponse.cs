using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardDetailsResponse
{
    /// <summary>
    /// The list of brands identified for the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brands")]
    public IReadOnlyList<CardBrandDetails>? Brands { get; init; }

    /// <summary>
    /// The funding source of the card, for example <b>DEBIT</b>, <b>CREDIT</b>, or <b>PREPAID</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundingSource")]
    public string? FundingSource { get; init; }

    /// <summary>
    /// Indicates if this is a commercial card or a consumer card. If <b>true</b>, it is a commercial card. If <b>false</b>, it is a consumer card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isCardCommercial")]
    public bool? IsCardCommercial { get; init; }

    /// <summary>
    /// The two-letter country code  of the country where the card was issued.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issuingCountryCode")]
    public string? IssuingCountryCode { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TaxInformation
{
    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("country")]
    [StringLength(2, MinimumLength = 2)]
    public string? Country { get; init; }

    /// <summary>
    /// The tax ID number (TIN) of the organization or individual.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// Set this to <b>true</b> if the legal entity or legal arrangement does not have a tax ID number (TIN). Only applicable in Australia.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberAbsent")]
    public bool? NumberAbsent { get; init; }

    /// <summary>
    /// The TIN type depending on the country where it was issued. Only provide if the country has multiple tax IDs: Singapore, Sweden, the UK, or the US. For example, provide <b>SSN</b>, <b>EIN</b>, or <b>ITIN</b> for the US.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

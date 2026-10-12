using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for payment features.
/// </summary>
public record Payment11
{
    /// <summary>
    /// The default currency for contactless payments on the payment terminal, in three-letter <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</see> currency code format.
    /// <para>
    /// Contact Adyen before you update this setting for the first time. To enable you to change the contactless currency, we first need to check if you meet the compliance requirements.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contactlessCurrency")]
    [StringLength(3, MinimumLength = 3)]
    public string? ContactlessCurrency { get; init; }

    /// <summary>
    /// Hides the minor units for the listed <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO currency codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hideMinorUnitsInCurrencies")]
    public IReadOnlyList<string>? HideMinorUnitsInCurrencies { get; init; }
}

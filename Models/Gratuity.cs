using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Gratuity
{
    /// <summary>
    /// Indicates whether one of the predefined tipping options is to let the shopper enter a custom tip. If <b>true</b>, only three of the other options defined in <c>predefinedTipEntries</c> are shown.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowCustomAmount")]
    public bool? AllowCustomAmount { get; init; }

    /// <summary>
    /// The currency that the tipping settings apply to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// Tipping options the shopper can choose from if <c>usePredefinedTipEntries</c> is <b>true</b>. The maximum number of predefined options is four, or three plus the option to enter a custom tip.
    /// The options can be a mix of:
    /// <list type="bullet">
    ///   <item><description>A percentage of the transaction amount. Example: <b>5%</b></description></item>
    ///   <item><description>A tip amount in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>. Example: <b>500</b> for a EUR 5 tip.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("predefinedTipEntries")]
    public IReadOnlyList<string>? PredefinedTipEntries { get; init; }

    /// <summary>
    /// Indicates whether the terminal shows a prompt to enter a tip (<b>false</b>), or predefined tipping options to choose from (<b>true</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usePredefinedTipEntries")]
    public bool? UsePredefinedTipEntries { get; init; }
}

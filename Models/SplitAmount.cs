using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The amount of the split item.
/// <list type="bullet">
///   <item><description>Required for all split types in the <see href="https://docs.adyen.com/classic-platforms">Classic Platforms integration</see>.</description></item>
///   <item><description>Required if <c>type</c> is <b>BalanceAccount</b>, <b>Commission</b>, <b>Default</b>, or <b>VAT</b> in your <see href="https://docs.adyen.com/adyen-for-platforms-model">Balance Platform</see> integration.</description></item>
/// </list>
/// </summary>
public record SplitAmount
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>. By default, this is the original payment currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    [StringLength(3, MinimumLength = 3)]
    public string? Currency { get; init; }

    /// <summary>
    /// The value of the split amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}

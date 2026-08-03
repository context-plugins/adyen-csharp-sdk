using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Amount31
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

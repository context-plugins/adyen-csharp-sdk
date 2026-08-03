using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BalanceMutation
{
    /// <summary>
    /// The amount in the payment's currency that is debited or credited on the balance accounting register.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("balance")]
    public long? Balance { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// The amount in the payment's currency that is debited or credited on the received accounting register.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("received")]
    public long? Received { get; init; }

    /// <summary>
    /// The amount in the payment's currency that is debited or credited on the reserved accounting register.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reserved")]
    public long? Reserved { get; init; }
}

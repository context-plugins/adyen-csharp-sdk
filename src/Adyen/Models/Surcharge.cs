using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Surcharge
{
    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/surcharge/">surcharge</see> amount to apply to the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>. When you apply surcharge, include the surcharge in the <c>amount.value</c> field.
    /// <para>
    /// Review our <see href="https://docs.adyen.com/development-resources/surcharge-compliance/">Surcharge compliance guide</see> to learn about how to comply with regulatory requirements when applying surcharge.
    /// </para>
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }
}

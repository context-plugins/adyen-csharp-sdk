using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Defines the logic for booking the markup paid by the customer for Dynamic Currency Conversion (DCC).
/// <para>
/// &gt; This field is in pilot phase, and not yet available for all platforms.
/// </para>
/// </summary>
public record SplitDcc2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderPercentage")]
    public long? AccountHolderPercentage { get; init; }
}

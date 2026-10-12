using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OfflineProcessing
{
    /// <summary>
    /// The maximum offline transaction amount for chip cards, in the processing currency and specified in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("chipFloorLimit")]
    public int? ChipFloorLimit { get; init; }
}

using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SplitDcc
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountHolderPercentage")]
    public long? AccountHolderPercentage { get; init; }
}

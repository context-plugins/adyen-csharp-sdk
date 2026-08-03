using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RecurringDetailWrapper
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RecurringDetail")]
    public RecurringDetail? RecurringDetail { get; init; }
}

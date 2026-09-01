using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record RecurringDetailWrapper
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("RecurringDetail")]
    public RecurringDetail? RecurringDetail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

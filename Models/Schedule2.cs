using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Schedule2
{
    [JsonPropertyName("type")]
    public required ScheduleType1 Type { get; init; }
}

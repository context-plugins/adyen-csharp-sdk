using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the details about the schedule that determines when the top up is executed.
/// </summary>
public record Schedule21
{
    [JsonPropertyName("type")]
    public required ScheduleType1 Type { get; init; }
}

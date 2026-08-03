using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Enhanced scheme data that may be required for processing the payment. For example, airline information.
/// </summary>
public record EnhancedSchemeData1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline")]
    public Airline? Airline { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental")]
    public CarRental? CarRental { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthcare")]
    public Healthcare? Healthcare { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("levelTwoThree")]
    public LevelTwoThree? LevelTwoThree { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging")]
    public Lodging? Lodging { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temporaryServices")]
    public TemporaryServices? TemporaryServices { get; init; }
}

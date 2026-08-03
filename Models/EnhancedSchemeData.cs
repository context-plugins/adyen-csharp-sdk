using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EnhancedSchemeData
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

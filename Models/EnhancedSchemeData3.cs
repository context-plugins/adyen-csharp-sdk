using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/">Enhanced scheme data</see> that may be required for processing the payment and/or interchange savings can apply.
/// </summary>
public record EnhancedSchemeData3
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

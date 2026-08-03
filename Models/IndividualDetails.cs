using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IndividualDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData? PersonalData { get; init; }
}

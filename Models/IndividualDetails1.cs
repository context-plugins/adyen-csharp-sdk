using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Required when creating an entity with <c>legalEntityType</c> <b>Individual</b>.
/// </summary>
public record IndividualDetails1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData? PersonalData { get; init; }
}

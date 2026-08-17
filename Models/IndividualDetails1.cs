using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Required when creating an entity with <c>legalEntityType</c> <b>Individual</b>.
/// </summary>
public record IndividualDetails1
{
    /// <summary>
    /// The name of the individual.
    /// &gt;Make sure your account holder registers using the name shown on their Photo ID.
    ///  Maximum length: 80 characters
    ///  Cannot contain numbers. /n Cannot be empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName2? Name { get; init; }

    /// <summary>
    /// Personal information of the individual.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData2? PersonalData { get; init; }
}

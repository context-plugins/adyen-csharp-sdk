using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details about the individual account holder.
/// Required when creating an account holder with <c>legalEntity</c> <b>Individual</b>.
/// </summary>
public record IndividualDetails3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public ViasName? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("personalData")]
    public ViasPersonalData? PersonalData { get; init; }
}

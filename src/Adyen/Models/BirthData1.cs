using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The individual's birth information.
/// </summary>
public record BirthData1
{
    /// <summary>
    /// The individual's date of birth, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; init; }
}

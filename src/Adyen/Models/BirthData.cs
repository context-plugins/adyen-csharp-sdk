using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BirthData
{
    /// <summary>
    /// The individual's date of birth, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfBirth")]
    public string? DateOfBirth { get; init; }
}

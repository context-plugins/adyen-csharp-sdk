using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Name1
{
    /// <summary>
    /// The individual's first name. Must not be blank.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The infix in the individual's name, if any.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("infix")]
    public string? Infix { get; init; }

    /// <summary>
    /// The individual's last name. Must not be blank.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; init; }
}

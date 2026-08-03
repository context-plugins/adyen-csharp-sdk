using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The token requestor is an entity who requested tokenization of the card for secure payments.
/// </summary>
public record NetworkTokenRequestor2
{
    /// <summary>
    /// The id of the network token requestor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The name of the network token requestor.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}

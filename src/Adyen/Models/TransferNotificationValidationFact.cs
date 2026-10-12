using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferNotificationValidationFact
{
    /// <summary>
    /// The evaluation result of the validation fact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public string? Result { get; init; }

    /// <summary>
    /// The type of the validation fact.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

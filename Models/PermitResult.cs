using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PermitResult
{
    /// <summary>
    /// The key to link permit requests to permit results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultKey")]
    public string? ResultKey { get; init; }

    /// <summary>
    /// The permit token which is used to make payments by the partner company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("token")]
    public string? Token { get; init; }
}

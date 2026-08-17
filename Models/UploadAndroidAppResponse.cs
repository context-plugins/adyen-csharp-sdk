using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UploadAndroidAppResponse
{
    /// <summary>
    /// The unique identifier of the uploaded Android app.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}

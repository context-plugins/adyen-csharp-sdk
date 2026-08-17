using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UploadAndroidCertificateResponse
{
    /// <summary>
    /// The unique identifier of the uploaded Android certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }
}

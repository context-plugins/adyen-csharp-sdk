using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record InstallAndroidCertificateDetails
{
    /// <summary>
    /// The unique identifier of the certificate to be installed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; init; }

    /// <summary>
    /// Type of terminal action: Install an Android certificate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type42? Type { get; init; } = Type42.InstallAndroidCertificate;
}

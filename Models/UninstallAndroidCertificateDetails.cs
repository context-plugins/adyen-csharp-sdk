using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UninstallAndroidCertificateDetails
{
    /// <summary>
    /// The unique identifier of the certificate to be uninstalled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("certificateId")]
    public string? CertificateId { get; init; }

    /// <summary>
    /// Type of terminal action: Uninstall an Android certificate.
    /// </summary>
    [JsonPropertyName("type")]
    public Type81? Type { get; init; } = Type81.UninstallAndroidCertificate;
}

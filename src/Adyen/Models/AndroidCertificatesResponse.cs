using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AndroidCertificatesResponse
{
    /// <summary>
    /// Uploaded Android certificates for Android payment terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<AndroidCertificate>? Data { get; init; }
}

using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UploadDocumentRequest
{
    /// <summary>
    /// The content of the document, in Base64-encoded string format.
    /// <para>
    /// To learn about document requirements, refer to <see href="https://docs.adyen.com/classic-platforms/verification-checks">Verification checks</see>.
    /// </para>
    /// </summary>
    [JsonPropertyName("documentContent")]
    public required string DocumentContent { get; init; }

    [JsonPropertyName("documentDetail")]
    public required DocumentDetail DocumentDetail { get; init; }
}

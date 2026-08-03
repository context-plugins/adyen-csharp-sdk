using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteDefenseDocumentRequest
{
    /// <summary>
    /// The document type code of the defense document.
    /// </summary>
    [JsonPropertyName("defenseDocumentType")]
    public required string DefenseDocumentType { get; init; }

    /// <summary>
    /// The PSP reference assigned to the dispute.
    /// </summary>
    [JsonPropertyName("disputePspReference")]
    public required string DisputePspReference { get; init; }

    /// <summary>
    /// The merchant account identifier, for which you want to process the dispute transaction.
    /// </summary>
    [JsonPropertyName("merchantAccountCode")]
    public required string MerchantAccountCode { get; init; }
}

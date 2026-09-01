using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record SupplyDefenseDocumentRequest
{
    /// <summary>
    /// An array containing a list of the defense documents.
    /// </summary>
    [JsonPropertyName("defenseDocuments")]
    public required IReadOnlyList<DefenseDocument> DefenseDocuments { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

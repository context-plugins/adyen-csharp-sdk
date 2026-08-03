using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PciSigningRequest
{
    /// <summary>
    /// The array of Adyen-generated unique identifiers for the questionnaires.
    /// </summary>
    [JsonPropertyName("pciTemplateReferences")]
    public required IReadOnlyList<string> PciTemplateReferences { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id">legal entity ID</see> of the individual who signs the PCI questionnaire.
    /// </summary>
    [JsonPropertyName("signedBy")]
    public required string SignedBy { get; init; }
}

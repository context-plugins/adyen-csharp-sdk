using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record PciSigningResponse
{
    /// <summary>
    /// The unique identifiers of the signed PCI documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pciQuestionnaireIds")]
    public IReadOnlyList<string>? PciQuestionnaireIds { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id">legal entity ID</see> of the individual who signed the PCI questionnaire.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("signedBy")]
    public string? SignedBy { get; init; }
}

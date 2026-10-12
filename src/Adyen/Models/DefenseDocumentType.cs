using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record DefenseDocumentType
{
    /// <summary>
    /// When <b>true</b>, you've successfully uploaded this type of defense document. When <b>false</b>, you haven't uploaded this defense document type.
    /// </summary>
    [JsonPropertyName("available")]
    public required bool Available { get; init; }

    /// <summary>
    /// The document type code of the defense document.
    /// </summary>
    [JsonPropertyName("defenseDocumentTypeCode")]
    public required string DefenseDocumentTypeCode { get; init; }

    /// <summary>
    /// Indicates to what extent the defense document is required in the defense process.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>Required</b>: You must supply the document.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>OneOrMore</b>: You must supply at least one of the documents with this label.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>Optional</b>: You can choose to supply the document.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>AlternativeRequired</b>: You must supply a generic defense document. To enable this functionality, contact our Support Team. When enabled, you can supply a generic defense document for all schemes.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("requirementLevel")]
    public required string RequirementLevel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

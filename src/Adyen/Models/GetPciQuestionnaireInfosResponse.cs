using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetPciQuestionnaireInfosResponse
{
    /// <summary>
    /// Information about the signed PCI questionnaires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<PciDocumentInfo>? Data { get; init; }
}

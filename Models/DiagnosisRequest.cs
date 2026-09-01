using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// It conveys Information related to the target POI for which the diagnosis is requested.
/// Content of the Diagnosis Request message.
/// </summary>
public record DiagnosisRequest
{
    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// MessageHeader.POIID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public string? Poiid { get; init; }

    /// <summary>
    /// Indicates if Host Diagnosis are required.
    /// </summary>
    [JsonPropertyName("HostDiagnosisFlag")]
    public bool? HostDiagnosisFlag { get; init; } = false;

    /// <summary>
    /// Identification of the Acquirer.
    /// Present if requesting the diagnosis of these hosts only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AcquirerID")]
    public IReadOnlyList<int>? AcquirerId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

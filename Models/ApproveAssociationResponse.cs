using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record ApproveAssociationResponse
{
    /// <summary>
    /// The list of associations.
    /// </summary>
    [JsonPropertyName("scaAssociations")]
    [MinLength(1)]
    public required IReadOnlyList<Association> ScaAssociations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

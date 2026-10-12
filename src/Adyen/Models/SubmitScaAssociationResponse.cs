using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record SubmitScaAssociationResponse
{
    /// <summary>
    /// List of associations created to the entities and their statuses.
    /// </summary>
    [JsonPropertyName("scaAssociations")]
    [MinLength(1)]
    public required IReadOnlyList<Association> ScaAssociations { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

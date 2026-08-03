using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubmitScaAssociationResponse
{
    /// <summary>
    /// List of associations created to the entities and their statuses.
    /// </summary>
    [JsonPropertyName("scaAssociations")]
    [MinLength(1)]
    public required IReadOnlyList<Association> ScaAssociations { get; init; }
}

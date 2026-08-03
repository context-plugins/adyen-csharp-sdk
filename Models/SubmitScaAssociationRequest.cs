using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubmitScaAssociationRequest
{
    /// <summary>
    /// The list of entities to be associated.
    /// </summary>
    [JsonPropertyName("entities")]
    [MinLength(0)]
    [MaxLength(5)]
    public required IReadOnlyList<ScaEntity> Entities { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ScaEntity
{
    /// <summary>
    /// The unique identifier of the entity.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(100, MinimumLength = 0)]
    public required string Id { get; init; }

    [JsonPropertyName("type")]
    public required ScaEntityType4 Type { get; init; }
}

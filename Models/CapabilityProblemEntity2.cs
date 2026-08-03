using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains the type of the entity and the corresponding ID.
/// </summary>
public record CapabilityProblemEntity2
{
    /// <summary>
    /// List of document IDs to which the verification errors related to the capabilities correspond to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documents")]
    public IReadOnlyList<string>? Documents { get; init; }

    /// <summary>
    /// The ID of the entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("owner")]
    public CapabilityProblemEntityRecursive? Owner { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type3? Type { get; init; }
}

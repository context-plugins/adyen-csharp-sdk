using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains details about the owner of the entity that has an error.
/// </summary>
public record CapabilityProblemEntityRecursive2
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

    /// <summary>
    /// Type of entity.
    /// <para>
    /// Possible values: <b>LegalEntity</b>, <b>BankAccount</b>, <b>Document</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type33? Type { get; init; }
}

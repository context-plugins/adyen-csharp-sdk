using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record InputDetail
{
    /// <summary>
    /// Configuration parameters for the required input.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("configuration")]
    public IReadOnlyDictionary<string, string>? Configuration { get; init; }

    /// <summary>
    /// Input details can also be provided recursively.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<SubInputDetail>? Details { get; init; }

    /// <summary>
    /// Input details can also be provided recursively (deprecated).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("inputDetails")]
    public IReadOnlyList<SubInputDetail>? InputDetails { get; init; }

    /// <summary>
    /// In case of a select, the URL from which to query the items.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemSearchUrl")]
    public string? ItemSearchUrl { get; init; }

    /// <summary>
    /// In case of a select, the items to choose from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("items")]
    public IReadOnlyList<Item>? Items { get; init; }

    /// <summary>
    /// The value to provide in the result.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("key")]
    public string? Key { get; init; }

    /// <summary>
    /// True if this input value is optional.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("optional")]
    public bool? Optional { get; init; }

    /// <summary>
    /// The type of the required input.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The value can be pre-filled, if available.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public string? Value { get; init; }
}

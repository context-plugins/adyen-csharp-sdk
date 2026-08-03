using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TerminalProduct
{
    /// <summary>
    /// Information about items included and integration options.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A list of parts included in the terminal package.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("itemsIncluded")]
    public IReadOnlyList<string>? ItemsIncluded { get; init; }

    /// <summary>
    /// The descriptive name of the product.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public TerminalProductPrice? Price { get; init; }
}

using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record AvsAddress
{
    /// <summary>
    /// The street and house number of the address.
    /// <para>
    /// Example: 1 Infinite Loop, Cupertino.
    /// </para>
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public required string StreetAddress { get; init; }

    /// <summary>
    /// The zip or post code of the address.
    /// <para>
    /// Example: CA 95014
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("zip")]
    public string? Zip { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

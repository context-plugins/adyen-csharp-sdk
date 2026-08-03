using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains information about the resource that owns the document.
/// </summary>
public record OwnerEntity2
{
    /// <summary>
    /// Unique identifier of the resource that owns the document. For <c>type</c> <b>legalEntity</b>, this value is the unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see>. For <c>type</c> <b>bankAccount</b>, this value is the unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see>.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Type of resource that owns the document.
    /// <para>
    /// Possible values: <b>legalEntity</b>, <b>bankAccount</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}

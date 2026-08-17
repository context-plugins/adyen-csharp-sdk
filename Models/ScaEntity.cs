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

    /// <summary>
    /// The type of the entity that you are associating with the SCA device.
    /// <para>
    /// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required ScaEntityType4 Type { get; init; }
}

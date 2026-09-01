using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record OutputBarcode
{
    /// <summary>
    /// Value with a Barcode coding. The barcode value to display or print.
    /// </summary>
    [JsonPropertyName("BarcodeValue")]
    [RegularExpression("^.+$")]
    public required string BarcodeValue { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

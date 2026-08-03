using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record OutputBarcode
{
    /// <summary>
    /// Value with a Barcode coding. The barcode value to display or print.
    /// </summary>
    [JsonPropertyName("BarcodeValue")]
    [RegularExpression("^.+$")]
    public required string BarcodeValue { get; init; }
}

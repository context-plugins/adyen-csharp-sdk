using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Barcode content to display or print.
/// Mandatory if <c>OutputFormat</c> is Barcode, not allowed otherwise.
/// </summary>
public record OutputBarcode1
{
    /// <summary>
    /// Value with a Barcode coding. The barcode value to display or print.
    /// </summary>
    [JsonPropertyName("BarcodeValue")]
    [RegularExpression("^.+$")]
    public required string BarcodeValue { get; init; }
}

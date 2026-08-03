using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SaleSoftware2
{
    /// <summary>
    /// Identification of the Manufacturer.
    /// </summary>
    [JsonPropertyName("ManufacturerID")]
    [RegularExpression("^.+$")]
    public required string ManufacturerId { get; init; }

    /// <summary>
    /// Name of the software product.
    /// </summary>
    [JsonPropertyName("ApplicationName")]
    [RegularExpression("^.+$")]
    public required string ApplicationName { get; init; }

    /// <summary>
    /// Version of the software product.
    /// </summary>
    [JsonPropertyName("SoftwareVersion")]
    [RegularExpression("^.+$")]
    public required string SoftwareVersion { get; init; }

    /// <summary>
    /// Certification code of the software which manages the Sale to POI protocol.
    /// </summary>
    [JsonPropertyName("CertificationCode")]
    [RegularExpression("^.+$")]
    public required string CertificationCode { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// Information related to the software of the Sale System which manages the NEXO Sale to POI protocol.
/// </summary>
public record SaleSoftware
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Information related to the software of the POI System which manages the Sale to POI protocol. In a session allows identifying the product features of a POI System.
/// </summary>
public record PoiSoftware
{
    /// <summary>
    /// Identification of the Manufacturer. Sent in the Login Request (Response) to identify the Sale System (POI System) manufacturer during the session.
    /// </summary>
    [JsonPropertyName("ManufacturerID")]
    [RegularExpression("^.+$")]
    public required string ManufacturerId { get; init; }

    /// <summary>
    /// Name of the software product. Sent in the Login Request (Response) to identify the Sale System (POI System) product name during the session.
    /// </summary>
    [JsonPropertyName("ApplicationName")]
    [RegularExpression("^.+$")]
    public required string ApplicationName { get; init; }

    /// <summary>
    /// Version of the software product. Sent in the Login Request (Response) to identify the version of the Sale System (POI System) product software during the session.
    /// </summary>
    [JsonPropertyName("SoftwareVersion")]
    [RegularExpression("^.+$")]
    public required string SoftwareVersion { get; init; }

    /// <summary>
    /// Certification code of the software which manages the Sale to POI protocol. Sent in the Login Request (Response) to get the certification code of the Sale System (POI System) product software. This code can be a software checksum or any number associated with the software.
    /// </summary>
    [JsonPropertyName("CertificationCode")]
    [RegularExpression("^.+$")]
    public required string CertificationCode { get; init; }
}

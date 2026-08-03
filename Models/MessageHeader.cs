using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Message header of the Sale to POI protocol message.
/// It conveys Information related to the Sale to POI protocol management.
/// </summary>
public record MessageHeader
{
    /// <summary>
    /// If MessageCategory is Login or Diagnosis.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtocolVersion")]
    [RegularExpression("^.+$")]
    public string? ProtocolVersion { get; init; }

    [JsonPropertyName("MessageClass")]
    public required MessageClass1 MessageClass { get; init; }

    [JsonPropertyName("MessageCategory")]
    public required MessageCategory1 MessageCategory { get; init; }

    [JsonPropertyName("MessageType")]
    public required MessageType1 MessageType { get; init; }

    /// <summary>
    /// Identification of a message pair, which processes a transaction.
    /// Required if Service or Event MessageClass message or if Device MessageClass and request from POI or response from Sale.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServiceID")]
    [RegularExpression("^.{1,10}$")]
    public string? ServiceId { get; init; }

    /// <summary>
    /// Identification of a device message pair.
    /// If Device MessageClass.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DeviceID")]
    [RegularExpression("^.{1,10}$")]
    public string? DeviceId { get; init; }

    /// <summary>
    /// Identification of a Sale System or a Sale Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonPropertyName("SaleID")]
    [RegularExpression("^.+$")]
    public required string SaleId { get; init; }

    /// <summary>
    /// Identification of a POI System or a POI Terminal for the Sale to POI protocol.
    /// </summary>
    [JsonPropertyName("POIID")]
    [RegularExpression("^.+$")]
    public required string Poiid { get; init; }
}

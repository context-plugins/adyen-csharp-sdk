using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings to skip signature, sign on display, or sign on receipt.
/// </summary>
public record Signature1
{
    /// <summary>
    /// If <c>skipSignature</c> is false, indicates whether the shopper should provide a signature on the display (<b>true</b>) or on the merchant receipt (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("askSignatureOnScreen")]
    public bool? AskSignatureOnScreen { get; init; }

    /// <summary>
    /// Name that identifies the terminal.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; init; }

    /// <summary>
    /// Slogan shown on the start screen of the device.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deviceSlogan")]
    [MaxLength(50)]
    public string? DeviceSlogan { get; init; }

    /// <summary>
    /// Skip asking for a signature. This is possible because all global card schemes (American Express, Diners, Discover, JCB, MasterCard, VISA, and UnionPay) regard a signature as optional.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("skipSignature")]
    public bool? SkipSignature { get; init; }
}

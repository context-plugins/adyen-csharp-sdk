using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The details of the network token.
/// </summary>
public record NetworkToken2
{
    /// <summary>
    /// The card brand variant of the payment instrument associated with the network token. For example, <b>mc_prepaid_mrw</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandVariant")]
    public string? BrandVariant { get; init; }

    /// <summary>
    /// Date and time when the network token was created, in <see href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO 8601</see> extended format. For example, <b>2025-03-19T10:15:30+01:00</b>..
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// Contains information about the device used to provision the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("device")]
    public DeviceInfo1? Device { get; init; }

    /// <summary>
    /// The unique identifier of the network token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument to which this network token belongs to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentInstrumentId")]
    public string? PaymentInstrumentId { get; init; }

    /// <summary>
    /// The status of the network token. Possible values: <b>active</b>, <b>inactive</b>, <b>suspended</b>, <b>closed</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status91? Status { get; init; }

    /// <summary>
    /// The last four digits of the network token <c>id</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenLastFour")]
    public string? TokenLastFour { get; init; }

    /// <summary>
    /// The token requestor is an entity who requested tokenization of the card for secure payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenRequestor")]
    public Item? TokenRequestor { get; init; }

    /// <summary>
    /// The type of network token. For example, <b>wallet</b>, <b>cof</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

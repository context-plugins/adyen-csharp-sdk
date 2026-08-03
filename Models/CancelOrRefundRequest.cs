using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CancelOrRefundRequest
{
    /// <summary>
    /// This field contains additional data, which may be required for a particular modification request.
    /// <para>
    /// The additionalData object consists of entries, each of which includes the key and value.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public MpiData? MpiData { get; init; }

    /// <summary>
    /// The original merchant reference to cancel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalMerchantReference")]
    public string? OriginalMerchantReference { get; init; }

    /// <summary>
    /// The original pspReference of the payment to modify.
    /// This reference is returned in:
    /// * authorisation response
    /// * authorisation notification
    /// </summary>
    [JsonPropertyName("originalReference")]
    public required string OriginalReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogic1? PlatformChargebackLogic { get; init; }

    /// <summary>
    /// Your reference for the payment modification. This reference is visible in Customer Area and in reports.
    /// Maximum length: 80 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The transaction reference provided by the PED. For point-of-sale integrations only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tenderReference")]
    public string? TenderReference { get; init; }

    /// <summary>
    /// Unique terminal ID for the PED that originally processed the request. For point-of-sale integrations only.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uniqueTerminalId")]
    public string? UniqueTerminalId { get; init; }
}

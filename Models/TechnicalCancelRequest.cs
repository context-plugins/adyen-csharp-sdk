using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TechnicalCancelRequest
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
    [JsonPropertyName("modificationAmount")]
    public ModificationAmount? ModificationAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public MpiData? MpiData { get; init; }

    /// <summary>
    /// The original merchant reference to cancel.
    /// </summary>
    [JsonPropertyName("originalMerchantReference")]
    public required string OriginalMerchantReference { get; init; }

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
    /// An array of objects specifying how the amount should be split between accounts when using Adyen for Platforms. For more information, see how to split payments for <see href="https://docs.adyen.com/platforms/automatic-split-configuration/">platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splits")]
    public IReadOnlyList<Split>? Splits { get; init; }

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

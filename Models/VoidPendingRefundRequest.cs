using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record VoidPendingRefundRequest
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

    /// <summary>
    /// The amount that needs to be captured/refunded. Required for <c>/capture</c> and <c>/refund</c>, not allowed for <c>/cancel</c>. The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationAmount")]
    public Amount? ModificationAmount { get; init; }

    /// <summary>
    /// Authentication data produced by an MPI (Mastercard SecureCode, Visa Secure, or Cartes Bancaires).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mpiData")]
    public ThreeDSecureData? MpiData { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originalReference")]
    public string? OriginalReference { get; init; }

    /// <summary>
    /// Defines how to book chargebacks when using <see href="https://docs.adyen.com/adyen-for-platforms-model">Adyen for Platforms</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformChargebackLogic")]
    public PlatformChargebackLogic? PlatformChargebackLogic { get; init; }

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

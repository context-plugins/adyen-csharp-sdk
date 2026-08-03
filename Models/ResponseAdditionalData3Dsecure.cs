using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalData3Dsecure
{
    /// <summary>
    /// Information provided by the issuer to the cardholder. If this field is present, you need to display this information to the cardholder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardHolderInfo")]
    public string? CardHolderInfo { get; init; }

    /// <summary>
    /// The Cardholder Authentication Verification Value (CAVV) for the 3D Secure authentication session, as a Base64-encoded 20-byte array.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavv")]
    public string? Cavv { get; init; }

    /// <summary>
    /// The CAVV algorithm used.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cavvAlgorithm")]
    public string? CavvAlgorithm { get; init; }

    /// <summary>
    /// Shows the <see href="https://docs.adyen.com/payments-fundamentals/psd2-sca-compliance-and-implementation-guide#specifypreferenceinyourapirequest">exemption type</see> that Adyen requested for the payment.
    /// <para>
    ///  Possible values:
    /// * <b>lowValue</b>
    /// * <b>secureCorporate</b>
    /// * <b>trustedBeneficiary</b>
    /// * <b>transactionRiskAnalysis</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaExemptionRequested")]
    public string? ScaExemptionRequested { get; init; }

    /// <summary>
    /// Indicates whether a card is enrolled for 3D Secure 2.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeds2.cardEnrolled")]
    public bool? Threeds2CardEnrolled { get; init; }
}

using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DonationRequest
{
    /// <summary>
    /// The Adyen account name of the charity.
    /// </summary>
    [JsonPropertyName("donationAccount")]
    public required string DonationAccount { get; init; }

    /// <summary>
    /// The merchant account that is used to process the payment.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// The amount to be donated.The <c>currency</c> must match the currency used in authorisation, the <c>value</c> must be smaller than or equal to the authorised amount.
    /// </summary>
    [JsonPropertyName("modificationAmount")]
    public required Amount ModificationAmount { get; init; }

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
}

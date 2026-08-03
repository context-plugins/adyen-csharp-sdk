using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information related to the payment card used for the transaction.
/// Allows acquisition of the card data by the Sale System before the Payment, CardAcquisition, or BalanceInquiry request to the POI. It can also be sent in the CardAcquisition response, to be processed by the Sale System.
/// </summary>
public record CardData
{
    /// <summary>
    /// Type of payment card.
    /// If card PAN is readable.
    /// Indicates the card used to pay in the PaymentResponse. Sent in the CardAcquisitionResponse, to leave the Cashier to choose between several applications in a smartcard, or several brand in a co-branded card. In this case, the CardAcquisitionRequest.ForceCustomerSelectionFlag must contain the value False. Brands are part of the POI and Sale Systems configurations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentBrand")]
    [RegularExpression("^.+$")]
    public string? PaymentBrand { get; init; }

    /// <summary>
    /// Masked Primary Account Number
    /// Part of the PAN is replaced by a string of * characters, to identify a customer account or relationship. Presence of this data element, which replace the PAN when SensitiveCardData is protected and replaced by ProtectedCardData. Alternatively the MaskedPAN can be used as a token to identify a customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaskedPan")]
    [RegularExpression("^.+$")]
    public string? MaskedPan { get; init; }

    /// <summary>
    /// Reference of the PAN, which identifies the PAN or the card uniquely, named also PAR (Payment Account Reference). This reference may be defined by the card issuer or by a token service provider under the control of the card issuer, and cannot be used for a payment transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountRef")]
    [RegularExpression("^.+$")]
    public string? PaymentAccountRef { get; init; }

    /// <summary>
    /// Entry mode of the payment instrument information. In the Payment, Loyalty or StoredValue Request messages, it informs the POI System the entry mode of the payment instrument information when read by the Sale Terminal. In the Payment, Loyalty or StoredValue Response messages, it informs the Sale System the entry mode of the payment instrument.
    /// Possible values:
    /// * <b>Contactless</b>
    /// * <b>File</b>
    /// * <b>ICC</b>
    /// * <b>Keyed</b>
    /// * <b>MagStripe</b>
    /// * <b>Manual</b>
    /// * <b>Mobile</b>
    /// * <b>RFID</b>
    /// * <b>Scanned</b>
    /// * <b>SynchronousICC</b>
    /// * <b>Tapped</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EntryMode")]
    public IReadOnlyList<EntryMode>? EntryMode { get; init; }

    /// <summary>
    /// Country Code attached to the card (3 numerics).
    /// If available in the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardCountryCode")]
    [Minimum(3)]
    [Maximum(3)]
    public int? CardCountryCode { get; init; }

    /// <summary>
    /// Sensitive information related to the payment card, protected by CMS.
    /// SensitiveCardData protected by CMS EnvelopedData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedCardData")]
    public string? ProtectedCardData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SensitiveCardData")]
    public SensitiveCardData2? SensitiveCardData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentToken")]
    public PaymentToken2? PaymentToken { get; init; }
}

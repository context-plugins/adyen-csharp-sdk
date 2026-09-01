using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the instrument of payment for the transaction.
/// If this type of payment card is configured to send information if the CardAcquisition response.
/// </summary>
public record PaymentInstrumentData1
{
    /// <summary>
    /// Type of payment instrument.
    /// Possible values:
    /// * <b>Card</b>
    /// * <b>Cash</b>
    /// * <b>Check</b>
    /// * <b>Mobile</b>
    /// * <b>StoredValue</b>
    /// </summary>
    [JsonPropertyName("PaymentInstrumentType")]
    public required PaymentInstrumentType11 PaymentInstrumentType { get; init; }

    /// <summary>
    /// Sensitive information related to the payment card, protected by CMS.
    /// SensitiveCardData protected by CMS EnvelopedData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedCardData")]
    public string? ProtectedCardData { get; init; }

    /// <summary>
    /// Information related to the payment card used for the transaction.
    /// If PaymentInstrumentType is Card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardData")]
    public CardData1? CardData { get; init; }

    /// <summary>
    /// Information related to the paper check used for the transaction.
    /// If PaymentInstrumentType is Check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CheckData")]
    public CheckData1? CheckData { get; init; }

    /// <summary>
    /// Information related to the mobile for the payment transaction.
    /// If PaymentInstrumentType is Mobile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MobileData")]
    public MobileData1? MobileData { get; init; }

    /// <summary>
    /// Identification of the stored value account or the stored value card and the associated product sold by the Sale System for stored value requests.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountID")]
    public StoredValueAccountId? StoredValueAccountId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Data related to the instrument of payment for the transaction.
/// If this type of payment card is configured to send information if the CardAcquisition response.
/// </summary>
public record PaymentInstrumentData1
{
    [JsonPropertyName("PaymentInstrumentType")]
    public required PaymentInstrumentType11 PaymentInstrumentType { get; init; }

    /// <summary>
    /// Sensitive information related to the payment card, protected by CMS.
    /// SensitiveCardData protected by CMS EnvelopedData.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ProtectedCardData")]
    public string? ProtectedCardData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardData")]
    public CardData2? CardData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CheckData")]
    public CheckData2? CheckData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MobileData")]
    public MobileData2? MobileData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueAccountID")]
    public StoredValueAccountId2? StoredValueAccountId { get; init; }
}

using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Details of the card or token used to fund the pay-in transaction.
/// </summary>
public record FundingInstrument2
{
    /// <summary>
    /// Card details used for the transfer, such as the Primary Account Number (PAN) or stored payment method ID. Required if <c>sourceOfFunds</c> is <b>DEBIT</b>. Provide either:
    ///  - <c>storedPaymentMethodId</c> or
    ///  - <c>expiryMonth</c>, <c>expiryYear</c>, and <c>number</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardIdentification")]
    public CardIdentification2? CardIdentification { get; init; }

    /// <summary>
    /// The unique reference assigned by the card network for the pay-in transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkPaymentReference")]
    public string? NetworkPaymentReference { get; init; }

    /// <summary>
    /// Your internal reference that identifies this funding instrument. Required if <c>sourceOfFunds</c> is <b>DEPOSIT_ACCOUNT</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// Indicates where the funds used for the transfer originated. Possible values are:
    /// - <b>DEBIT</b> for card-to-card transfers.
    /// - <b>DEPOSIT_ACCOUNT</b> for wallet-to-card transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceOfFunds")]
    public SourceOfFunds? SourceOfFunds { get; init; }
}

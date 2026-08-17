using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record PaymentAccountStatus
{
    /// <summary>
    /// Data related to the instrument of payment for the transaction.
    /// Sent in the result of the payment transaction. For a card, it could also be sent in the <c>CardAcquisition</c> response, to be processed by the Sale System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData? PaymentInstrumentData { get; init; }

    /// <summary>
    /// Balance of an account after processing of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CurrentBalance")]
    [Minimum(0.0)]
    [Maximum(99999999.999999)]
    public double? CurrentBalance { get; init; }

    /// <summary>
    /// Currency of a monetary amount.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Currency")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? Currency { get; init; }

    /// <summary>
    /// Data related to the response from the payment Acquirer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAcquirerData")]
    public PaymentAcquirerData? PaymentAcquirerData { get; init; }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

public record PaymentAccountStatus
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentInstrumentData")]
    public PaymentInstrumentData2? PaymentInstrumentData { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAcquirerData")]
    public PaymentAcquirerData1? PaymentAcquirerData { get; init; }
}

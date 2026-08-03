using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Object that contains the status and outcomes of the <see href="https://docs.adyen.com/payment-methods/cards/name-validation">name validation</see>.
/// </summary>
public record PaymentValidationsNameResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawResponse")]
    public PaymentValidationsNameResultRawResponse? RawResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public PaymentValidationsNameResultResponse? Result { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status11? Status { get; init; }
}

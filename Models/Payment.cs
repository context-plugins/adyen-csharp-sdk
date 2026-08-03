using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Payment
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount16? Amount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public PaymentResponse8? PaymentMethod { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique. Use this reference when you communicate with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode2? ResultCode { get; init; }
}

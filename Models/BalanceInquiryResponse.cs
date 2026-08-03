using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Content of the Balance Inquiry Response message.
/// It conveys the balance and the identification of the associated payment, loyalty or stored value account.
/// </summary>
public record BalanceInquiryResponse
{
    [JsonPropertyName("Response")]
    public required Response3 Response { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentAccountStatus")]
    public PaymentAccountStatus? PaymentAccountStatus { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentReceipt")]
    public IReadOnlyList<PaymentReceipt>? PaymentReceipt { get; init; }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PaymentToken2
{
    [JsonPropertyName("TokenRequestedType")]
    public required TokenRequestedType1 TokenRequestedType { get; init; }

    /// <summary>
    /// Payment token replacing the PAN of the payment card to identify the payment
    ///  mean of the customer.
    /// </summary>
    [JsonPropertyName("TokenValue")]
    [RegularExpression("^.+$")]
    public required string TokenValue { get; init; }

    /// <summary>
    /// Expiry date and time. Limits the validity of a payment token.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ExpiryDateTime")]
    public DateTimeOffset? ExpiryDateTime { get; init; }
}

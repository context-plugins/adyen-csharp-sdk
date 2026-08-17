using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The object that contains the validation outcomes.
/// Only returned if <c>resultCode</c> is <b>Authorised</b> and if you have requested a payment validation in the request.
/// </summary>
public record PaymentResponse2
{
    /// <summary>
    /// Object that contains the status and outcomes of the <see href="https://docs.adyen.com/payment-methods/cards/name-validation">name validation</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public PaymentValidationsNameResponse2? Name { get; init; }
}

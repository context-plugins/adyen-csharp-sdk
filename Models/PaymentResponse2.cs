using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The object that contains the validation outcomes.
/// Only returned if <c>resultCode</c> is <b>Authorised</b> and if you have requested a payment validation in the request.
/// </summary>
public record PaymentResponse2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public PaymentValidationsNameResponse? Name { get; init; }
}

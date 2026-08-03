using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The object that you can use to enable payment validations for a transaction.
/// </summary>
public record PaymentValidations2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public Name6? Name { get; init; }
}

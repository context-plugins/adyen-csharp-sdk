using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpiPaymentMethodProperties
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("virtualPaymentAddress")]
    [StringLength(256, MinimumLength = 1)]
    public string? VirtualPaymentAddress { get; init; }
}

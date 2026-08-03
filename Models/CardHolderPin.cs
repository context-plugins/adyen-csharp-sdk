using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CardHolderPin
{
    [JsonPropertyName("EncrPINBlock")]
    public required string EncrPinblock { get; init; }

    [JsonPropertyName("PINFormat")]
    public required Pinformat1 Pinformat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdditionalInput")]
    [RegularExpression("^.+$")]
    public string? AdditionalInput { get; init; }
}

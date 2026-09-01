using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CardHolderPin
{
    [JsonPropertyName("EncrPINBlock")]
    public required string EncrPinBlock { get; init; }

    /// <summary>
    /// Possible values:
    /// * <b>ISO0</b>
    /// * <b>ISO1</b>
    /// * <b>ISO2</b>
    /// * <b>ISO3</b>
    /// </summary>
    [JsonPropertyName("PINFormat")]
    public required PinFormat1 PinFormat { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdditionalInput")]
    [RegularExpression("^.+$")]
    public string? AdditionalInput { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

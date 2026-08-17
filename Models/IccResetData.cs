using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record IccResetData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ATRValue")]
    [RegularExpression("^.{1,100}$")]
    public string? AtrValue { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardStatusWords")]
    [RegularExpression("^.{2,2}$")]
    public string? CardStatusWords { get; init; }
}

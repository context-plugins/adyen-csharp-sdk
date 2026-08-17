using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record WebDataExemption
{
    /// <summary>
    /// The reason why the web data was not provided. Possible value: <b>noOnlinePresence</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason3? Reason { get; init; }
}

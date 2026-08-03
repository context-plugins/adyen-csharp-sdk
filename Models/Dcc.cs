using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Dcc
{
    /// <summary>
    /// Enable Dynamic Currency Conversion (DCC). When you enable DCC, you are responsible for complying with <see href="https://help.adyen.com/en_US/knowledge/in-person-payments/terminal-features/dynamic-currency-conversion-dcc-rules-regulations">DCC receipt requirements and terms of use</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableDcc")]
    public bool? EnableDcc { get; init; }
}

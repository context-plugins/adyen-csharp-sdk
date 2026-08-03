using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Moto
{
    /// <summary>
    /// Enable MOTO transactions.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableMoto")]
    public bool? EnableMoto { get; init; }

    /// <summary>
    /// The maximum amount for MOTO transactions. You need to set the currency for this amount using the <see href="https://docs.adyen.com/api-explorer/Management/1/patch/companies/(companyId"><c>standalone.currencyCode</c></see>/terminalSettings#request-standalone-currencyCode) parameter. Do not enable standalone, unless you are using a standalone solution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxAmount")]
    public int? MaxAmount { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record MerchantPurchaseData
{
    /// <summary>
    /// Airline information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline")]
    public Airline11? Airline { get; init; }

    /// <summary>
    /// Lodging information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging")]
    public IReadOnlyList<Lodging1>? Lodging { get; init; }

    /// <summary>
    /// The type of events data.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>merchantPurchaseData</b>: merchant purchase data</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "merchantPurchaseData";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

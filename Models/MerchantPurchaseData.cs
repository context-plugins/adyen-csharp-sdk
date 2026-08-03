using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record MerchantPurchaseData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline")]
    public Airline2? Airline { get; init; }

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
    public required Type87 Type { get; init; }
}

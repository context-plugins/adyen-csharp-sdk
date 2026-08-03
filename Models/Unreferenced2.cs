using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Settings for unreferenced refunds.
/// </summary>
public record Unreferenced2
{
    /// <summary>
    /// Indicates whether unreferenced refunds are enabled on the terminal.
    /// <para>
    /// &gt; You're fully liable for losses resulting from fraudulent or duplicate unreferenced refunds. We recommend that you <see href="https://docs.adyen.com/point-of-sale/basic-tapi-integration/refund-payment/unreferenced/#risk-with-unreferenced-refunds">set an unreferenced refund limit and a refund delay</see> to reduce this risk.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enableUnreferencedRefunds")]
    public bool? EnableUnreferencedRefunds { get; init; }
}

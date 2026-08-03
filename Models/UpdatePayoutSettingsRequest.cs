using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdatePayoutSettingsRequest
{
    /// <summary>
    /// Indicates if payouts to this bank account are enabled. Default: <b>true</b>.
    /// <para>
    /// To receive payouts into this bank account, both <c>enabled</c> and <c>allowed</c> must be <b>true</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }
}

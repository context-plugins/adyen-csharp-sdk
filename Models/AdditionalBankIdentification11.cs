using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional identification codes of the bank. Some banks may require these identifiers for cross-border transfers.
/// </summary>
public record AdditionalBankIdentification11
{
    /// <summary>
    /// The value of the additional bank identification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The type of additional bank identification, depending on the country.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>auBsbCode</b>: The 6-digit <see href="https://en.wikipedia.org/wiki/Bank_state_branch">Australian Bank State Branch (BSB) code</see>, without separators or spaces.</description></item>
    ///   <item><description><b>caRoutingNumber</b>: The 9-digit <see href="https://en.wikipedia.org/wiki/Routing_number_(Canada">Canadian routing number</see>), in EFT format, without separators or spaces.</description></item>
    ///   <item><description><b>gbSortCode</b>: The 6-digit <see href="https://en.wikipedia.org/wiki/Sort_code">UK sort code</see>, without separators or spaces</description></item>
    ///   <item><description><b>usRoutingNumber</b>: The 9-digit <see href="https://en.wikipedia.org/wiki/ABA_routing_transit_number">routing number</see>, without separators or spaces.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public AdditionalBankIdentificationType? Type { get; init; }
}

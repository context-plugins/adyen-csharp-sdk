using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AdditionalBankIdentificationRequirement
{
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
    [JsonPropertyName("additionalBankIdentificationType")]
    public AdditionalBankIdentificationType? AdditionalBankIdentificationType { get; init; }

    /// <summary>
    /// The description of the additional bank identification requirement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>additionalBankIdentificationRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "additionalBankIdentificationRequirement";
}

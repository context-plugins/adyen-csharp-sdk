using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<AdditionalBankIdentificationType>))]
public sealed record AdditionalBankIdentificationType : StringEnum<AdditionalBankIdentificationType>
{
    private AdditionalBankIdentificationType(string value) : base(value)
    {
    }

    public static readonly AdditionalBankIdentificationType AuBsbCode = new("auBsbCode");

    public static readonly AdditionalBankIdentificationType CaRoutingNumber = new("caRoutingNumber");

    public static readonly AdditionalBankIdentificationType GbSortCode = new("gbSortCode");

    public static readonly AdditionalBankIdentificationType UsRoutingNumber = new("usRoutingNumber");

    public static AdditionalBankIdentificationType FromValue(string value) => FromValueCore(value);
}

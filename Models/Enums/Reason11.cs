using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason why the transfer failed Adyen's internal review.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>refusedForRegulatoryReasons</b>: the transfer does not comply with Adyen's risk policy. For more information, <see href="https://www.adyen.help/hc/en-us/requests/new">contact the Support Team</see>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Reason11>))]
public sealed record Reason11 : StringEnum<Reason11>
{
    private Reason11(string value) : base(value)
    {
    }

    public static readonly Reason11 RefusedForRegulatoryReasons = new("refusedForRegulatoryReasons");

    public static Reason11 FromValue(string value) => FromValueCore(value);
}

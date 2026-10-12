using System;
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
[JsonConverter(typeof(StringEnumConverter<Type510>))]
public sealed record Type510 : OpenStringEnum<Type510>
{
    private Type510(string value) : base(value)
    {
    }

    public static readonly Type510 AuBsbCode = new("auBsbCode");

    public static readonly Type510 CaRoutingNumber = new("caRoutingNumber");

    public static readonly Type510 GbSortCode = new("gbSortCode");

    public static readonly Type510 UsRoutingNumber = new("usRoutingNumber");

    public TResult Match<TResult>(Func<TResult> onAuBsbCode,
        Func<TResult> onCaRoutingNumber,
        Func<TResult> onGbSortCode,
        Func<TResult> onUsRoutingNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AuBsbCode => onAuBsbCode(),
            _ when this == CaRoutingNumber => onCaRoutingNumber(),
            _ when this == GbSortCode => onGbSortCode(),
            _ when this == UsRoutingNumber => onUsRoutingNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onAuBsbCode,
        Action onCaRoutingNumber,
        Action onGbSortCode,
        Action onUsRoutingNumber,
        Action<string> otherwise)
    {
        if (this == AuBsbCode) onAuBsbCode();
        else if (this == CaRoutingNumber) onCaRoutingNumber();
        else if (this == GbSortCode) onGbSortCode();
        else if (this == UsRoutingNumber) onUsRoutingNumber();
        else otherwise(Value);
    }
}

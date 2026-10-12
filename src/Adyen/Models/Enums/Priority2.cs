using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The priority for the bank transfer. This sets the speed at which the transfer is sent and the fees that you have to pay. Possible values:
/// <list type="bullet">
///   <item><description><b>regular</b>: For normal, low-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>fast</b>: A faster way to transfer funds, but the fees are higher. Recommended for high-priority, low-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>wire</b>: The fastest way to transfer funds, but this has the highest fees. Recommended for high-priority, high-value transactions.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>instant</b>: For instant funds transfers within the United States and in <see href="https://www.ecb.europa.eu/paym/integration/retail/sepa/html/index.en.html">SEPA locations</see>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>crossBorder</b>: For high-value transfers to a recipient in a different country.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>internal</b>: For transfers to an Adyen-issued business bank account (by bank account number/IBAN).</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Priority2>))]
public sealed record Priority2 : OpenStringEnum<Priority2>
{
    private Priority2(string value) : base(value)
    {
    }

    public static readonly Priority2 CrossBorder = new("crossBorder");

    public static readonly Priority2 Fast = new("fast");

    public static readonly Priority2 Instant = new("instant");

    public static readonly Priority2 Internal = new("internal");

    public static readonly Priority2 Regular = new("regular");

    public static readonly Priority2 Wire = new("wire");

    public TResult Match<TResult>(Func<TResult> onCrossBorder,
        Func<TResult> onFast,
        Func<TResult> onInstant,
        Func<TResult> onInternal,
        Func<TResult> onRegular,
        Func<TResult> onWire,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CrossBorder => onCrossBorder(),
            _ when this == Fast => onFast(),
            _ when this == Instant => onInstant(),
            _ when this == Internal => onInternal(),
            _ when this == Regular => onRegular(),
            _ when this == Wire => onWire(),
            _ => otherwise(Value)
        };

    public void Match(Action onCrossBorder,
        Action onFast,
        Action onInstant,
        Action onInternal,
        Action onRegular,
        Action onWire,
        Action<string> otherwise)
    {
        if (this == CrossBorder) onCrossBorder();
        else if (this == Fast) onFast();
        else if (this == Instant) onInstant();
        else if (this == Internal) onInternal();
        else if (this == Regular) onRegular();
        else if (this == Wire) onWire();
        else otherwise(Value);
    }
}

using System;
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
public sealed record Reason11 : OpenStringEnum<Reason11>
{
    private Reason11(string value) : base(value)
    {
    }

    public static readonly Reason11 RefusedForRegulatoryReasons = new("refusedForRegulatoryReasons");

    public TResult Match<TResult>(Func<TResult> onRefusedForRegulatoryReasons, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RefusedForRegulatoryReasons => onRefusedForRegulatoryReasons(),
            _ => otherwise(Value)
        };

    public void Match(Action onRefusedForRegulatoryReasons, Action<string> otherwise)
    {
        if (this == RefusedForRegulatoryReasons) onRefusedForRegulatoryReasons();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ach</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Ach = new("ach");

    public static readonly TypeEnum AchPlaid = new("ach_plaid");

    public TResult Match<TResult>(Func<TResult> onAch, Func<TResult> onAchPlaid, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ach => onAch(),
            _ when this == AchPlaid => onAchPlaid(),
            _ => otherwise(Value)
        };

    public void Match(Action onAch, Action onAchPlaid, Action<string> otherwise)
    {
        if (this == Ach) onAch();
        else if (this == AchPlaid) onAchPlaid();
        else otherwise(Value);
    }
}

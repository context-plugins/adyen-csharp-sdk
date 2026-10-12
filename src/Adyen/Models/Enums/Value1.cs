using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value1>))]
public sealed record Value1 : OpenStringEnum<Value1>
{
    private Value1(string value) : base(value)
    {
    }

    public static readonly Value1 Friday = new("friday");

    public static readonly Value1 Monday = new("monday");

    public static readonly Value1 Saturday = new("saturday");

    public static readonly Value1 Sunday = new("sunday");

    public static readonly Value1 Thursday = new("thursday");

    public static readonly Value1 Tuesday = new("tuesday");

    public static readonly Value1 Wednesday = new("wednesday");

    public TResult Match<TResult>(Func<TResult> onFriday,
        Func<TResult> onMonday,
        Func<TResult> onSaturday,
        Func<TResult> onSunday,
        Func<TResult> onThursday,
        Func<TResult> onTuesday,
        Func<TResult> onWednesday,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Friday => onFriday(),
            _ when this == Monday => onMonday(),
            _ when this == Saturday => onSaturday(),
            _ when this == Sunday => onSunday(),
            _ when this == Thursday => onThursday(),
            _ when this == Tuesday => onTuesday(),
            _ when this == Wednesday => onWednesday(),
            _ => otherwise(Value)
        };

    public void Match(Action onFriday,
        Action onMonday,
        Action onSaturday,
        Action onSunday,
        Action onThursday,
        Action onTuesday,
        Action onWednesday,
        Action<string> otherwise)
    {
        if (this == Friday) onFriday();
        else if (this == Monday) onMonday();
        else if (this == Saturday) onSaturday();
        else if (this == Sunday) onSunday();
        else if (this == Thursday) onThursday();
        else if (this == Tuesday) onTuesday();
        else if (this == Wednesday) onWednesday();
        else otherwise(Value);
    }
}

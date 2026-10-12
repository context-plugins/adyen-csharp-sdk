using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type91>))]
public sealed record Type91 : OpenStringEnum<Type91>
{
    private Type91(string value) : base(value)
    {
    }

    public static readonly Type91 Back = new("BACK");

    public static readonly Type91 Front = new("FRONT");

    public static readonly Type91 Undefined = new("UNDEFINED");

    public TResult Match<TResult>(Func<TResult> onBack,
        Func<TResult> onFront,
        Func<TResult> onUndefined,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Back => onBack(),
            _ when this == Front => onFront(),
            _ when this == Undefined => onUndefined(),
            _ => otherwise(Value)
        };

    public void Match(Action onBack, Action onFront, Action onUndefined, Action<string> otherwise)
    {
        if (this == Back) onBack();
        else if (this == Front) onFront();
        else if (this == Undefined) onUndefined();
        else otherwise(Value);
    }
}

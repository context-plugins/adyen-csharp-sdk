using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>ISO0</b>
/// * <b>ISO1</b>
/// * <b>ISO2</b>
/// * <b>ISO3</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinFormat1>))]
public sealed record PinFormat1 : OpenStringEnum<PinFormat1>
{
    private PinFormat1(string value) : base(value)
    {
    }

    public static readonly PinFormat1 Iso0 = new("ISO0");

    public static readonly PinFormat1 Iso1 = new("ISO1");

    public static readonly PinFormat1 Iso2 = new("ISO2");

    public static readonly PinFormat1 Iso3 = new("ISO3");

    public TResult Match<TResult>(Func<TResult> onIso0,
        Func<TResult> onIso1,
        Func<TResult> onIso2,
        Func<TResult> onIso3,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Iso0 => onIso0(),
            _ when this == Iso1 => onIso1(),
            _ when this == Iso2 => onIso2(),
            _ when this == Iso3 => onIso3(),
            _ => otherwise(Value)
        };

    public void Match(Action onIso0, Action onIso1, Action onIso2, Action onIso3, Action<string> otherwise)
    {
        if (this == Iso0) onIso0();
        else if (this == Iso1) onIso1();
        else if (this == Iso2) onIso2();
        else if (this == Iso3) onIso3();
        else otherwise(Value);
    }
}

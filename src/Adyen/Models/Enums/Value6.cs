using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value6>))]
public sealed record Value6 : OpenStringEnum<Value6>
{
    private Value6(string value) : base(value)
    {
    }

    public static readonly Value6 Card = new("CARD");

    public static readonly Value6 MobilePhone = new("MOBILE_PHONE");

    public static readonly Value6 Other = new("OTHER");

    public static readonly Value6 Pc = new("PC");

    public static readonly Value6 TabletOrEreader = new("TABLET_OR_EREADER");

    public static readonly Value6 Unknown = new("UNKNOWN");

    public static readonly Value6 WatchOrWristband = new("WATCH_OR_WRISTBAND");

    public static readonly Value6 Wearable = new("WEARABLE");

    public TResult Match<TResult>(Func<TResult> onCard,
        Func<TResult> onMobilePhone,
        Func<TResult> onOther,
        Func<TResult> onPc,
        Func<TResult> onTabletOrEreader,
        Func<TResult> onUnknown,
        Func<TResult> onWatchOrWristband,
        Func<TResult> onWearable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Card => onCard(),
            _ when this == MobilePhone => onMobilePhone(),
            _ when this == Other => onOther(),
            _ when this == Pc => onPc(),
            _ when this == TabletOrEreader => onTabletOrEreader(),
            _ when this == Unknown => onUnknown(),
            _ when this == WatchOrWristband => onWatchOrWristband(),
            _ when this == Wearable => onWearable(),
            _ => otherwise(Value)
        };

    public void Match(Action onCard,
        Action onMobilePhone,
        Action onOther,
        Action onPc,
        Action onTabletOrEreader,
        Action onUnknown,
        Action onWatchOrWristband,
        Action onWearable,
        Action<string> otherwise)
    {
        if (this == Card) onCard();
        else if (this == MobilePhone) onMobilePhone();
        else if (this == Other) onOther();
        else if (this == Pc) onPc();
        else if (this == TabletOrEreader) onTabletOrEreader();
        else if (this == Unknown) onUnknown();
        else if (this == WatchOrWristband) onWatchOrWristband();
        else if (this == Wearable) onWearable();
        else otherwise(Value);
    }
}

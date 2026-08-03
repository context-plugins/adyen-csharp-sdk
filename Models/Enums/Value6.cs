using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value6>))]
public sealed record Value6 : StringEnum<Value6>
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

    public static Value6 FromValue(string value) => FromValueCore(value);
}

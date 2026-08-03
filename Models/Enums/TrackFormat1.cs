using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Card track format.
/// Possible values:
/// * <b>AAMVA</b>
/// * <b>ISO</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrackFormat1>))]
public sealed record TrackFormat1 : StringEnum<TrackFormat1>
{
    private TrackFormat1(string value) : base(value)
    {
    }

    public static readonly TrackFormat1 Iso = new("ISO");

    public static readonly TrackFormat1 JisI = new("JIS-I");

    public static readonly TrackFormat1 JisIi = new("JIS-II");

    public static readonly TrackFormat1 Aamva = new("AAMVA");

    public static readonly TrackFormat1 Cmc7 = new("CMC-7");

    public static readonly TrackFormat1 E13B = new("E-13B");

    public static TrackFormat1 FromValue(string value) => FromValueCore(value);
}

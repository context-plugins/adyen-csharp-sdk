using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Magnetic track or magnetic ink characters line.
/// Possible values:
/// * <b>ISO</b>
/// * <b>JIS-I</b>
/// * <b>JIS-II</b>
/// * <b>AAMVA</b>
/// * <b>CMC-7</b>
/// * <b>E-13B</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TrackFormat>))]
public sealed record TrackFormat : StringEnum<TrackFormat>
{
    private TrackFormat(string value) : base(value)
    {
    }

    public static readonly TrackFormat Iso = new("ISO");

    public static readonly TrackFormat JisI = new("JIS-I");

    public static readonly TrackFormat JisIi = new("JIS-II");

    public static readonly TrackFormat Aamva = new("AAMVA");

    public static readonly TrackFormat Cmc7 = new("CMC-7");

    public static readonly TrackFormat E13B = new("E-13B");

    public static TrackFormat FromValue(string value) => FromValueCore(value);
}

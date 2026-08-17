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
public sealed record PinFormat1 : StringEnum<PinFormat1>
{
    private PinFormat1(string value) : base(value)
    {
    }

    public static readonly PinFormat1 Iso0 = new("ISO0");

    public static readonly PinFormat1 Iso1 = new("ISO1");

    public static readonly PinFormat1 Iso2 = new("ISO2");

    public static readonly PinFormat1 Iso3 = new("ISO3");

    public static PinFormat1 FromValue(string value) => FromValueCore(value);
}

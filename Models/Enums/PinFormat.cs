using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<PinFormat>))]
public sealed record PinFormat : StringEnum<PinFormat>
{
    private PinFormat(string value) : base(value)
    {
    }

    public static readonly PinFormat Iso0 = new("ISO0");

    public static readonly PinFormat Iso1 = new("ISO1");

    public static readonly PinFormat Iso2 = new("ISO2");

    public static readonly PinFormat Iso3 = new("ISO3");

    public static PinFormat FromValue(string value) => FromValueCore(value);
}

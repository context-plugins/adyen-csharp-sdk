using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value2>))]
public sealed record Value2 : StringEnum<Value2>
{
    private Value2(string value) : base(value)
    {
    }

    public static readonly Value2 Barcode = new("barcode");

    public static readonly Value2 Chip = new("chip");

    public static readonly Value2 Cof = new("cof");

    public static readonly Value2 Contactless = new("contactless");

    public static readonly Value2 Magstripe = new("magstripe");

    public static readonly Value2 Manual = new("manual");

    public static readonly Value2 Ocr = new("ocr");

    public static readonly Value2 Server = new("server");

    public static readonly Value2 Unknown = new("unknown");

    public static Value2 FromValue(string value) => FromValueCore(value);
}

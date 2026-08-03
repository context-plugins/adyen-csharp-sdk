using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Pinformat>))]
public sealed record Pinformat : StringEnum<Pinformat>
{
    private Pinformat(string value) : base(value)
    {
    }

    public static readonly Pinformat Iso0 = new("ISO0");

    public static readonly Pinformat Iso1 = new("ISO1");

    public static readonly Pinformat Iso2 = new("ISO2");

    public static readonly Pinformat Iso3 = new("ISO3");

    public static Pinformat FromValue(string value) => FromValueCore(value);
}

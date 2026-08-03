using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of mandate. Possible value: <b>bacs</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MandateType2>))]
public sealed record MandateType2 : StringEnum<MandateType2>
{
    private MandateType2(string value) : base(value)
    {
    }

    public static readonly MandateType2 Bacs = new("bacs");

    public static MandateType2 FromValue(string value) => FromValueCore(value);
}

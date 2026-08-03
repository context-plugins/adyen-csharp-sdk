using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MandateType>))]
public sealed record MandateType : StringEnum<MandateType>
{
    private MandateType(string value) : base(value)
    {
    }

    public static readonly MandateType Bacs = new("bacs");

    public static MandateType FromValue(string value) => FromValueCore(value);
}

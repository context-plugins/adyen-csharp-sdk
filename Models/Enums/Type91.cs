using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type91>))]
public sealed record Type91 : StringEnum<Type91>
{
    private Type91(string value) : base(value)
    {
    }

    public static readonly Type91 Back = new("BACK");

    public static readonly Type91 Front = new("FRONT");

    public static readonly Type91 Undefined = new("UNDEFINED");

    public static Type91 FromValue(string value) => FromValueCore(value);
}

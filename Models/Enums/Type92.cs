using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type92>))]
public sealed record Type92 : StringEnum<Type92>
{
    private Type92(string value) : base(value)
    {
    }

    public static readonly Type92 Back = new("BACK");

    public static readonly Type92 Front = new("FRONT");

    public static readonly Type92 Undefined = new("UNDEFINED");

    public static Type92 FromValue(string value) => FromValueCore(value);
}

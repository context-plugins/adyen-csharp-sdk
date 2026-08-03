using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value1>))]
public sealed record Value1 : StringEnum<Value1>
{
    private Value1(string value) : base(value)
    {
    }

    public static readonly Value1 Friday = new("friday");

    public static readonly Value1 Monday = new("monday");

    public static readonly Value1 Saturday = new("saturday");

    public static readonly Value1 Sunday = new("sunday");

    public static readonly Value1 Thursday = new("thursday");

    public static readonly Value1 Tuesday = new("tuesday");

    public static readonly Value1 Wednesday = new("wednesday");

    public static Value1 FromValue(string value) => FromValueCore(value);
}

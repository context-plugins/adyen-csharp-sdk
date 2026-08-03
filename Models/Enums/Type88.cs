using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ukFps</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type88>))]
public sealed record Type88 : StringEnum<Type88>
{
    private Type88(string value) : base(value)
    {
    }

    public static readonly Type88 UkFps = new("ukFps");

    public static Type88 FromValue(string value) => FromValueCore(value);
}

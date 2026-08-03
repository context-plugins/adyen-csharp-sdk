using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sgLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : StringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 SgLocal = new("sgLocal");

    public static Type8 FromValue(string value) => FromValueCore(value);
}

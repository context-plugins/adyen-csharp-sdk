using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// cashapp
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type16>))]
public sealed record Type16 : StringEnum<Type16>
{
    private Type16(string value) : base(value)
    {
    }

    public static readonly Type16 Cashapp = new("cashapp");

    public static Type16 FromValue(string value) => FromValueCore(value);
}

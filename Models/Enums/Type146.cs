using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>brLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type146>))]
public sealed record Type146 : StringEnum<Type146>
{
    private Type146(string value) : base(value)
    {
    }

    public static readonly Type146 BrLocal = new("brLocal");

    public static Type146 FromValue(string value) => FromValueCore(value);
}

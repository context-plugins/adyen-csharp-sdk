using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>seLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type264>))]
public sealed record Type264 : StringEnum<Type264>
{
    private Type264(string value) : base(value)
    {
    }

    public static readonly Type264 SeLocal = new("seLocal");

    public static Type264 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>nativeRedirect</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type553>))]
public sealed record Type553 : StringEnum<Type553>
{
    private Type553(string value) : base(value)
    {
    }

    public static readonly Type553 NativeRedirect = new("nativeRedirect");

    public static Type553 FromValue(string value) => FromValueCore(value);
}

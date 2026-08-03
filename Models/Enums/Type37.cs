using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>mobilepay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type37>))]
public sealed record Type37 : StringEnum<Type37>
{
    private Type37(string value) : base(value)
    {
    }

    public static readonly Type37 Mobilepay = new("mobilepay");

    public static Type37 FromValue(string value) => FromValueCore(value);
}

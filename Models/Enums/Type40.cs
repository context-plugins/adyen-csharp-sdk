using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paypay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type40>))]
public sealed record Type40 : StringEnum<Type40>
{
    private Type40(string value) : base(value)
    {
    }

    public static readonly Type40 Paypay = new("paypay");

    public static Type40 FromValue(string value) => FromValueCore(value);
}

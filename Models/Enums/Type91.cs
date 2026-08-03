using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>aupay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type91>))]
public sealed record Type91 : StringEnum<Type91>
{
    private Type91(string value) : base(value)
    {
    }

    public static readonly Type91 Aupay = new("aupay");

    public static Type91 FromValue(string value) => FromValueCore(value);
}

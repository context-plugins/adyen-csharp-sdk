using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>androidpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type61>))]
public sealed record Type61 : StringEnum<Type61>
{
    private Type61(string value) : base(value)
    {
    }

    public static readonly Type61 Androidpay = new("androidpay");

    public static Type61 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>amazonpay</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type41>))]
public sealed record Type41 : StringEnum<Type41>
{
    private Type41(string value) : base(value)
    {
    }

    public static readonly Type41 Amazonpay = new("amazonpay");

    public static Type41 FromValue(string value) => FromValueCore(value);
}

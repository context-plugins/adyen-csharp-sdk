using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paypal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type76>))]
public sealed record Type76 : StringEnum<Type76>
{
    private Type76(string value) : base(value)
    {
    }

    public static readonly Type76 Paypal = new("paypal");

    public static Type76 FromValue(string value) => FromValueCore(value);
}

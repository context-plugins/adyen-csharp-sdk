using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type46>))]
public sealed record Type46 : StringEnum<Type46>
{
    private Type46(string value) : base(value)
    {
    }

    public static readonly Type46 PsePayulatam = new("pse_payulatam");

    public static Type46 FromValue(string value) => FromValueCore(value);
}

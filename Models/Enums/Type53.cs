using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type53>))]
public sealed record Type53 : StringEnum<Type53>
{
    private Type53(string value) : base(value)
    {
    }

    public static readonly Type53 Twint = new("twint");

    public static Type53 FromValue(string value) => FromValueCore(value);
}

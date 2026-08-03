using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The payment method type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type31>))]
public sealed record Type31 : StringEnum<Type31>
{
    private Type31(string value) : base(value)
    {
    }

    public static readonly Type31 Alma = new("alma");

    public static Type31 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of phone number.
/// Possible values:
/// <b>Landline</b>, <b>Mobile</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : StringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Landline = new("landline");

    public static readonly Type4 Mobile = new("mobile");

    public static Type4 FromValue(string value) => FromValueCore(value);
}

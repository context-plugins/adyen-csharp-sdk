using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The gender.
/// &gt;The following values are permitted: <c>MALE</c>, <c>FEMALE</c>, <c>UNKNOWN</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Gender>))]
public sealed record Gender : StringEnum<Gender>
{
    private Gender(string value) : base(value)
    {
    }

    public static readonly Gender Male = new("MALE");

    public static readonly Gender Female = new("FEMALE");

    public static readonly Gender Unknown = new("UNKNOWN");

    public static Gender FromValue(string value) => FromValueCore(value);
}

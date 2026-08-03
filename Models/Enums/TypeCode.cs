using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Personal</b>
/// * <b>Company</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCode>))]
public sealed record TypeCode : StringEnum<TypeCode>
{
    private TypeCode(string value) : base(value)
    {
    }

    public static readonly TypeCode Personal = new("Personal");

    public static readonly TypeCode Company = new("Company");

    public static TypeCode FromValue(string value) => FromValueCore(value);
}

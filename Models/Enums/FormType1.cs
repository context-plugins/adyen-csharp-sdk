using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of tax form you want to retrieve. Accepted values are <b>US1099k</b> and <b>US1099nec</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FormType1>))]
public sealed record FormType1 : StringEnum<FormType1>
{
    private FormType1(string value) : base(value)
    {
    }

    public static readonly FormType1 Us1099K = new("US1099k");

    public static readonly FormType1 Us1099Nec = new("US1099nec");

    public static FormType1 FromValue(string value) => FromValueCore(value);
}

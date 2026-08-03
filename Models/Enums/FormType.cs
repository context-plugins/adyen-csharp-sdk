using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<FormType>))]
public sealed record FormType : StringEnum<FormType>
{
    private FormType(string value) : base(value)
    {
    }

    public static readonly FormType Us1099K = new("US1099k");

    public static readonly FormType Us1099Nec = new("US1099nec");

    public static FormType FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Personal</b>
/// * <b>Company</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCodeEnum>))]
public sealed record TypeCodeEnum : StringEnum<TypeCodeEnum>
{
    private TypeCodeEnum(string value) : base(value)
    {
    }

    public static readonly TypeCodeEnum Personal = new("Personal");

    public static readonly TypeCodeEnum Company = new("Company");

    public static TypeCodeEnum FromValue(string value) => FromValueCore(value);
}

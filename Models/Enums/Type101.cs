using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>directdebit_GB</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type101>))]
public sealed record Type101 : StringEnum<Type101>
{
    private Type101(string value) : base(value)
    {
    }

    public static readonly Type101 DirectdebitGb = new("directdebit_GB");

    public static Type101 FromValue(string value) => FromValueCore(value);
}

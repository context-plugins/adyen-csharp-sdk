using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>directdebit_AU</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type221>))]
public sealed record Type221 : StringEnum<Type221>
{
    private Type221(string value) : base(value)
    {
    }

    public static readonly Type221 DirectdebitAu = new("directdebit_AU");

    public static Type221 FromValue(string value) => FromValueCore(value);
}

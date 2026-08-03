using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>nzLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type233>))]
public sealed record Type233 : StringEnum<Type233>
{
    private Type233(string value) : base(value)
    {
    }

    public static readonly Type233 NzLocal = new("nzLocal");

    public static Type233 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>Cellulant</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type17>))]
public sealed record Type17 : StringEnum<Type17>
{
    private Type17(string value) : base(value)
    {
    }

    public static readonly Type17 Cellulant = new("cellulant");

    public static Type17 FromValue(string value) => FromValueCore(value);
}

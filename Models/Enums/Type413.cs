using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>auLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type413>))]
public sealed record Type413 : StringEnum<Type413>
{
    private Type413(string value) : base(value)
    {
    }

    public static readonly Type413 AuLocal = new("auLocal");

    public static Type413 FromValue(string value) => FromValueCore(value);
}

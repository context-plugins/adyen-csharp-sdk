using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>await</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type493>))]
public sealed record Type493 : StringEnum<Type493>
{
    private Type493(string value) : base(value)
    {
    }

    public static readonly Type493 Await = new("await");

    public static Type493 FromValue(string value) => FromValueCore(value);
}

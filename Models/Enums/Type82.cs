using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>sgLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type82>))]
public sealed record Type82 : StringEnum<Type82>
{
    private Type82(string value) : base(value)
    {
    }

    public static readonly Type82 SgLocal = new("sgLocal");

    public static Type82 FromValue(string value) => FromValueCore(value);
}

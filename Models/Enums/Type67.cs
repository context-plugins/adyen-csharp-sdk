using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of token. Allowed value: <b>externalToken</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type67>))]
public sealed record Type67 : StringEnum<Type67>
{
    private Type67(string value) : base(value)
    {
    }

    public static readonly Type67 ExternalToken = new("externalToken");

    public static Type67 FromValue(string value) => FromValueCore(value);
}

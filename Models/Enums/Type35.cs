using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>masterpass</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type35>))]
public sealed record Type35 : StringEnum<Type35>
{
    private Type35(string value) : base(value)
    {
    }

    public static readonly Type35 Masterpass = new("masterpass");

    public static Type35 FromValue(string value) => FromValueCore(value);
}

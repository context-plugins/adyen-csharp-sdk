using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>bank</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type312>))]
public sealed record Type312 : StringEnum<Type312>
{
    private Type312(string value) : base(value)
    {
    }

    public static readonly Type312 Bank = new("bank");

    public static Type312 FromValue(string value) => FromValueCore(value);
}

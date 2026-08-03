using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>issuedCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type512>))]
public sealed record Type512 : StringEnum<Type512>
{
    private Type512(string value) : base(value)
    {
    }

    public static readonly Type512 IssuedCard = new("issuedCard");

    public static Type512 FromValue(string value) => FromValueCore(value);
}

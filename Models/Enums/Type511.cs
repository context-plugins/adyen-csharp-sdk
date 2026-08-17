using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>issuedCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type511>))]
public sealed record Type511 : StringEnum<Type511>
{
    private Type511(string value) : base(value)
    {
    }

    public static readonly Type511 IssuedCard = new("issuedCard");

    public static Type511 FromValue(string value) => FromValueCore(value);
}

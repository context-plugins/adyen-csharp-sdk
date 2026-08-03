using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paywithgoogle</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type26>))]
public sealed record Type26 : StringEnum<Type26>
{
    private Type26(string value) : base(value)
    {
    }

    public static readonly Type26 Paywithgoogle = new("paywithgoogle");

    public static Type26 FromValue(string value) => FromValueCore(value);
}

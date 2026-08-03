using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>upi_intent</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type79>))]
public sealed record Type79 : StringEnum<Type79>
{
    private Type79(string value) : base(value)
    {
    }

    public static readonly Type79 UpiIntent = new("upi_intent");

    public static Type79 FromValue(string value) => FromValueCore(value);
}

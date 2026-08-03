using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>upi_collect</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type78>))]
public sealed record Type78 : StringEnum<Type78>
{
    private Type78(string value) : base(value)
    {
    }

    public static readonly Type78 UpiCollect = new("upi_collect");

    public static Type78 FromValue(string value) => FromValueCore(value);
}

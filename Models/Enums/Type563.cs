using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>qrCode</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type563>))]
public sealed record Type563 : StringEnum<Type563>
{
    private Type563(string value) : base(value)
    {
    }

    public static readonly Type563 QrCode = new("qrCode");

    public static Type563 FromValue(string value) => FromValueCore(value);
}

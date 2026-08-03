using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>upi_qr</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type80>))]
public sealed record Type80 : StringEnum<Type80>
{
    private Type80(string value) : base(value)
    {
    }

    public static readonly Type80 UpiQr = new("upi_qr");

    public static Type80 FromValue(string value) => FromValueCore(value);
}

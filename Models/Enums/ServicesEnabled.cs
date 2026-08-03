using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ServicesEnabled>))]
public sealed record ServicesEnabled : StringEnum<ServicesEnabled>
{
    private ServicesEnabled(string value) : base(value)
    {
    }

    public static readonly ServicesEnabled CardAcquisition = new("CardAcquisition");

    public static readonly ServicesEnabled Payment = new("Payment");

    public static readonly ServicesEnabled Loyalty = new("Loyalty");

    public static ServicesEnabled FromValue(string value) => FromValueCore(value);
}

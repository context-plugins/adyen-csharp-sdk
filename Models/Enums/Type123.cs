using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of resource that you associated with the SCA device.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type123>))]
public sealed record Type123 : StringEnum<Type123>
{
    private Type123(string value) : base(value)
    {
    }

    public static readonly Type123 PaymentInstrument = new("PAYMENT_INSTRUMENT");

    public static Type123 FromValue(string value) => FromValueCore(value);
}

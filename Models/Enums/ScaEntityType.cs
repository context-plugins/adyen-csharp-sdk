using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ScaEntityType>))]
public sealed record ScaEntityType : StringEnum<ScaEntityType>
{
    private ScaEntityType(string value) : base(value)
    {
    }

    public static readonly ScaEntityType AccountHolder = new("accountHolder");

    public static readonly ScaEntityType LegalEntity = new("legalEntity");

    public static readonly ScaEntityType PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType FromValue(string value) => FromValueCore(value);
}

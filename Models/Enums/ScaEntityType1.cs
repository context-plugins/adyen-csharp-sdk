using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of entity you are associating the device with.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType1>))]
public sealed record ScaEntityType1 : StringEnum<ScaEntityType1>
{
    private ScaEntityType1(string value) : base(value)
    {
    }

    public static readonly ScaEntityType1 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType1 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType1 PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType1 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity that you are associating with the SCA device.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType4>))]
public sealed record ScaEntityType4 : StringEnum<ScaEntityType4>
{
    private ScaEntityType4(string value) : base(value)
    {
    }

    public static readonly ScaEntityType4 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType4 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType4 PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType4 FromValue(string value) => FromValueCore(value);
}

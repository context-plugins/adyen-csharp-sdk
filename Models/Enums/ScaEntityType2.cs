using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType2>))]
public sealed record ScaEntityType2 : StringEnum<ScaEntityType2>
{
    private ScaEntityType2(string value) : base(value)
    {
    }

    public static readonly ScaEntityType2 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType2 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType2 PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType2 FromValue(string value) => FromValueCore(value);
}

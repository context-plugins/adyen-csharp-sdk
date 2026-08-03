using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType3>))]
public sealed record ScaEntityType3 : StringEnum<ScaEntityType3>
{
    private ScaEntityType3(string value) : base(value)
    {
    }

    public static readonly ScaEntityType3 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType3 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType3 PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType3 FromValue(string value) => FromValueCore(value);
}

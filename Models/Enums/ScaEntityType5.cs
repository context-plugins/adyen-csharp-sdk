using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of entity you want to retrieve a list of associations for.
/// <para>
/// Possible values: <b>accountHolder</b>, <b>legalEntity</b> or <b>paymentInstrument</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ScaEntityType5>))]
public sealed record ScaEntityType5 : StringEnum<ScaEntityType5>
{
    private ScaEntityType5(string value) : base(value)
    {
    }

    public static readonly ScaEntityType5 AccountHolder = new("accountHolder");

    public static readonly ScaEntityType5 LegalEntity = new("legalEntity");

    public static readonly ScaEntityType5 PaymentInstrument = new("paymentInstrument");

    public static ScaEntityType5 FromValue(string value) => FromValueCore(value);
}

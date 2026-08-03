using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason for not providing a VAT number.
/// <para>
/// Possible values: <b>industryExemption</b>, <b>belowTaxThreshold</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VatAbsenceReason1>))]
public sealed record VatAbsenceReason1 : StringEnum<VatAbsenceReason1>
{
    private VatAbsenceReason1(string value) : base(value)
    {
    }

    public static readonly VatAbsenceReason1 IndustryExemption = new("industryExemption");

    public static readonly VatAbsenceReason1 BelowTaxThreshold = new("belowTaxThreshold");

    public static VatAbsenceReason1 FromValue(string value) => FromValueCore(value);
}

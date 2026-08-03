using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The reason the organization has not provided a VAT number.
/// <para>
/// Possible values: <b>industryExemption</b>, <b>belowTaxThreshold</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<VatAbsenceReason>))]
public sealed record VatAbsenceReason : StringEnum<VatAbsenceReason>
{
    private VatAbsenceReason(string value) : base(value)
    {
    }

    public static readonly VatAbsenceReason IndustryExemption = new("industryExemption");

    public static readonly VatAbsenceReason BelowTaxThreshold = new("belowTaxThreshold");

    public static VatAbsenceReason FromValue(string value) => FromValueCore(value);
}

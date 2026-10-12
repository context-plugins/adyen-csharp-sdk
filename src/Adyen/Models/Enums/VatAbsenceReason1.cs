using System;
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
public sealed record VatAbsenceReason1 : OpenStringEnum<VatAbsenceReason1>
{
    private VatAbsenceReason1(string value) : base(value)
    {
    }

    public static readonly VatAbsenceReason1 IndustryExemption = new("industryExemption");

    public static readonly VatAbsenceReason1 BelowTaxThreshold = new("belowTaxThreshold");

    public TResult Match<TResult>(Func<TResult> onIndustryExemption,
        Func<TResult> onBelowTaxThreshold,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IndustryExemption => onIndustryExemption(),
            _ when this == BelowTaxThreshold => onBelowTaxThreshold(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndustryExemption, Action onBelowTaxThreshold, Action<string> otherwise)
    {
        if (this == IndustryExemption) onIndustryExemption();
        else if (this == BelowTaxThreshold) onBelowTaxThreshold();
        else otherwise(Value);
    }
}

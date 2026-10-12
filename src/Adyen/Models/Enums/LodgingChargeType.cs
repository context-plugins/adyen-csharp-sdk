using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The category of lodging charges for the payment.
/// * <b>additionalData key:</b> <c>lodging.specialProgramCode</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LodgingChargeType>))]
public sealed record LodgingChargeType : OpenStringEnum<LodgingChargeType>
{
    private LodgingChargeType(string value) : base(value)
    {
    }

    public static readonly LodgingChargeType AdvanceDeposit = new("advanceDeposit");

    public static readonly LodgingChargeType NoShow = new("noShow");

    public static readonly LodgingChargeType Stay = new("stay");

    public TResult Match<TResult>(Func<TResult> onAdvanceDeposit,
        Func<TResult> onNoShow,
        Func<TResult> onStay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdvanceDeposit => onAdvanceDeposit(),
            _ when this == NoShow => onNoShow(),
            _ when this == Stay => onStay(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdvanceDeposit, Action onNoShow, Action onStay, Action<string> otherwise)
    {
        if (this == AdvanceDeposit) onAdvanceDeposit();
        else if (this == NoShow) onNoShow();
        else if (this == Stay) onStay();
        else otherwise(Value);
    }
}

using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of Reconciliation requested by the Sale to the POI.
/// Possible values:
/// * <b>AcquirerReconciliation</b>
/// * <b>AcquirerSynchronisation</b>
/// * <b>PreviousReconciliation</b>
/// * <b>SaleReconciliation</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReconciliationType1>))]
public sealed record ReconciliationType1 : OpenStringEnum<ReconciliationType1>
{
    private ReconciliationType1(string value) : base(value)
    {
    }

    public static readonly ReconciliationType1 SaleReconciliation = new("SaleReconciliation");

    public static readonly ReconciliationType1 AcquirerSynchronisation = new("AcquirerSynchronisation");

    public static readonly ReconciliationType1 AcquirerReconciliation = new("AcquirerReconciliation");

    public static readonly ReconciliationType1 PreviousReconciliation = new("PreviousReconciliation");

    public TResult Match<TResult>(Func<TResult> onSaleReconciliation,
        Func<TResult> onAcquirerSynchronisation,
        Func<TResult> onAcquirerReconciliation,
        Func<TResult> onPreviousReconciliation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SaleReconciliation => onSaleReconciliation(),
            _ when this == AcquirerSynchronisation => onAcquirerSynchronisation(),
            _ when this == AcquirerReconciliation => onAcquirerReconciliation(),
            _ when this == PreviousReconciliation => onPreviousReconciliation(),
            _ => otherwise(Value)
        };

    public void Match(Action onSaleReconciliation,
        Action onAcquirerSynchronisation,
        Action onAcquirerReconciliation,
        Action onPreviousReconciliation,
        Action<string> otherwise)
    {
        if (this == SaleReconciliation) onSaleReconciliation();
        else if (this == AcquirerSynchronisation) onAcquirerSynchronisation();
        else if (this == AcquirerReconciliation) onAcquirerReconciliation();
        else if (this == PreviousReconciliation) onPreviousReconciliation();
        else otherwise(Value);
    }
}

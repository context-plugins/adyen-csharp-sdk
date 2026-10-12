using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SaleReconciliation</b>
/// * <b>AcquirerSynchronisation</b>
/// * <b>AcquirerReconciliation</b>
/// * <b>PreviousReconciliation</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReconciliationType>))]
public sealed record ReconciliationType : OpenStringEnum<ReconciliationType>
{
    private ReconciliationType(string value) : base(value)
    {
    }

    public static readonly ReconciliationType SaleReconciliation = new("SaleReconciliation");

    public static readonly ReconciliationType AcquirerSynchronisation = new("AcquirerSynchronisation");

    public static readonly ReconciliationType AcquirerReconciliation = new("AcquirerReconciliation");

    public static readonly ReconciliationType PreviousReconciliation = new("PreviousReconciliation");

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

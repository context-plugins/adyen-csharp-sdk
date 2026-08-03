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
public sealed record ReconciliationType1 : StringEnum<ReconciliationType1>
{
    private ReconciliationType1(string value) : base(value)
    {
    }

    public static readonly ReconciliationType1 SaleReconciliation = new("SaleReconciliation");

    public static readonly ReconciliationType1 AcquirerSynchronisation = new("AcquirerSynchronisation");

    public static readonly ReconciliationType1 AcquirerReconciliation = new("AcquirerReconciliation");

    public static readonly ReconciliationType1 PreviousReconciliation = new("PreviousReconciliation");

    public static ReconciliationType1 FromValue(string value) => FromValueCore(value);
}

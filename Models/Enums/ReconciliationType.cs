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
public sealed record ReconciliationType : StringEnum<ReconciliationType>
{
    private ReconciliationType(string value) : base(value)
    {
    }

    public static readonly ReconciliationType SaleReconciliation = new("SaleReconciliation");

    public static readonly ReconciliationType AcquirerSynchronisation = new("AcquirerSynchronisation");

    public static readonly ReconciliationType AcquirerReconciliation = new("AcquirerReconciliation");

    public static readonly ReconciliationType PreviousReconciliation = new("PreviousReconciliation");

    public static ReconciliationType FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Reason of the payment or loyalty reversal.
/// Possible values:
/// * <b>CustCancel</b>
/// * <b>Malfunction</b>
/// * <b>MerchantCancel</b>
/// * <b>Unable2Compl</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReversalReason1>))]
public sealed record ReversalReason1 : StringEnum<ReversalReason1>
{
    private ReversalReason1(string value) : base(value)
    {
    }

    public static readonly ReversalReason1 CustCancel = new("CustCancel");

    public static readonly ReversalReason1 MerchantCancel = new("MerchantCancel");

    public static readonly ReversalReason1 Malfunction = new("Malfunction");

    public static readonly ReversalReason1 Unable2Compl = new("Unable2Compl");

    public static ReversalReason1 FromValue(string value) => FromValueCore(value);
}

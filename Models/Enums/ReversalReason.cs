using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Reason of the payment or loyalty reversal.
/// Possible values:
/// * <b>CustCancel</b>
/// * <b>MerchantCancel</b>
/// * <b>Malfunction</b>
/// * <b>Unable2Compl</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReversalReason>))]
public sealed record ReversalReason : StringEnum<ReversalReason>
{
    private ReversalReason(string value) : base(value)
    {
    }

    public static readonly ReversalReason CustCancel = new("CustCancel");

    public static readonly ReversalReason MerchantCancel = new("MerchantCancel");

    public static readonly ReversalReason Malfunction = new("Malfunction");

    public static readonly ReversalReason Unable2Compl = new("Unable2Compl");

    public static ReversalReason FromValue(string value) => FromValueCore(value);
}

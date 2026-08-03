using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Action to realise on a transaction. In an <c>EnableService</c> request message:
///   - Starts a transaction by a swipe-ahead mechanism, with the services which are enabled.
///   - Aborts a swipe-ahead transaction or started by a <c>CardAcquisition</c>, and not followed by a service request from the Sale System to complete the transaction.
/// Possible values:
/// * <b>StartTransaction</b>
/// * <b>AbortTransaction</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionAction>))]
public sealed record TransactionAction : StringEnum<TransactionAction>
{
    private TransactionAction(string value) : base(value)
    {
    }

    public static readonly TransactionAction StartTransaction = new("StartTransaction");

    public static readonly TransactionAction AbortTransaction = new("AbortTransaction");

    public static TransactionAction FromValue(string value) => FromValueCore(value);
}

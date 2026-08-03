using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Action to realise on a transaction. In an <c>EnableService</c> request message:
///   - Starts a transaction by a swipe-ahead mechanism, with the services which are enabled.
///   - Aborts a swipe-ahead transaction or started by a <c>CardAcquisition</c>, and not followed by a service request from the Sale System to complete the transaction.
/// Possible values:
/// * <b>AbortTransaction</b>
/// * <b>StartTransaction</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionAction1>))]
public sealed record TransactionAction1 : StringEnum<TransactionAction1>
{
    private TransactionAction1(string value) : base(value)
    {
    }

    public static readonly TransactionAction1 StartTransaction = new("StartTransaction");

    public static readonly TransactionAction1 AbortTransaction = new("AbortTransaction");

    public static TransactionAction1 FromValue(string value) => FromValueCore(value);
}

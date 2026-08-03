using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identify the type of the transaction being authenticated.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType>))]
public sealed record TransactionType : StringEnum<TransactionType>
{
    private TransactionType(string value) : base(value)
    {
    }

    public static readonly TransactionType GoodsOrServicePurchase = new("goodsOrServicePurchase");

    public static readonly TransactionType CheckAcceptance = new("checkAcceptance");

    public static readonly TransactionType AccountFunding = new("accountFunding");

    public static readonly TransactionType QuasiCashTransaction = new("quasiCashTransaction");

    public static readonly TransactionType PrepaidActivationAndLoad = new("prepaidActivationAndLoad");

    public static TransactionType FromValue(string value) => FromValueCore(value);
}

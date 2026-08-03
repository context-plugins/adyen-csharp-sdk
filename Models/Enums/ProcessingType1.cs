using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Contains information about how the payment was processed.
/// <para>
/// Possible values: <b>atmWithdraw</b>, <b>balanceInquiry</b>, <b>ecommerce</b>, <b>moto</b>, <b>pos</b>, <b>purchaseWithCashback</b>, <b>recurring</b>, <b>token</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProcessingType1>))]
public sealed record ProcessingType1 : StringEnum<ProcessingType1>
{
    private ProcessingType1(string value) : base(value)
    {
    }

    public static readonly ProcessingType1 AtmWithdraw = new("atmWithdraw");

    public static readonly ProcessingType1 BalanceInquiry = new("balanceInquiry");

    public static readonly ProcessingType1 Ecommerce = new("ecommerce");

    public static readonly ProcessingType1 Moto = new("moto");

    public static readonly ProcessingType1 Pos = new("pos");

    public static readonly ProcessingType1 PurchaseWithCashback = new("purchaseWithCashback");

    public static readonly ProcessingType1 Recurring = new("recurring");

    public static readonly ProcessingType1 Token = new("token");

    public static ProcessingType1 FromValue(string value) => FromValueCore(value);
}

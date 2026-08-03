using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the cashout transfer.
/// <para>
/// Possible values:
/// - <b>cashoutRepayment</b>: Corresponds to the transfer created to deduct the cashout amount after settlement.
/// - <b>cashoutFee</b>: Corresponds to the transfer created to debit the cashout fee form the user's balance account.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type122>))]
public sealed record Type122 : StringEnum<Type122>
{
    private Type122(string value) : base(value)
    {
    }

    public static readonly Type122 CashoutRepayment = new("cashoutRepayment");

    public static readonly Type122 CashoutFee = new("cashoutFee");

    public static Type122 FromValue(string value) => FromValueCore(value);
}

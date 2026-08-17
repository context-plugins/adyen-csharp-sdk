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
[JsonConverter(typeof(StringEnumConverter<Type121>))]
public sealed record Type121 : StringEnum<Type121>
{
    private Type121(string value) : base(value)
    {
    }

    public static readonly Type121 CashoutRepayment = new("cashoutRepayment");

    public static readonly Type121 CashoutFee = new("cashoutFee");

    public static Type121 FromValue(string value) => FromValueCore(value);
}

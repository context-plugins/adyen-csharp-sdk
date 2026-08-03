using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of balance transfer. Possible values: <b>tax</b>, <b>fee</b>, <b>terminalSale</b>, <b>credit</b>, <b>debit</b>, and <b>adjustment</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BalanceTransferType2>))]
public sealed record BalanceTransferType2 : StringEnum<BalanceTransferType2>
{
    private BalanceTransferType2(string value) : base(value)
    {
    }

    public static readonly BalanceTransferType2 Tax = new("tax");

    public static readonly BalanceTransferType2 Fee = new("fee");

    public static readonly BalanceTransferType2 TerminalSale = new("terminalSale");

    public static readonly BalanceTransferType2 Credit = new("credit");

    public static readonly BalanceTransferType2 Debit = new("debit");

    public static readonly BalanceTransferType2 Adjustment = new("adjustment");

    public static BalanceTransferType2 FromValue(string value) => FromValueCore(value);
}

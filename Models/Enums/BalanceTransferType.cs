using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<BalanceTransferType>))]
public sealed record BalanceTransferType : StringEnum<BalanceTransferType>
{
    private BalanceTransferType(string value) : base(value)
    {
    }

    public static readonly BalanceTransferType Tax = new("tax");

    public static readonly BalanceTransferType Fee = new("fee");

    public static readonly BalanceTransferType TerminalSale = new("terminalSale");

    public static readonly BalanceTransferType Credit = new("credit");

    public static readonly BalanceTransferType Debit = new("debit");

    public static readonly BalanceTransferType Adjustment = new("adjustment");

    public static BalanceTransferType FromValue(string value) => FromValueCore(value);
}

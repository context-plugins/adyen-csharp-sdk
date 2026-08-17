using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates where the funds used for the transfer originated. Possible values are:
/// - <b>DEBIT</b> for card-to-card transfers.
/// - <b>DEPOSIT_ACCOUNT</b> for wallet-to-card transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SourceOfFunds>))]
public sealed record SourceOfFunds : StringEnum<SourceOfFunds>
{
    private SourceOfFunds(string value) : base(value)
    {
    }

    public static readonly SourceOfFunds Debit = new("DEBIT");

    public static readonly SourceOfFunds DepositAccount = new("DEPOSIT_ACCOUNT");

    public static SourceOfFunds FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates where the funds used for the transfer originated. Possible values are:
/// - <b>DEBIT</b> for card-to-card transfers.
/// - <b>DEPOSIT_ACCOUNT</b> for wallet-to-card transfers.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SourceOfFunds2>))]
public sealed record SourceOfFunds2 : StringEnum<SourceOfFunds2>
{
    private SourceOfFunds2(string value) : base(value)
    {
    }

    public static readonly SourceOfFunds2 Debit = new("DEBIT");

    public static readonly SourceOfFunds2 DepositAccount = new("DEPOSIT_ACCOUNT");

    public static SourceOfFunds2 FromValue(string value) => FromValueCore(value);
}

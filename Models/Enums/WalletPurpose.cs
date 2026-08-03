using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The purpose of a digital wallet transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletPurpose>))]
public sealed record WalletPurpose : StringEnum<WalletPurpose>
{
    private WalletPurpose(string value) : base(value)
    {
    }

    public static readonly WalletPurpose IdentifiedBoleto = new("identifiedBoleto");

    public static readonly WalletPurpose TransferDifferentWallet = new("transferDifferentWallet");

    public static readonly WalletPurpose TransferOwnWallet = new("transferOwnWallet");

    public static readonly WalletPurpose TransferSameWallet = new("transferSameWallet");

    public static readonly WalletPurpose UnidentifiedBoleto = new("unidentifiedBoleto");

    public static WalletPurpose FromValue(string value) => FromValueCore(value);
}

using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The purpose of a digital wallet transaction.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WalletPurpose>))]
public sealed record WalletPurpose : OpenStringEnum<WalletPurpose>
{
    private WalletPurpose(string value) : base(value)
    {
    }

    public static readonly WalletPurpose IdentifiedBoleto = new("identifiedBoleto");

    public static readonly WalletPurpose TransferDifferentWallet = new("transferDifferentWallet");

    public static readonly WalletPurpose TransferOwnWallet = new("transferOwnWallet");

    public static readonly WalletPurpose TransferSameWallet = new("transferSameWallet");

    public static readonly WalletPurpose UnidentifiedBoleto = new("unidentifiedBoleto");

    public TResult Match<TResult>(Func<TResult> onIdentifiedBoleto,
        Func<TResult> onTransferDifferentWallet,
        Func<TResult> onTransferOwnWallet,
        Func<TResult> onTransferSameWallet,
        Func<TResult> onUnidentifiedBoleto,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == IdentifiedBoleto => onIdentifiedBoleto(),
            _ when this == TransferDifferentWallet => onTransferDifferentWallet(),
            _ when this == TransferOwnWallet => onTransferOwnWallet(),
            _ when this == TransferSameWallet => onTransferSameWallet(),
            _ when this == UnidentifiedBoleto => onUnidentifiedBoleto(),
            _ => otherwise(Value)
        };

    public void Match(Action onIdentifiedBoleto,
        Action onTransferDifferentWallet,
        Action onTransferOwnWallet,
        Action onTransferSameWallet,
        Action onUnidentifiedBoleto,
        Action<string> otherwise)
    {
        if (this == IdentifiedBoleto) onIdentifiedBoleto();
        else if (this == TransferDifferentWallet) onTransferDifferentWallet();
        else if (this == TransferOwnWallet) onTransferOwnWallet();
        else if (this == TransferSameWallet) onTransferSameWallet();
        else if (this == UnidentifiedBoleto) onUnidentifiedBoleto();
        else otherwise(Value);
    }
}

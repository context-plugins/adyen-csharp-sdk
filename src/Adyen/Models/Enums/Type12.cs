using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>billdesk</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : OpenStringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 BilldeskOnline = new("billdesk_online");

    public static readonly Type12 BilldeskWallet = new("billdesk_wallet");

    public TResult Match<TResult>(Func<TResult> onBilldeskOnline,
        Func<TResult> onBilldeskWallet,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BilldeskOnline => onBilldeskOnline(),
            _ when this == BilldeskWallet => onBilldeskWallet(),
            _ => otherwise(Value)
        };

    public void Match(Action onBilldeskOnline, Action onBilldeskWallet, Action<string> otherwise)
    {
        if (this == BilldeskOnline) onBilldeskOnline();
        else if (this == BilldeskWallet) onBilldeskWallet();
        else otherwise(Value);
    }
}

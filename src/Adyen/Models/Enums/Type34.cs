using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>klarna</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type34>))]
public sealed record Type34 : OpenStringEnum<Type34>
{
    private Type34(string value) : base(value)
    {
    }

    public static readonly Type34 Klarna = new("klarna");

    public static readonly Type34 Klarnapayments = new("klarnapayments");

    public static readonly Type34 KlarnapaymentsAccount = new("klarnapayments_account");

    public static readonly Type34 KlarnapaymentsB2B = new("klarnapayments_b2b");

    public static readonly Type34 KlarnaPaynow = new("klarna_paynow");

    public static readonly Type34 KlarnaAccount = new("klarna_account");

    public static readonly Type34 KlarnaB2B = new("klarna_b2b");

    public TResult Match<TResult>(Func<TResult> onKlarna,
        Func<TResult> onKlarnapayments,
        Func<TResult> onKlarnapaymentsAccount,
        Func<TResult> onKlarnapaymentsB2B,
        Func<TResult> onKlarnaPaynow,
        Func<TResult> onKlarnaAccount,
        Func<TResult> onKlarnaB2B,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Klarna => onKlarna(),
            _ when this == Klarnapayments => onKlarnapayments(),
            _ when this == KlarnapaymentsAccount => onKlarnapaymentsAccount(),
            _ when this == KlarnapaymentsB2B => onKlarnapaymentsB2B(),
            _ when this == KlarnaPaynow => onKlarnaPaynow(),
            _ when this == KlarnaAccount => onKlarnaAccount(),
            _ when this == KlarnaB2B => onKlarnaB2B(),
            _ => otherwise(Value)
        };

    public void Match(Action onKlarna,
        Action onKlarnapayments,
        Action onKlarnapaymentsAccount,
        Action onKlarnapaymentsB2B,
        Action onKlarnaPaynow,
        Action onKlarnaAccount,
        Action onKlarnaB2B,
        Action<string> otherwise)
    {
        if (this == Klarna) onKlarna();
        else if (this == Klarnapayments) onKlarnapayments();
        else if (this == KlarnapaymentsAccount) onKlarnapaymentsAccount();
        else if (this == KlarnapaymentsB2B) onKlarnapaymentsB2B();
        else if (this == KlarnaPaynow) onKlarnaPaynow();
        else if (this == KlarnaAccount) onKlarnaAccount();
        else if (this == KlarnaB2B) onKlarnaB2B();
        else otherwise(Value);
    }
}

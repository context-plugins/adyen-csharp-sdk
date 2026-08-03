using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>klarna</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type34>))]
public sealed record Type34 : StringEnum<Type34>
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

    public static Type34 FromValue(string value) => FromValueCore(value);
}

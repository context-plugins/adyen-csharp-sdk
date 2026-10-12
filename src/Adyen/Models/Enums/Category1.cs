using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer that results from the sweep.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>bank</b>: Sweep to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id">transfer instrument</see>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>internal</b>: Transfer to another <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/post/balanceAccounts__resParam_id">balance account</see> within your platform.</description></item>
/// </list>
/// <para>
/// Required when setting <c>priorities</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Category1>))]
public sealed record Category1 : OpenStringEnum<Category1>
{
    private Category1(string value) : base(value)
    {
    }

    public static readonly Category1 Bank = new("bank");

    public static readonly Category1 Internal = new("internal");

    public static readonly Category1 PlatformPayment = new("platformPayment");

    public TResult Match<TResult>(Func<TResult> onBank,
        Func<TResult> onInternal,
        Func<TResult> onPlatformPayment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Bank => onBank(),
            _ when this == Internal => onInternal(),
            _ when this == PlatformPayment => onPlatformPayment(),
            _ => otherwise(Value)
        };

    public void Match(Action onBank, Action onInternal, Action onPlatformPayment, Action<string> otherwise)
    {
        if (this == Bank) onBank();
        else if (this == Internal) onInternal();
        else if (this == PlatformPayment) onPlatformPayment();
        else otherwise(Value);
    }
}

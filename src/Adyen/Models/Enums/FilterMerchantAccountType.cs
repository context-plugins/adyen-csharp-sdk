using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Shows how merchant accounts are filtered when configuring the webhook.
/// <para>
/// Possible values:
/// *  <b>allAccounts</b> : Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
/// *  <b>includeAccounts</b> : The webhook is configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
/// *  <b>excludeAccounts</b> : The webhook is not configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilterMerchantAccountType>))]
public sealed record FilterMerchantAccountType : OpenStringEnum<FilterMerchantAccountType>
{
    private FilterMerchantAccountType(string value) : base(value)
    {
    }

    public static readonly FilterMerchantAccountType AllAccounts = new("allAccounts");

    public static readonly FilterMerchantAccountType ExcludeAccounts = new("excludeAccounts");

    public static readonly FilterMerchantAccountType IncludeAccounts = new("includeAccounts");

    public TResult Match<TResult>(Func<TResult> onAllAccounts,
        Func<TResult> onExcludeAccounts,
        Func<TResult> onIncludeAccounts,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AllAccounts => onAllAccounts(),
            _ when this == ExcludeAccounts => onExcludeAccounts(),
            _ when this == IncludeAccounts => onIncludeAccounts(),
            _ => otherwise(Value)
        };

    public void Match(Action onAllAccounts,
        Action onExcludeAccounts,
        Action onIncludeAccounts,
        Action<string> otherwise)
    {
        if (this == AllAccounts) onAllAccounts();
        else if (this == ExcludeAccounts) onExcludeAccounts();
        else if (this == IncludeAccounts) onIncludeAccounts();
        else otherwise(Value);
    }
}

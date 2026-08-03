using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Shows how merchant accounts are filtered when configuring the webhook. Possible values:
/// * <b>includeAccounts</b>: The webhook is configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
/// * <b>excludeAccounts</b>: The webhook is not configured for the merchant accounts listed in <c>filterMerchantAccounts</c>.
/// * <b>allAccounts</b>: Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilterMerchantAccountType2>))]
public sealed record FilterMerchantAccountType2 : StringEnum<FilterMerchantAccountType2>
{
    private FilterMerchantAccountType2(string value) : base(value)
    {
    }

    public static readonly FilterMerchantAccountType2 AllAccounts = new("allAccounts");

    public static readonly FilterMerchantAccountType2 ExcludeAccounts = new("excludeAccounts");

    public static readonly FilterMerchantAccountType2 IncludeAccounts = new("includeAccounts");

    public static FilterMerchantAccountType2 FromValue(string value) => FromValueCore(value);
}

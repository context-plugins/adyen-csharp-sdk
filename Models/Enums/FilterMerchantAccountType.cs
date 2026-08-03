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
public sealed record FilterMerchantAccountType : StringEnum<FilterMerchantAccountType>
{
    private FilterMerchantAccountType(string value) : base(value)
    {
    }

    public static readonly FilterMerchantAccountType AllAccounts = new("allAccounts");

    public static readonly FilterMerchantAccountType ExcludeAccounts = new("excludeAccounts");

    public static readonly FilterMerchantAccountType IncludeAccounts = new("includeAccounts");

    public static FilterMerchantAccountType FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Shows how merchant accounts are included in company-level webhooks. Possible values:
/// * <b>includeAccounts</b>
/// * <b>excludeAccounts</b>
/// * <b>allAccounts</b>: Includes all merchant accounts, and does not require specifying <c>filterMerchantAccounts</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FilterMerchantAccountType1>))]
public sealed record FilterMerchantAccountType1 : StringEnum<FilterMerchantAccountType1>
{
    private FilterMerchantAccountType1(string value) : base(value)
    {
    }

    public static readonly FilterMerchantAccountType1 AllAccounts = new("allAccounts");

    public static readonly FilterMerchantAccountType1 ExcludeAccounts = new("excludeAccounts");

    public static readonly FilterMerchantAccountType1 IncludeAccounts = new("includeAccounts");

    public static FilterMerchantAccountType1 FromValue(string value) => FromValueCore(value);
}

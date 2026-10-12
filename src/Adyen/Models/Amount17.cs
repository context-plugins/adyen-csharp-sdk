using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

/// <summary>
/// The amount of the transfer., The amount that must be pushed out or pulled in. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both., The amount that must be available in the balance account after the sweep. You can configure either <c>sweepAmount</c> or <c>targetAmount</c>, not both., The threshold amount that triggers the sweep. If not provided, by default, the amount is set to zero. The <c>triggerAmount</c> is evaluated according to the specified <c>schedule.type</c>.
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>pull</b>, if the balance is less than or equal to the <c>triggerAmount</c>, funds are pulled in to the balance account.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>push</b>, if the balance is more than or equal to the <c>triggerAmount</c>, funds are pushed out of the balance account., The amount available on the grant account., Contains the fee amount., The principal amount of the grant., The amount to be repaid on a 30-day basis., The amount value and currency., The amount for the transfer limit. This is the maximum amount allowed per transfer or per day based on the <c>scope</c> of the limit., The fixed amount with which you want to top up the balance account., The target balance for the balance account that the top-up must achieve., The balance threshold that triggers the top-up. If the balance falls below this amount, a top-up is initiated., The adjustment amount., An object containing the amount of the grant, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>., Contains the fee amount., The amount to be repaid on a 30-day basis., The amount of the transfer., The original journal amount. Only applicable for <see href="https://docs.adyen.com/issuing/">issuing</see> integrations., The currency and value of the adjusted interchange fee., The amount in the original currency. Only applicable for <see href="https://docs.adyen.com/issuing/">issuing</see> integrations., Contains information about the amount to be returned., Contains information about the amount of the transaction., Contains the amount of the cashout, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>., The amount of the cashout instruction transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>., The financing amount that the user selected from a dynamic offer. Adyen uses this amount to calculate a preliminary offer., The financing amount that would be paid out to your user., Contains the amount of the offer fee., The minimum threshold amount that your user must repay on every 30-day period., The financing amount that the user selected from the dynamic offer. Adyen uses this amount to create a static offer., Contains information about the amount of the disbursement., Contains the amount of the grant fee., The maximum financing amount available to the account holder under this offer., The minimum financing amount available to the account holder under this offer., The limit amount of the grant account., The amount that would be paid out to the user for business financing., The amount for which you dispute the transaction. The disputed amount cannot be greater than the transaction amount. If you do not provide an amount, the entire transaction amount will be disputed.</description></item>
/// </list>
/// </summary>
public record Amount17
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes#currency-codes">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The amount of the transaction, in <see href="https://docs.adyen.com/development-resources/currency-codes#minor-units">minor units</see>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

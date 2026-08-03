using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Defines how to book chargebacks when using <see href="https://docs.adyen.com/adyen-for-platforms-model">Adyen for Platforms</see>.
/// </summary>
public record PlatformChargebackLogic
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("behavior")]
    public Behavior? Behavior { get; init; }

    /// <summary>
    /// The unique identifier of the balance account to which the chargeback fees are booked. By default, the chargeback fees are booked to your liable balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("costAllocationAccount")]
    public string? CostAllocationAccount { get; init; }

    /// <summary>
    /// The unique identifier of the balance account against which the disputed amount is booked.
    /// <para>
    /// Required if <c>behavior</c> is <b>deductFromOneBalanceAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("targetAccount")]
    public string? TargetAccount { get; init; }
}

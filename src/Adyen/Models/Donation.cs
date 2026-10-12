using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Donation
{
    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes/">ISO currency code</see>.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/donations/#donation-types">type of donation</see>.
    /// <para>
    /// Possible values:
    /// * <b>roundup</b>: a donation where the original transaction amount is rounded up as a donation.
    /// * <b>fixedAmounts</b>: a donation where you show fixed donations amounts that the shopper can select from.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("donationType")]
    public string? DonationType { get; init; }

    /// <summary>
    /// The maximum amount a transaction can be rounded up to make a donation. This field is only present when <c>donationType</c> is <b>roundup</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxRoundupAmount")]
    public long? MaxRoundupAmount { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/donations/#donation-types">type of donation</see>.
    /// <para>
    /// Possible values:
    /// * <b>roundup</b>: a donation where the original transaction amount is rounded up as a donation.
    /// * <b>fixedAmounts</b>: a donation where you show fixed donation amounts that the shopper can select from.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// The fixed donation amounts in <see href="https://docs.adyen.com/development-resources/currency-codes//#minor-units">minor units</see>. This field is only present when <c>donationType</c> is <b>fixedAmounts</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("values")]
    public IReadOnlyList<long>? Values { get; init; }
}

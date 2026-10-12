namespace Adyen.Requests.ManagedPayoutSchedules;

/// <summary>
/// The inputs of the GetBalancePlatformsBalancePlatformIdPayoutSchedules operation.
/// </summary>
public sealed record GetBalancePlatformsBalancePlatformIdPayoutSchedulesRequest
{
    /// <summary>
    /// The unique identifier of the balance platform.
    /// </summary>
    public required string BalancePlatformId { get; init; }

    /// <summary>
    /// The two-letter <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> country code of the country to which the payout configuration applies.
    /// </summary>
    public string? CountryCode { get; init; }

    /// <summary>
    /// The three-character <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see> of the currency used in the payout configuration.
    /// </summary>
    public string? Currency { get; init; }
}

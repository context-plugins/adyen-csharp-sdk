using System.ComponentModel.DataAnnotations;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Requests.PaymentsApp;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdStoresStoreIdPaymentsApps operation.
/// </summary>
public sealed record GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    [MinLength(1)]
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    [MinLength(1)]
    public required string StoreId { get; init; }

    /// <summary>
    /// The status of the Payments App. Comma-separated list of one or more values. If no value is provided, the list returns all statuses.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>BOARDING</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>BOARDED</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>REVOKED</b></description></item>
    /// </list>
    /// </summary>
    public string? Statuses { get; init; }

    /// <summary>
    /// The number of items to return.
    /// </summary>
    [Maximum(100)]
    public int Limit { get; init; } = 10;

    /// <summary>
    /// The number of items to skip.
    /// </summary>
    public long Offset { get; init; } = 0L;
}

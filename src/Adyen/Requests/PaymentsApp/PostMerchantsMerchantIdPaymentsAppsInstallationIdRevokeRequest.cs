using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.PaymentsApp;

/// <summary>
/// The inputs of the PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke operation.
/// </summary>
public sealed record PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    [MinLength(1)]
    public required string MerchantId { get; init; }

    /// <summary>
    /// The unique identifier of the Payments App instance on a device.
    /// </summary>
    [MinLength(1)]
    public required string InstallationId { get; init; }
}

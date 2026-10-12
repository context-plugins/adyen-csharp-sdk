using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdStoresReferenceTerminalSettings operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdStoresReferenceTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The reference that identifies the store.
    /// </summary>
    public required string Reference { get; init; }

    public TerminalSettings? Body { get; init; }
}

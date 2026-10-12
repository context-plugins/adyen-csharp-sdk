using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the PatchStoresStoreIdTerminalSettings operation.
/// </summary>
public sealed record PatchStoresStoreIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }

    public TerminalSettings? Body { get; init; }
}

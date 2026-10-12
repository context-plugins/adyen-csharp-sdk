namespace Adyen.Requests.TerminalSettingsStoreLevel;

/// <summary>
/// The inputs of the GetStoresStoreIdTerminalSettings operation.
/// </summary>
public sealed record GetStoresStoreIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the store.
    /// </summary>
    public required string StoreId { get; init; }
}

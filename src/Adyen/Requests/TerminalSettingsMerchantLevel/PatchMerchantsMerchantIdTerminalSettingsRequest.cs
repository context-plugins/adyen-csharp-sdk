using Adyen.Models;

namespace Adyen.Requests.TerminalSettingsMerchantLevel;

/// <summary>
/// The inputs of the PatchMerchantsMerchantIdTerminalSettings operation.
/// </summary>
public sealed record PatchMerchantsMerchantIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    public TerminalSettings? Body { get; init; }
}

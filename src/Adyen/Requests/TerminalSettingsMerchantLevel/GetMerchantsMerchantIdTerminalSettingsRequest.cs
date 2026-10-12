namespace Adyen.Requests.TerminalSettingsMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdTerminalSettings operation.
/// </summary>
public sealed record GetMerchantsMerchantIdTerminalSettingsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}

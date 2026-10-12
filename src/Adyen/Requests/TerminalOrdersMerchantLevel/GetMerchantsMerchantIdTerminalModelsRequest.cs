namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdTerminalModels operation.
/// </summary>
public sealed record GetMerchantsMerchantIdTerminalModelsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }
}

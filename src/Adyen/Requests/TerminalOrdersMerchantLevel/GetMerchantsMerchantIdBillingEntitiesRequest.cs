namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdBillingEntities operation.
/// </summary>
public sealed record GetMerchantsMerchantIdBillingEntitiesRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The name of the billing entity.
    /// </summary>
    public string? Name { get; init; }
}

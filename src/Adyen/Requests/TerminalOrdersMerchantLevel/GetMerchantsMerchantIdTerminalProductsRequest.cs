namespace Adyen.Requests.TerminalOrdersMerchantLevel;

/// <summary>
/// The inputs of the GetMerchantsMerchantIdTerminalProducts operation.
/// </summary>
public sealed record GetMerchantsMerchantIdTerminalProductsRequest
{
    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    public required string MerchantId { get; init; }

    /// <summary>
    /// The country to return products for, in <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> format. For example, <b>US</b>
    /// </summary>
    public required string Country { get; init; }

    /// <summary>
    /// The terminal model to return products for. Use the ID returned in the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/merchants/{merchantId}/terminalModels">GET <c>/terminalModels</c></see> response. For example, <b>Verifone.M400</b>
    /// </summary>
    public string? TerminalModelId { get; init; }

    /// <summary>
    /// The number of products to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of products to return.
    /// </summary>
    public int? Limit { get; init; }
}

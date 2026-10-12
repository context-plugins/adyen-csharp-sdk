namespace Adyen.Requests.TerminalsTerminalLevel;

/// <summary>
/// The inputs of the GetTerminals operation.
/// </summary>
public sealed record GetTerminalsRequest
{
    /// <summary>
    /// Returns terminals with an ID that contains the specified string. If present, other query parameters are ignored.
    /// </summary>
    public string? SearchQuery { get; init; }

    /// <summary>
    /// Returns one or more terminals associated with the one-time passwords specified in the request. If this query parameter is used, other query parameters are ignored.
    /// </summary>
    public string? OtpQuery { get; init; }

    /// <summary>
    /// Returns terminals located in the countries specified by their <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">two-letter country code</see>.
    /// </summary>
    public string? Countries { get; init; }

    /// <summary>
    /// Returns terminals that belong to the merchant accounts specified by their unique merchant account ID.
    /// </summary>
    public string? MerchantIds { get; init; }

    /// <summary>
    /// Returns terminals that are assigned to the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/stores">stores</see> specified by their unique store ID.
    /// </summary>
    public string? StoreIds { get; init; }

    /// <summary>
    /// Returns terminals of the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/latest/get/companies/{companyId}/terminalModels">models</see> specified in the format *brand.model*.
    /// </summary>
    public string? BrandModels { get; init; }

    /// <summary>
    /// The number of the page to fetch.
    /// </summary>
    public int? PageNumber { get; init; }

    /// <summary>
    /// The number of items to have on a page, maximum 100. The default is 20 items on a page.
    /// </summary>
    public int? PageSize { get; init; }
}

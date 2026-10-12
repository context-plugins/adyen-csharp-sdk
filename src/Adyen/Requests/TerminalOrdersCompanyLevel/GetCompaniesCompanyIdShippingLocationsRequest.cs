namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdShippingLocations operation.
/// </summary>
public sealed record GetCompaniesCompanyIdShippingLocationsRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The name of the shipping location.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// The number of locations to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of locations to return.
    /// </summary>
    public int? Limit { get; init; }
}

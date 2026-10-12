namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalOrdersOrderId operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalOrdersOrderIdRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// The unique identifier of the order.
    /// </summary>
    public required string OrderId { get; init; }
}

namespace Adyen.Requests.TerminalOrdersCompanyLevel;

/// <summary>
/// The inputs of the GetCompaniesCompanyIdTerminalOrders operation.
/// </summary>
public sealed record GetCompaniesCompanyIdTerminalOrdersRequest
{
    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    public required string CompanyId { get; init; }

    /// <summary>
    /// Your purchase order number.
    /// </summary>
    public string? CustomerOrderReference { get; init; }

    /// <summary>
    /// The order status. Possible values (not case-sensitive): Placed, Confirmed, Cancelled, Shipped, Delivered.
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// The number of orders to skip.
    /// </summary>
    public int? Offset { get; init; }

    /// <summary>
    /// The number of orders to return.
    /// </summary>
    public int? Limit { get; init; }
}

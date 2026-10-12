using Adyen.Models.Enums;

namespace Adyen.Requests.AccountHolders;

/// <summary>
/// The inputs of the GetAccountHoldersIdTaxForms operation.
/// </summary>
public sealed record GetAccountHoldersIdTaxFormsRequest
{
    /// <summary>
    /// The unique identifier of the account holder.
    /// </summary>
    public required string Id { get; init; }

    /// <summary>
    /// The type of tax form you want to retrieve. Accepted values are <b>US1099k</b> and <b>US1099nec</b>.
    /// </summary>
    public required FormType FormType { get; init; }

    /// <summary>
    /// The tax year in <b>YYYY</b> format for the tax form you want to retrieve.
    /// </summary>
    public required int Year { get; init; }

    /// <summary>
    /// The legal entity reference whose tax form you want to retrieve.
    /// </summary>
    public string? LegalEntityId { get; init; }
}

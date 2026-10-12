using System;
using Adyen.Models.Enums;

namespace Adyen.Requests.Transactions;

/// <summary>
/// The inputs of the GetTransactions operation.
/// </summary>
public sealed record GetTransactionsRequest
{
    /// <summary>
    /// Only include transactions that have been created on or after this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public required DateTimeOffset CreatedSince { get; init; }

    /// <summary>
    /// Only include transactions that have been created on or before this point in time. The value must be in ISO 8601 format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public required DateTimeOffset CreatedUntil { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balancePlatforms/{id}__queryParam_id">balance platform</see>.
    /// <para>
    /// Required if you don't provide a <c>balanceAccountId</c> or <c>accountHolderId</c>.
    /// </para>
    /// </summary>
    public string? BalancePlatform { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/get/paymentInstruments/_id_">payment instrument</see>.
    /// <para>
    /// To use this parameter, you must also provide a <c>balanceAccountId</c>, <c>accountHolderId</c>, or <c>balancePlatform</c>.
    /// </para>
    /// <para>
    /// The <c>paymentInstrumentId</c> must be related to the <c>balanceAccountId</c> or <c>accountHolderId</c> that you provide.
    /// </para>
    /// </summary>
    public string? PaymentInstrumentId { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/accountHolders/{id}__queryParam_id">account holder</see>.
    /// <para>
    /// Required if you don't provide a <c>balanceAccountId</c> or <c>balancePlatform</c>.
    /// </para>
    /// <para>
    /// If you provide a <c>balanceAccountId</c>, the <c>accountHolderId</c> must be related to the <c>balanceAccountId</c>.
    /// </para>
    /// </summary>
    public string? AccountHolderId { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/balanceplatform/latest/get/balanceAccounts/{id}__queryParam_id">balance account</see>.
    /// <para>
    /// Required if you don't provide an <c>accountHolderId</c> or <c>balancePlatform</c>.
    /// </para>
    /// <para>
    /// If you provide an <c>accountHolderId</c>, the <c>balanceAccountId</c> must be related to the <c>accountHolderId</c>.
    /// </para>
    /// </summary>
    public string? BalanceAccountId { get; init; }

    /// <summary>
    /// The <c>cursor</c> returned in the links of the previous response.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>asc</b>: Ascending order, from oldest to most recent.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>desc</b>: Descending order, from most recent to oldest.</description></item>
    /// </list>
    /// <para>
    /// Default value: <b>asc</b>.
    /// </para>
    /// </summary>
    public SortOrder? SortOrder { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }
}

using System;
using Adyen.Models.Enums;

namespace Adyen.Requests.Transfers;

/// <summary>
/// The inputs of the GetTransfers operation.
/// </summary>
public sealed record GetTransfersRequest
{
    /// <summary>
    /// Only include transfers that have been created on or after this point in time. The value must be in ISO 8601 format and not earlier than 6 months before the <c>createdUntil</c> date. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public required DateTimeOffset CreatedSince { get; init; }

    /// <summary>
    /// Only include transfers that have been created on or before this point in time. The value must be in ISO 8601 format and not later than 6 months after the <c>createdSince</c> date. For example, <b>2021-05-30T15:07:40Z</b>.
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
    /// The reference you provided in the POST <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers">/transfers</see> request
    /// </summary>
    public string? Reference { get; init; }

    /// <summary>
    /// The category of the transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>bank</b>: A transfer involving a <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/transferInstruments#responses-200-id">transfer instrument</see> or a bank account.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>card</b>: A transfer involving a third-party card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>internal</b>: A transfer between <see href="https://docs.adyen.com/api-explorer/balanceplatform/latest/post/balanceAccounts#responses-200-id">balance accounts</see> within your platform.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>issuedCard</b>: A transfer initiated by an Adyen-issued card.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>platformPayment</b>: Funds movements related to payments that are acquired for your users.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>topUp</b>: An incoming transfer initiated by your user to top up their balance account.</description></item>
    /// </list>
    /// </summary>
    public Category2? Category { get; init; }

    /// <summary>
    /// Determines the sort order of the returned transfers. The sort order is based on the creation date of the transfers.
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
    /// The <c>cursor</c> returned in the links of the previous response.
    /// </summary>
    public string? Cursor { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum of 100 items. By default, the response returns 10 items per page.
    /// </summary>
    public int? Limit { get; init; }
}

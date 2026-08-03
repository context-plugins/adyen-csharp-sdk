using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Contains information about the source of your user's funds. Required only if the <c>service</c> is <b>banking</b> or <b>issuing</b>.
/// </summary>
public record SourceOfFunds1
{
    /// <summary>
    /// Indicates whether the funds are coming from transactions processed by Adyen. If <b>false</b>, the <c>type</c> is required.
    /// </summary>
    [JsonPropertyName("adyenProcessedFunds")]
    public required bool AdyenProcessedFunds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount64? Amount { get; init; }

    /// <summary>
    /// The number of months that the asset has been in possession of the user.
    /// <para>
    /// For example, if the source of funds is of type <b>cryptocurrencyIncome</b> then <c>assetMonthsHeld</c> is the number of months the user has owned the cryptocurrency.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assetMonthsHeld")]
    public int? AssetMonthsHeld { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>cryptocurrencyIncome</b>. The cryptocurrency exchange where the funds were acquired.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cryptocurrencyExchange")]
    public string? CryptocurrencyExchange { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>donations</b> or <b>inheritance</b>. The date the funds were received, in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfFundsReceived")]
    public DateTimeOffset? DateOfFundsReceived { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>assetSale</b> or <b>gamblingWinnings</b>. The date the funds were received, in YYYY-MM-DD format.
    /// <para>
    /// For example, if the source of funds is of type <b>assetSale</b>, the dateOfSourceEvent is the date of the sale. If the source of funds is of type <b>gamblingWinnings</b>, the dateOfSourceEvent is the date of winnings.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfSourceEvent")]
    public DateTimeOffset? DateOfSourceEvent { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>business</b> or <b>assetSale</b>. A description for the source of funds.
    /// <para>
    /// For example, for <c>type</c> <b>business</b>, provide a description of where the business transactions come from, such as payments through bank transfer. For <c>type</c> <b>assetSale</b>, provide a description of the asset. For example, the address of a residential property if it is a property sale.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>thirdPartyFunding</b>. Information about the financiers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("financiers")]
    public IReadOnlyList<Financier>? Financiers { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>donations</b> or <b>inheritance</b>. The legal entity ID representing the originator of the source of funds.
    /// <para>
    /// For example, if the source of funds is <b>inheritance</b>, then <c>originatorOfFundsReference</c> should be the legal entity reference of the benefactor.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("originatorLegalEntityId")]
    public string? OriginatorLegalEntityId { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>donations</b>. The reason for receiving the funds.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purpose")]
    public string? Purpose { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>donations</b> or <b>inheritance</b>. The relationship of the originator of the funds to the recipient.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relationship")]
    public string? Relationship { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type72? Type { get; init; }

    /// <summary>
    /// Required if <c>type</c> is <b>gamblingWinnings</b>. The location of the gambling site for the winnings.
    /// <para>
    /// For example, if the source of funds is online gambling, provide the website of the gambling company.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("website")]
    public string? Website { get; init; }
}

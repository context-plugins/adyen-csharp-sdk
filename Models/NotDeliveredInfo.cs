using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NotDeliveredInfo
{
    /// <summary>
    /// The delivery location specified by the cardholder. Required if <b>deliveredToWrongLocation</b> is <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("agreedDeliveryLocation")]
    [StringLength(500, MinimumLength = 0)]
    public string? AgreedDeliveryLocation { get; init; }

    /// <summary>
    /// The date the undelivered goods or services were cancelled in YYYY-MM-DD format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfCancellation")]
    public DateTimeOffset? DateOfCancellation { get; init; }

    /// <summary>
    /// Indicates goods were delivered to the wrong location.
    /// <para>
    /// Possible values: <b>true</b>, <b>false</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("deliveredToWrongLocation")]
    public bool? DeliveredToWrongLocation { get; init; }

    /// <summary>
    /// Your description of the issue for raising a dispute of <c>type</c> <b>notDelivered</b>.
    /// </summary>
    [JsonPropertyName("descriptionOfIssue")]
    [StringLength(2500, MinimumLength = 0)]
    public required string DescriptionOfIssue { get; init; }

    /// <summary>
    /// Indicates if the cardholder returned the goods to the merchant. Required if <b>isDeliveryLate</b> is <b>true</b>.
    /// <para>
    /// Possible values: <b>true</b>, <b>false</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("didCardholderReturn")]
    public bool? DidCardholderReturn { get; init; }

    /// <summary>
    /// Indicates if the goods or services were delivered late. Required if <b>whatWasNotDelivered</b> is <b>goods</b>.
    /// <para>
    /// Possible values: <b>true</b>, <b>false</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isDeliveryLate")]
    public bool? IsDeliveryLate { get; init; }

    /// <summary>
    /// Indicates if the transaction was processed by a bankrupt merchant.
    /// <para>
    /// Possible values: <b>true</b>, <b>false</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isMerchantBankrupt")]
    public bool? IsMerchantBankrupt { get; init; }

    /// <summary>
    /// Indicates if the transaction is non-fiat or non-fungible token (NFT) related.
    /// <para>
    /// Possible values: <b>true</b>, <b>false</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("isNonFiatOrNft")]
    public bool? IsNonFiatOrNft { get; init; }

    /// <summary>
    /// The date the undelivered goods or services were expected to be delivered in YYYY-MM-DD format.
    /// </summary>
    [JsonPropertyName("lastExpectedDate")]
    public required DateTimeOffset LastExpectedDate { get; init; }

    /// <summary>
    /// The type of product that you expected to receive.
    /// <para>
    /// Possible values: <b>goods</b>, <b>services</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("whatWasNotDelivered")]
    public required ProductType21 WhatWasNotDelivered { get; init; }

    /// <summary>
    /// The party that initiated the cancellation of the transaction.
    /// <para>
    /// Possible values: <b>merchant</b>, <b>cardholder</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whoCancelled")]
    public CancellingEntity1? WhoCancelled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

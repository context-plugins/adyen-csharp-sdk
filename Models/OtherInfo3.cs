using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>other</b>. Required for disputes of <c>type</c> <b>other</b>.
/// <para>
/// <b>Note:</b> The <b>other</b> dispute <c>type</c> is currently in beta testing. Do not create or submit any disputes for this dispute <c>type</c> at this time.
/// </para>
/// </summary>
public record OtherInfo3
{
    /// <summary>
    /// Your description of the issue for raising a dispute of <c>type</c> <b>other</b>.
    /// </summary>
    [JsonPropertyName("descriptionOfIssue")]
    [StringLength(2500, MinimumLength = 0)]
    public required string DescriptionOfIssue { get; init; }

    /// <summary>
    /// The specific category of <b>other</b> dispute that you are raising.
    /// <para>
    /// Possible values: <b>atmDispute</b>, <b>cancelledGoodsServices</b>, <b>cancelledRecurring</b>, <b>counterfeit</b>, <b>creditNotProcessed</b>, <b>notAsDescribed</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("subType")]
    public required SubType11 SubType { get; init; }

    /// <summary>
    /// The type of product that you purchased.
    /// <para>
    /// Possible values: <b>goods</b>, <b>services</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("whatWasPurchased")]
    public required ProductType11 WhatWasPurchased { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

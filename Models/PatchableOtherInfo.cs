using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PatchableOtherInfo
{
    /// <summary>
    /// Your description of the issue for raising a dispute of <c>type</c> <b>other</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("descriptionOfIssue")]
    [StringLength(2500, MinimumLength = 0)]
    public string? DescriptionOfIssue { get; init; }

    /// <summary>
    /// The specific category of <b>other</b> dispute that you are raising.
    /// <para>
    /// Possible values: <b>atmDispute</b>, <b>cancelledGoodsServices</b>, <b>cancelledRecurring</b>, <b>counterfeit</b>, <b>creditNotProcessed</b>, <b>notAsDescribed</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subType")]
    public SubType11? SubType { get; init; }

    /// <summary>
    /// The type of product that you purchased.
    /// <para>
    /// Possible values: <b>goods</b>, <b>services</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whatWasPurchased")]
    public ProductType11? WhatWasPurchased { get; init; }
}

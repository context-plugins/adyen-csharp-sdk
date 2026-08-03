using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Additional information for raising a dispute of <c>type</c> <b>other</b>. Required for disputes of <c>type</c> <b>other</b>
/// <para>
/// <b>Note:</b> The <b>other</b> dispute <c>type</c> is currently in beta testing. Do not create or submit any disputes for this dispute <c>type</c> at this time.
/// </para>
/// </summary>
public record OtherInfo1
{
    /// <summary>
    /// Your description of the issue for raising a dispute of <c>type</c> <b>other</b>.
    /// </summary>
    [JsonPropertyName("descriptionOfIssue")]
    [StringLength(2500, MinimumLength = 0)]
    public required string DescriptionOfIssue { get; init; }

    [JsonPropertyName("subType")]
    public required SubType11 SubType { get; init; }

    [JsonPropertyName("whatWasPurchased")]
    public required ProductType1 WhatWasPurchased { get; init; }
}

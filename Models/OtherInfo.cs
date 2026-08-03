using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record OtherInfo
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

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subType")]
    public SubType11? SubType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("whatWasPurchased")]
    public ProductType1? WhatWasPurchased { get; init; }
}

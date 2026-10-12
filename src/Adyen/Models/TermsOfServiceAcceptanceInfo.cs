using System;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TermsOfServiceAcceptanceInfo
{
    /// <summary>
    /// The unique identifier of the user that accepted the Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptedBy")]
    public string? AcceptedBy { get; init; }

    /// <summary>
    /// The unique identifier of the legal entity for which the Terms of Service are accepted.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptedFor")]
    public string? AcceptedFor { get; init; }

    /// <summary>
    /// The date when the Terms of Service were accepted, in ISO 8601 extended format. For example, 2022-12-18T10:15:30+01:00.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// An Adyen-generated reference for the accepted Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The type of Terms of Service.
    /// <para>
    /// Possible values:
    /// *  <b>adyenForPlatformsManage</b>
    /// *  <b>adyenIssuing</b>
    /// *  <b>adyenForPlatformsAdvanced</b>
    /// *  <b>adyenCapital</b>
    /// *  <b>adyenAccount</b>
    /// *  <b>adyenCard</b>
    /// *  <b>adyenFranchisee</b>
    /// *  <b>adyenPccr</b>
    /// *  <b>adyenChargeCard</b>
    /// *  <b>kycOnInvite</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type64? Type { get; init; }

    /// <summary>
    /// The expiration date for the Terms of Service acceptance, in ISO 8601 extended format. For example, 2022-12-18T00:00:00+01:00.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validTo")]
    public DateTimeOffset? ValidTo { get; init; }
}

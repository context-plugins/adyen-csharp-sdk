using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RecurringDetailsResult
{
    /// <summary>
    /// The date when the recurring details were created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("creationDate")]
    public DateTimeOffset? CreationDate { get; init; }

    /// <summary>
    /// Payment details stored for recurring payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("details")]
    public IReadOnlyList<RecurringDetailWrapper>? Details { get; init; }

    /// <summary>
    /// The most recent email for this shopper (if available).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastKnownShopperEmail")]
    public string? LastKnownShopperEmail { get; init; }

    /// <summary>
    /// The reference you use to uniquely identify the shopper (e.g. user ID or account ID).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopperReference")]
    public string? ShopperReference { get; init; }
}

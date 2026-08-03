using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// It conveys the services that will be enabled for the POI Terminal without the request of the Sale System, and a possible invitation for the Customer to start the services.
/// Content of the Enable Service Request message.
/// </summary>
public record EnableServiceRequest
{
    [JsonPropertyName("TransactionAction")]
    public required TransactionAction1 TransactionAction { get; init; }

    /// <summary>
    /// Services which are enabled before the start-up of a transaction.
    /// Mandatory if <c>TransactionAction</c> is <c>StartTransaction</c>, absent if not.
    /// Possible values:
    /// * <b>CardAcquisition</b>
    /// * <b>Loyalty</b>
    /// * <b>Payment</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ServicesEnabled")]
    public IReadOnlyList<ServicesEnabled>? ServicesEnabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput3? DisplayOutput { get; init; }
}

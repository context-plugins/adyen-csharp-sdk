using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Content of the Enable Service Request message.
/// </summary>
public record EnableServiceRequest2
{
    /// <summary>
    /// Action to realise on a transaction. In an <c>EnableService</c> request message:
    ///   - Starts a transaction by a swipe-ahead mechanism, with the services which are enabled.
    ///   - Aborts a swipe-ahead transaction or started by a <c>CardAcquisition</c>, and not followed by a service request from the Sale System to complete the transaction.
    /// Possible values:
    /// * <b>AbortTransaction</b>
    /// * <b>StartTransaction</b>
    /// </summary>
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

    /// <summary>
    /// Information to display and the way to process the display.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayOutput")]
    public DisplayOutput2? DisplayOutput { get; init; }
}

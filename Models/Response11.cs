using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Result of a message request processing.
/// </summary>
public record Response11
{
    /// <summary>
    /// Result of the processing of the message.
    /// Possible values:
    /// * <b>Failure</b>
    /// * <b>Partial</b>
    /// * <b>Success</b>
    /// </summary>
    [JsonPropertyName("Result")]
    public required Result11 Result { get; init; }

    /// <summary>
    /// Condition that has produced an error on the processing of a message request.
    /// Returned if Result is not Success.
    /// Possible values:
    /// * <b>Aborted</b>
    /// * <b>Busy</b>
    /// * <b>Cancel</b>
    /// * <b>DeviceOut</b>
    /// * <b>InProgress</b>
    /// * <b>InsertedCard</b>
    /// * <b>InvalidCard</b>
    /// * <b>LoggedOut</b>
    /// * <b>MessageFormat</b>
    /// * <b>NotAllowed</b>
    /// * <b>NotFound</b>
    /// * <b>PaymentRestriction</b>
    /// * <b>Refusal</b>
    /// * <b>UnavailableDevice</b>
    /// * <b>UnavailableService</b>
    /// * <b>UnreachableHost</b>
    /// * <b>WrongPIN</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ErrorCondition")]
    public ErrorCondition1? ErrorCondition { get; init; }

    /// <summary>
    /// Additional information related to processing status of a message request.
    /// If present, the POI logs it for further examination.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdditionalResponse")]
    [RegularExpression("^.+$")]
    public string? AdditionalResponse { get; init; }
}

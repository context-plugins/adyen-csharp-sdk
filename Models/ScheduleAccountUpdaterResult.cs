using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ScheduleAccountUpdaterResult
{
    /// <summary>
    /// Adyen's 16-character unique reference associated with the transaction. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// The result of scheduling an Account Updater. If scheduling was successful, this field returns <b>Success</b>; otherwise it contains the error message.
    /// </summary>
    [JsonPropertyName("result")]
    public required string Result { get; init; }
}

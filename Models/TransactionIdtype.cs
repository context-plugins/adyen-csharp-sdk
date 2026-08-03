using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Identification of a transaction for the Sale System or the POI System.
/// </summary>
public record TransactionIdtype
{
    /// <summary>
    /// Unique identification of a transaction to identify the transaction on
    /// the Sale System (e.g. ticket number), or the POI System.
    /// </summary>
    [JsonPropertyName("TransactionID")]
    [RegularExpression("^.+$")]
    public required string TransactionId { get; init; }

    /// <summary>
    /// Date and time of a transaction for the Sale System, the POI System or the Acquirer.
    ///  Ensures the uniqueness of a transaction and indicates the time when the event
    ///  occurs in the EventNotification message.
    /// </summary>
    [JsonPropertyName("TimeStamp")]
    public required DateTimeOffset TimeStamp { get; init; }
}

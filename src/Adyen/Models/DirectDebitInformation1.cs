using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The details of the direct debit.
/// </summary>
public record DirectDebitInformation1
{
    /// <summary>
    /// The date when the direct debit mandate was accepted by your user, in <see href="https://www.w3.org/TR/NOTE-datetime">ISO-8601</see> format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dateOfSignature")]
    public DateTimeOffset? DateOfSignature { get; init; }

    /// <summary>
    /// The date when the funds are deducted from your user's balance account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dueDate")]
    public DateTimeOffset? DueDate { get; init; }

    /// <summary>
    /// Your unique identifier for the direct debit mandate.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mandateId")]
    public string? MandateId { get; init; }

    /// <summary>
    /// Identifies the direct debit transfer's type.
    /// Possible values: <b>OneOff</b>, <b>First</b>, <b>Recurring</b>, <b>Final</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sequenceType")]
    public string? SequenceType { get; init; }
}

using System;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Ticket
{
    /// <summary>
    /// The address of the organization that issued the ticket.
    /// * minLength: 0 characters
    /// * maxLength: 16 characters
    /// * <b>additionalData key:</b> <c>airline.ticket_issue_address</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueAddress")]
    public string? IssueAddress { get; init; }

    /// <summary>
    /// The date that the ticket was issued to the passenger.
    /// * minLength: 10 characters
    /// * maxLength: 10 characters
    /// * Format <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>: yyyy-MM-dd
    /// * <b>additionalData key:</b> <c>airline.issue_date</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueDate")]
    public DateTimeOffset? IssueDate { get; init; }

    /// <summary>
    /// The ticket's unique identifier.
    /// * minLength: 1 character
    /// * maxLength: 15 characters
    /// * Must not start with a space or be all spaces.
    /// * Must not be all zeros.
    /// * <b>additionalData key:</b> <c>airline.ticket_number</c>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    public string? Number { get; init; }
}

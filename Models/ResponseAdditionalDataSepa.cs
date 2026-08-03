using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ResponseAdditionalDataSepa
{
    /// <summary>
    /// The transaction signature date.
    /// <para>
    /// Format: yyyy-MM-dd
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit.dateOfSignature")]
    public string? SepadirectdebitDateOfSignature { get; init; }

    /// <summary>
    /// Its value corresponds to the pspReference value of the transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit.mandateId")]
    public string? SepadirectdebitMandateId { get; init; }

    /// <summary>
    /// The date that the the shopper's bank account is charged.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit.sepadirectdebit.dueDate")]
    public string? SepadirectdebitSepadirectdebitDueDate { get; init; }

    /// <summary>
    /// This field can take one of the following values:
    /// * OneOff: (OOFF) Direct debit instruction to initiate exactly one direct debit transaction.
    /// <list type="bullet">
    ///   <item><description>First: (FRST) Initial/first collection in a series of direct debit instructions.</description></item>
    ///   <item><description>Recurring: (RCUR) Direct debit instruction to carry out regular direct debit transactions initiated by the creditor.</description></item>
    ///   <item><description>Final: (FNAL) Last/final collection in a series of direct debit instructions.</description></item>
    /// </list>
    /// <para>
    /// Example: OOFF
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit.sequenceType")]
    public string? SepadirectdebitSequenceType { get; init; }
}

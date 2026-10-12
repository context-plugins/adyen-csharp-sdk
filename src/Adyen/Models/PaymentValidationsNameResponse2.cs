using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Object that contains the status and outcomes of the <see href="https://docs.adyen.com/payment-methods/cards/name-validation">name validation</see>.
/// </summary>
public record PaymentValidationsNameResponse2
{
    /// <summary>
    /// Contains the raw response(s) returned by the scheme for the name validation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rawResponse")]
    public PaymentValidationsNameResultRawResponse2? RawResponse { get; init; }

    /// <summary>
    /// Contains the scheme-agnostic match values returned by Adyen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("result")]
    public PaymentValidationsNameResultResponse2? Result { get; init; }

    /// <summary>
    /// Informs you if the name validation was performed. Possible values:
    /// <para>
    /// <b>performed</b>, <b>notPerformed</b>, <b>notSupported</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status? Status { get; init; }
}

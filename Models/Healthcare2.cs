using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Healthcare auto-substantiation amounts for FSA/HSA card transactions. The amounts are used to qualify for reduced interchange rates on healthcare-eligible cards.
/// </summary>
public record Healthcare2
{
    /// <summary>
    /// The dental amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dentalValue")]
    public long? DentalValue { get; init; }

    /// <summary>
    /// The other medical amount not covered by the specific categories, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("otherMedicalValue")]
    public long? OtherMedicalValue { get; init; }

    /// <summary>
    /// The prescription/Rx amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("prescriptionValue")]
    public long? PrescriptionValue { get; init; }

    /// <summary>
    /// The total healthcare amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// </summary>
    [JsonPropertyName("totalHealthcareValue")]
    public required long TotalHealthcareValue { get; init; }

    /// <summary>
    /// The vision/optical prescription amount, in <see href="https://docs.adyen.com/development-resources/currency-codes">minor units</see>.
    /// * For example, 2000 means USD 20.00.
    /// * Encoding: Numeric
    /// * Max value: 10000000000
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visionPrescriptionValue")]
    public long? VisionPrescriptionValue { get; init; }
}

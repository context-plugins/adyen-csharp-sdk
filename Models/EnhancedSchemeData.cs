using System.Text.Json.Serialization;

namespace Adyen.Models;

public record EnhancedSchemeData
{
    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/airline/">Airline enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("airline")]
    public Airline1? Airline { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/car-rental/">Car rental enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carRental")]
    public CarRental1? CarRental { get; init; }

    /// <summary>
    /// Healthcare auto-substantiation amounts for FSA/HSA card transactions. The amounts are used to qualify for reduced interchange rates on healthcare-eligible cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("healthcare")]
    public Healthcare2? Healthcare { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/l2-l3/">Level 2 and Level 3 enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("levelTwoThree")]
    public LevelTwoThree2? LevelTwoThree { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/lodging/">Lodging enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lodging")]
    public Lodging2? Lodging { get; init; }

    /// <summary>
    /// <see href="https://docs.adyen.com/payment-methods/cards/enhanced-scheme-data/temporary-services/">Temporary services enhanced scheme data</see> that may be required for processing the transaction and/or for interchange savings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("temporaryServices")]
    public TemporaryServices2? TemporaryServices { get; init; }
}

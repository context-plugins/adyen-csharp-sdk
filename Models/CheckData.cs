using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information related to the paper check used for the transaction.
/// Allows the check information to be provided by the Sale System before requesting the payment, or stored by the Sale System after processing of the payment.
/// </summary>
public record CheckData
{
    /// <summary>
    /// Identification of the bank.
    /// Mandatory if TrackData absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BankID")]
    [RegularExpression("^.+$")]
    public string? BankId { get; init; }

    /// <summary>
    /// Identification of the customer account.
    /// Mandatory if TrackData absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AccountNumber")]
    [RegularExpression("^.+$")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// Identification of the bank check.
    /// Mandatory if TrackData absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CheckNumber")]
    [RegularExpression("^.+$")]
    public string? CheckNumber { get; init; }

    /// <summary>
    /// Magnetic track or magnetic ink characters line.
    /// Mandatory if CheckNumber absent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TrackData")]
    public TrackData1? TrackData { get; init; }

    /// <summary>
    /// Check guarantee card number.
    /// If provided by the customer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CheckCardNumber")]
    [RegularExpression("^.+$")]
    public string? CheckCardNumber { get; init; }

    /// <summary>
    /// Type of bank check.
    /// Possible values:
    /// * <b>Company</b>
    /// * <b>Personal</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TypeCode")]
    public TypeCode1? TypeCode { get; init; }

    /// <summary>
    /// Country of the bank check.
    /// Absent if country of the Sale system.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Country")]
    [RegularExpression("^[A-Z]{3,3}$")]
    public string? Country { get; init; }
}

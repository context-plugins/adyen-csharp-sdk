using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LoginRequest3
{
    /// <summary>
    /// Date and Time. In the Login request message, the Sale System gives its date and time to the POI System. In the Login response, the POI System gives its date and time to the Sale System.
    /// </summary>
    [JsonPropertyName("DateTime")]
    public required DateTimeOffset DateTime { get; init; }

    [JsonPropertyName("SaleSoftware")]
    public required SaleSoftware2 SaleSoftware { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("SaleTerminalData")]
    public SaleTerminalData3? SaleTerminalData { get; init; }

    /// <summary>
    /// Training mode.
    /// This flag indicates to the POI that the entire session will be not used to make real transaction, but is used for test of system or operator training.
    /// </summary>
    [JsonPropertyName("TrainingModeFlag")]
    public bool? TrainingModeFlag { get; init; } = false;

    /// <summary>
    /// Language of the Cashier or Operator.
    /// Default value for Device type displays.
    /// </summary>
    [JsonPropertyName("OperatorLanguage")]
    [RegularExpression("^[a-z]{2,2}$")]
    public required string OperatorLanguage { get; init; }

    /// <summary>
    /// Identification of the Cashier or Operator.
    /// Four conditions to send it:
    /// * The Sale System wants the POI to log it in the transaction log.
    /// * Because of reconciliation with total on OperatorID.
    /// * Because the POI needs it.
    /// * Acquirer or issuer need it.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("OperatorID")]
    [RegularExpression("^.+$")]
    public string? OperatorId { get; init; }

    /// <summary>
    /// Shift number.
    /// Same as OperatorID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ShiftNumber")]
    [RegularExpression("^.+$")]
    public string? ShiftNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TokenRequestedType")]
    public TokenRequestedType1? TokenRequestedType { get; init; }

    /// <summary>
    /// List of customer order open, closed or both to be sent in the response messages.
    /// Possible values:
    /// * <b>Both</b>
    /// * <b>Closed</b>
    /// * <b>Open</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CustomerOrderReq")]
    public IReadOnlyList<CustomerOrderReq>? CustomerOrderReq { get; init; }

    /// <summary>
    /// Serial number of a POI Terminal.
    /// If the login involve a POI Terminal and not the first Login to the POI System.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("POISerialNumber")]
    [RegularExpression("^.+$")]
    public string? PoiserialNumber { get; init; }
}

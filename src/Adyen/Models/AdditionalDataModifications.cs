using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataModifications
{
    /// <summary>
    /// This is the installment option selected by the shopper. It is required only if specified by the user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installmentPaymentData.selectedInstallmentOption")]
    public string? InstallmentPaymentDataSelectedInstallmentOption { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdatePaymentMethodInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelUpdateInfo? Accel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmUpdateInfo? Affirm { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public AccelUpdateInfo? Bcmc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carnet")]
    public AccelUpdateInfo? Carnet { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public AccelUpdateInfo? CartesBancaires { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashapp")]
    public CashAppUpdateInfo? Cashapp { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public AccelUpdateInfo? Cup { get; init; }

    /// <summary>
    /// The list of currencies that a payment method supports. By default, all currencies supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currencies")]
    public IReadOnlyList<string>? Currencies { get; init; }

    /// <summary>
    /// Custom routing flags for acquirer routing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("customRoutingFlags")]
    public IReadOnlyList<string>? CustomRoutingFlags { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public AccelUpdateInfo? Diners { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public AccelUpdateInfo? Discover { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public AccelUpdateInfo? EftDirectdebitCa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public AccelUpdateInfo? EftposAustralia { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public AccelUpdateInfo? Girocard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public AccelUpdateInfo? Ideal { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public AccelUpdateInfo? InteracCard { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public AccelUpdateInfo? Jcb { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public AccelUpdateInfo? Maestro { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public AccelUpdateInfo? MaestroUsa { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public AccelUpdateInfo? Mc { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public AccelUpdateInfo? Nyce { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public AccelUpdateInfo? PaybybankPlaid { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public AccelUpdateInfo? Pulse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public AccelUpdateInfo? Sepadirectdebit { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public AccelUpdateInfo? Star { get; init; }

    /// <summary>
    /// The store for this payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeId")]
    public string? StoreId { get; init; }

    /// <summary>
    /// The list of stores for this payment method
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storeIds")]
    public IReadOnlyList<string>? StoreIds { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public AccelUpdateInfo? Visa { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UpdatePaymentMethodInfo
{
    /// <summary>
    /// Details to provide if <c>type</c> is <b>accel</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accel")]
    public AccelUpdateInfo1? Accel { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>affirm</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("affirm")]
    public AffirmUpdateInfo1? Affirm { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>bcmc</b> (Bancontact).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bcmc")]
    public BcmcUpdateInfo1? Bcmc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>carnet</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("carnet")]
    public GenericPmWithTdiUpdateInfo1? Carnet { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cartebancaire</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cartesBancaires")]
    public CartesBancairesUpdateInfo1? CartesBancaires { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cashapp</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cashapp")]
    public CashAppUpdateInfo1? Cashapp { get; init; }

    /// <summary>
    /// The list of countries where a payment method is available. By default, all countries supported by the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public IReadOnlyList<string>? Countries { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>cup</b> (China Union Pay).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cup")]
    public GenericPmWithTdiUpdateInfo2? Cup { get; init; }

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

    /// <summary>
    /// Details to provide if <c>type</c> is <b>diners</b>.
    /// For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">JCB-specific fields</see>/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("diners")]
    public GenericPmWithTdiUpdateInfo3? Diners { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>discover</b>.
    /// For merchants operating in Japan, request <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">Diners</see>/paymentMethodSettings/(paymentMethodId)#request-diners) payment method instead. Discover is automatically requested, together with Diners.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discover")]
    public GenericPmWithTdiUpdateInfo4? Discover { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>eft_directdebit_CA</b> (EFT PAD).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft_directdebit_CA")]
    public GenericPmWithTdiUpdateInfo5? EftDirectdebitCa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>eftpos_australia</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eftpos_australia")]
    public GenericPmWithTdiUpdateInfo6? EftposAustralia { get; init; }

    /// <summary>
    /// Indicates whether the payment method is enabled (<b>true</b>) or disabled (<b>false</b>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>girocard</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("girocard")]
    public GenericPmWithTdiUpdateInfo7? Girocard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>ideal</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ideal")]
    public GenericPmWithTdiUpdateInfo8? Ideal { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>interac_card</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interac_card")]
    public GenericPmWithTdiUpdateInfo9? InteracCard { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>jcb</b>.
    /// For merchants operating in Japan, <c>midNumber</c>, <c>reuseMidNumber</c>, and <c>serviceLevel</c> fields are required.
    /// For merchants operating outside of Japan, these fields are not required.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("jcb")]
    public GenericPmWithTdiUpdateInfo10? Jcb { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>maestro</b>.
    /// In the US, <c>maestro</c> is not supported; use <c>maestro_usa</c> instead.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro")]
    public GenericPmWithTdiUpdateInfo11? Maestro { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>maestro_usa</b>.
    /// Only for Maestro USA, otherwise use <c>maestro</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maestro_usa")]
    public GenericPmWithTdiUpdateInfo12? MaestroUsa { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>mc</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mc")]
    public GenericPmWithTdiUpdateInfo13? Mc { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>nyce</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("nyce")]
    public NyceUpdateInfo1? Nyce { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>paybybank_plaid</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paybybank_plaid")]
    public PayByBankPlaidUpdateInfo1? PaybybankPlaid { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>pulse</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pulse")]
    public PulseUpdateInfo1? Pulse { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>sepadirectdebit</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sepadirectdebit")]
    public SepaDirectDebitUpdateInfo1? Sepadirectdebit { get; init; }

    /// <summary>
    /// Details to provide if <c>type</c> is <b>star</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("star")]
    public StarUpdateInfo1? Star { get; init; }

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

    /// <summary>
    /// Details to provide if <c>type</c> is <b>visa</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visa")]
    public GenericPmWithTdiUpdateInfo14? Visa { get; init; }
}

using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains one or more objects that define the <see href="https://docs.adyen.com/issuing/transaction-rules#conditions">rule conditions</see>. Each object must have a value and an operation which determines how the values must be evaluated.
/// <para>
/// For example, a <c>countries</c> object can have a list of country codes <b>["US", "CA"]</b> in the <c>value</c> field and <b>anyMatch</b> in the <c>operation</c> field.
/// </para>
/// </summary>
public record TransactionRuleRestrictions1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeNetworkTokens")]
    public ActiveNetworkTokensRestriction? ActiveNetworkTokens { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandVariants")]
    public BrandVariantsRestriction? BrandVariants { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterpartyBank")]
    public CounterpartyBankRestriction? CounterpartyBank { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterpartyTypes")]
    public CounterpartyTypesRestriction? CounterpartyTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public CountriesRestriction? Countries { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekRestriction? DayOfWeek { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("differentCurrencies")]
    public DifferentCurrenciesRestriction? DifferentCurrencies { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryModes")]
    public EntryModesRestriction? EntryModes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internationalTransaction")]
    public InternationalTransactionRestriction? InternationalTransaction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matchingTransactions")]
    public MatchingTransactionsRestriction? MatchingTransactions { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matchingValues")]
    public MatchingValuesRestriction? MatchingValues { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mccs")]
    public MccsRestriction? Mccs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantNames")]
    public MerchantNamesRestriction? MerchantNames { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchants")]
    public MerchantsRestriction? Merchants { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingTypes")]
    public ProcessingTypesRestriction? ProcessingTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskScores")]
    public RiskScoresRestriction? RiskScores { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameAmountRestriction")]
    public SameAmountRestriction? SameAmountRestriction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameCounterpartyRestriction")]
    public SameAmountRestriction? SameCounterpartyRestriction { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAccountTypes")]
    public SourceAccountTypesRestriction? SourceAccountTypes { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeOfDay")]
    public TimeOfDayRestriction? TimeOfDay { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenRequestors")]
    public TokenRequestorsRestriction? TokenRequestors { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    public TotalAmountRestriction? TotalAmount { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderAccountScore")]
    public WalletProviderAccountScoreRestriction? WalletProviderAccountScore { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderDeviceScore")]
    public WalletProviderAccountScoreRestriction? WalletProviderDeviceScore { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderDeviceType")]
    public WalletProviderDeviceType? WalletProviderDeviceType { get; init; }
}

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
    /// <summary>
    /// The total number of tokens that a card can have across different kinds of digital wallets on the user's phones, watches, or other wearables.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeNetworkTokens")]
    public ActiveNetworkTokensRestriction1? ActiveNetworkTokens { get; init; }

    /// <summary>
    /// List of card brand variants and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brandVariants")]
    public BrandVariantsRestriction1? BrandVariants { get; init; }

    /// <summary>
    /// Contains a list of counterparty financial institutions and how they must be evaluated.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterpartyBank")]
    public CounterpartyBankRestriction1? CounterpartyBank { get; init; }

    /// <summary>
    /// Contains a list of counterparty types and how they must be evaluated.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// <para>
    /// Supported value inputs:
    /// - <b>balanceAccount</b>
    /// - <b>bankAccount</b>
    /// - <b>card</b>
    /// - <b>transferInstrument</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("counterpartyTypes")]
    public CounterpartyTypesRestriction1? CounterpartyTypes { get; init; }

    /// <summary>
    /// List of countries and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("countries")]
    public CountriesRestriction1? Countries { get; init; }

    /// <summary>
    /// List of week days and the operation. Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekRestriction1? DayOfWeek { get; init; }

    /// <summary>
    /// Compares the currency of the payment against the currency of the payment instrument, and specifies the operation.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("differentCurrencies")]
    public DifferentCurrenciesRestriction1? DifferentCurrencies { get; init; }

    /// <summary>
    /// List of point-of-sale entry modes and the operation..
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("entryModes")]
    public EntryModesRestriction1? EntryModes { get; init; }

    /// <summary>
    /// Indicates whether transaction is an international transaction and specifies the operation.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("internationalTransaction")]
    public InternationalTransactionRestriction1? InternationalTransaction { get; init; }

    /// <summary>
    /// The number of transactions and the operation.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matchingTransactions")]
    public MatchingTransactionsRestriction1? MatchingTransactions { get; init; }

    /// <summary>
    /// Checks if a user has recently made multiple transfers with the specified values.
    /// <para>
    /// To use this restriction, you must:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Set the rule <c>type</c> to <b>velocity</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a time <c>interval</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a number of <c>matchingTransactions</c>.</description></item>
    /// </list>
    /// <para>
    /// Supported operation: <b>allMatch</b>.
    /// </para>
    /// <para>
    /// Supported value inputs:
    /// - <b>merchantId</b> and <b>acquirerId</b>
    /// - <b>amount</b> and <b>currency</b>
    /// - <b>merchantName</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("matchingValues")]
    public MatchingValuesRestriction1? MatchingValues { get; init; }

    /// <summary>
    /// List of merchant category codes (MCCs) and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mccs")]
    public MccsRestriction1? Mccs { get; init; }

    /// <summary>
    /// List of names that will be compared to the merchant name according to the matching type.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantNames")]
    public MerchantNamesRestriction1? MerchantNames { get; init; }

    /// <summary>
    /// List of merchant ID and acquirer ID pairs, and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchants")]
    public MerchantsRestriction1? Merchants { get; init; }

    /// <summary>
    /// List of processing types and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingTypes")]
    public ProcessingTypesRestriction1? ProcessingTypes { get; init; }

    /// <summary>
    /// Risk scores provided by specific sources. The same operation applies to all scores.
    /// <para>
    /// Current sources available: <b>visa</b>, <b>mastercard</b>
    /// </para>
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("riskScores")]
    public RiskScoresRestriction1? RiskScores { get; init; }

    /// <summary>
    /// Checks if a user has recently sent the same amount of funds in multiple transfers.
    /// <para>
    /// To use this restriction, you must:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Set the rule <c>type</c> to <b>velocity</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a time <c>interval</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a number of <c>matchingTransactions</c>.</description></item>
    /// </list>
    /// <para>
    /// Supported operation: <b>equals</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameAmountRestriction")]
    public SameAmountRestriction1? SameAmountRestriction { get; init; }

    /// <summary>
    /// Checks if a user has recently made multiple transfers to the same counterparty.
    /// <para>
    /// To use this restriction, you must:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Set the rule <c>type</c> to <b>velocity</b>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a time <c>interval</c>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Specify a number of <c>matchingTransactions</c>.</description></item>
    /// </list>
    /// <para>
    /// Supported operations: <b>equals</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sameCounterpartyRestriction")]
    public SameCounterpartyRestriction1? SameCounterpartyRestriction { get; init; }

    /// <summary>
    /// Contains a list of source account types and how they must be evaluated.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// <para>
    /// Supported value inputs:
    /// - <b>balanceAccount</b>
    /// - <b>businessAccount</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceAccountTypes")]
    public SourceAccountTypesRestriction1? SourceAccountTypes { get; init; }

    /// <summary>
    /// A start and end time in a time-only ISO-8601 extended offset format. Supported operations: <b>equals</b>, <b>notEquals</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeOfDay")]
    public TimeOfDayRestriction1? TimeOfDay { get; init; }

    /// <summary>
    /// List of token requestor IDs and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tokenRequestors")]
    public TokenRequestorsRestriction1? TokenRequestors { get; init; }

    /// <summary>
    /// The total amount and the operation.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalAmount")]
    public TotalAmountRestriction1? TotalAmount { get; init; }

    /// <summary>
    /// Checks the wallet account score.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderAccountScore")]
    public WalletProviderAccountScoreRestriction2? WalletProviderAccountScore { get; init; }

    /// <summary>
    /// Wallet Provider Device Score and the operation.
    /// <para>
    /// Supported operations: <b>equals</b>, <b>notEquals</b>, <b>greaterThanOrEqualTo</b>, <b>greaterThan</b>, <b>lessThanOrEqualTo</b>, <b>lessThan</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderDeviceScore")]
    public WalletProviderDeviceScore2? WalletProviderDeviceScore { get; init; }

    /// <summary>
    /// Wallet Provider Device Type and the operation.
    /// <para>
    /// Supported operations: <b>anyMatch</b>, <b>noneMatch</b>.
    /// </para>
    /// <para>
    /// Supported value inputs:
    /// - <b>MOBILE_PHONE</b>
    /// - <b>TABLET_OR_EREADER</b>
    /// - <b>WATCH_OR_WRISTBAND</b>
    /// - <b>WEARABLE</b>
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>CARD</b></description></item>
    ///   <item><description><b>PC</b></description></item>
    ///   <item><description><b>OTHER</b></description></item>
    ///   <item><description><b>UNKNOWN</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("walletProviderDeviceType")]
    public WalletProviderDeviceType2? WalletProviderDeviceType { get; init; }
}

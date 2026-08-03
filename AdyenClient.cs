using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Api;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Exceptions;
using Adyen.Core.Logging;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Models;

namespace Adyen;

/// <summary>
/// The A2A payments API provides endpoints for A2A payment flows, enabling issuers to facilitate direct payments through Adyen for users with an Adyen business account.
/// <para>
/// With these endpoints, you can:
/// - <b>Retrieve payment details</b>: Retrieve transaction information for specific payments.
/// - <b>Confirm payments</b>: Confirm payments with Strong Customer Authentication (SCA).
/// - <b>Cancel payments</b>: Cancel pending transactions.
/// </para>
/// <para>
/// ## Authentication
/// Each request made to the A2A Payments API must be signed with an API key. Generate an API key in your Customer Area.
/// </para>
/// <para>
/// To connect to the API, add an <c>X-API-Key</c> header with the API key as the value, for example:
/// </para>
/// <para>
///  ```
/// curl
/// -H "Content-Type: application/json" \
/// -H "X-API-Key: YOUR_API_KEY" \
/// ...
/// <code>
/// </para>
/// <para>
/// ## Roles and permissions
/// To use the A2A Payments API, your API credential must have the following roles:
/// - <b>Role for A2A Issuer payments - API</b>
/// </para>
/// <para>
/// Reach out to your Adyen contact to set up these roles.
/// ## Going live
/// When going live, generate an API key in your <see href="https://ca-live.adyen.com/ca">live Customer Area</see>. You can then use the API key to send requests to <c>https://balanceplatform-api-live.adyen.com/a2aissuer-api/v{version}/payments</c>.
/// </para>
/// </summary>
public sealed class AdyenClient
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    public AdyenClient(HttpClient httpClient, AdyenClientOptions options)
    {
        _server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "AdyenClient/1 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "AdyenClient");
        _rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        _auth = new AuthSchemes(options);
        ApiCredentialsCompanyLevel = new ApiCredentialsCompanyLevel(_rawClient, _server, _auth);
        ApiCredentialsMerchantLevel = new ApiCredentialsMerchantLevel(_rawClient, _server, _auth);
        ApiKeyCompanyLevel = new ApiKeyCompanyLevel(_rawClient, _server, _auth);
        ApiKeyMerchantLevel = new ApiKeyMerchantLevel(_rawClient, _server, _auth);
        AccountCompanyLevel = new AccountCompanyLevel(_rawClient, _server, _auth);
        AccountMerchantLevel = new AccountMerchantLevel(_rawClient, _server, _auth);
        AccountStoreLevel = new AccountStoreLevel(_rawClient, _server, _auth);
        AccountVerification = new AccountVerification(_rawClient, _server);
        AccountHolders = new AccountHolders(_rawClient, _server, _auth);
        Accounts = new Accounts(_rawClient, _server, _auth);
        AllowedOriginsCompanyLevel = new AllowedOriginsCompanyLevel(_rawClient, _server, _auth);
        AllowedOriginsMerchantLevel = new AllowedOriginsMerchantLevel(_rawClient, _server, _auth);
        AndroidFilesCompanyLevel = new AndroidFilesCompanyLevel(_rawClient, _server, _auth);
        AuthorizedCardUsers = new AuthorizedCardUsers(_rawClient, _server);
        BalanceAccounts = new BalanceAccounts(_rawClient, _server, _auth);
        BalanceTransfers = new BalanceTransfers(_rawClient, _server);
        BalancesApi = new BalancesApi(_rawClient, _server);
        BalancesOverview = new BalancesOverview(_rawClient, _server);
        BankAccountValidation = new BankAccountValidation(_rawClient, _server, _auth);
        BusinessLinesApi = new BusinessLinesApi(_rawClient, _server, _auth);
        Capital = new Capital(_rawClient, _server, _auth);
        CardOrders = new CardOrders(_rawClient, _server, _auth);
        CashOutApi = new CashOutApi(_rawClient, _server);
        ClientKeyCompanyLevel = new ClientKeyCompanyLevel(_rawClient, _server, _auth);
        ClientKeyMerchantLevel = new ClientKeyMerchantLevel(_rawClient, _server, _auth);
        CloudEndpointsAndConnection = new CloudEndpointsAndConnection(_rawClient, _server);
        CustomPayoutSchedulesSweeps = new CustomPayoutSchedulesSweeps(_rawClient, _server, _auth);
        DirectDebitMandates = new DirectDebitMandates(_rawClient, _server);
        DisputeAttachments = new DisputeAttachments(_rawClient, _server);
        Documents = new Documents(_rawClient, _server, _auth);
        DonationCampaigns = new DonationCampaigns(_rawClient, _server, _auth);
        Donations = new Donations(_rawClient, _server, _auth);
        DynamicOffers = new DynamicOffers(_rawClient, _server);
        General = new General(_rawClient, _server, _auth);
        GrantAccounts = new GrantAccounts(_rawClient, _server, _auth);
        GrantOffersApi = new GrantOffersApi(_rawClient, _server, _auth);
        GrantsApi = new GrantsApi(_rawClient, _server);
        HostedOnboarding = new HostedOnboarding(_rawClient, _server, _auth);
        HostedOnboardingPage = new HostedOnboardingPage(_rawClient, _server, _auth);
        Initialization = new Initialization(_rawClient, _server, _auth);
        InstantPayouts = new InstantPayouts(_rawClient, _server, _auth);
        LegalEntities = new LegalEntities(_rawClient, _server, _auth);
        ManageScaDevices = new ManageScaDevices(_rawClient, _server, _auth);
        ManageCardPin = new ManageCardPin(_rawClient, _server, _auth);
        ManagedPayoutSchedules = new ManagedPayoutSchedules(_rawClient, _server);
        Modifications = new Modifications(_rawClient, _server, _auth);
        MyApiCredential = new MyApiCredential(_rawClient, _server, _auth);
        NetworkTokens = new NetworkTokens(_rawClient, _server, _auth);
        Orders = new Orders(_rawClient, _server, _auth);
        PciComplianceQuestionnairePage = new PciComplianceQuestionnairePage(_rawClient, _server, _auth);
        PciQuestionnaires = new PciQuestionnaires(_rawClient, _server, _auth);
        PaymentInstrumentGroups = new PaymentInstrumentGroups(_rawClient, _server, _auth);
        PaymentInstruments = new PaymentInstruments(_rawClient, _server, _auth);
        PaymentLinks = new PaymentLinks(_rawClient, _server, _auth);
        PaymentMethodsMerchantLevel = new PaymentMethodsMerchantLevel(_rawClient, _server, _auth);
        Payments = new Payments(_rawClient, _server, _auth);
        PaymentsApp = new PaymentsApp(_rawClient, _server);
        PayoutSettingsMerchantLevel = new PayoutSettingsMerchantLevel(_rawClient, _server, _auth);
        Platform = new Platform(_rawClient, _server, _auth);
        RaiseDisputes = new RaiseDisputes(_rawClient, _server);
        Rates = new Rates(_rawClient, _server);
        RecurringApi = new RecurringApi(_rawClient, _server, _auth);
        RecurringTopUps = new RecurringTopUps(_rawClient, _server);
        Reviewing = new Reviewing(_rawClient, _server, _auth);
        ScaAssociationManagement = new ScaAssociationManagement(_rawClient, _server);
        ScaDeviceManagement = new ScaDeviceManagement(_rawClient, _server);
        SessionAuthentication = new SessionAuthentication(_rawClient, _server);
        SplitConfigurationMerchantLevel = new SplitConfigurationMerchantLevel(_rawClient, _server, _auth);
        TaxEDeliveryConsent = new TaxEDeliveryConsent(_rawClient, _server, _auth);
        TerminalActionsCompanyLevel = new TerminalActionsCompanyLevel(_rawClient, _server, _auth);
        TerminalActionsTerminalLevel = new TerminalActionsTerminalLevel(_rawClient, _server, _auth);
        TerminalOrdersCompanyLevel = new TerminalOrdersCompanyLevel(_rawClient, _server, _auth);
        TerminalOrdersMerchantLevel = new TerminalOrdersMerchantLevel(_rawClient, _server, _auth);
        TerminalSettingsCompanyLevel = new TerminalSettingsCompanyLevel(_rawClient, _server, _auth);
        TerminalSettingsMerchantLevel = new TerminalSettingsMerchantLevel(_rawClient, _server, _auth);
        TerminalSettingsStoreLevel = new TerminalSettingsStoreLevel(_rawClient, _server, _auth);
        TerminalSettingsTerminalLevel = new TerminalSettingsTerminalLevel(_rawClient, _server, _auth);
        TerminalsTerminalLevel = new TerminalsTerminalLevel(_rawClient, _server, _auth);
        TermsOfService = new TermsOfService(_rawClient, _server, _auth);
        TransactionRules = new TransactionRules(_rawClient, _server, _auth);
        Transactions = new Transactions(_rawClient, _server, _auth);
        TransferInstruments = new TransferInstruments(_rawClient, _server, _auth);
        TransferLimitsBalanceAccountLevel = new TransferLimitsBalanceAccountLevel(_rawClient, _server);
        TransferLimitsBalancePlatformLevel = new TransferLimitsBalancePlatformLevel(_rawClient, _server);
        TransferRoutes = new TransferRoutes(_rawClient, _server, _auth);
        Transfers = new Transfers(_rawClient, _server, _auth);
        UsersCompanyLevel = new UsersCompanyLevel(_rawClient, _server, _auth);
        UsersMerchantLevel = new UsersMerchantLevel(_rawClient, _server, _auth);
        Utility = new Utility(_rawClient, _server, _auth);
        Verification = new Verification(_rawClient, _server, _auth);
        WebhooksCompanyLevel = new WebhooksCompanyLevel(_rawClient, _server, _auth);
        WebhooksMerchantLevel = new WebhooksMerchantLevel(_rawClient, _server, _auth);
        IDealProfiles = new IDealProfiles(_rawClient, _server);
    }

    public ApiCredentialsCompanyLevel ApiCredentialsCompanyLevel { get; }

    public ApiCredentialsMerchantLevel ApiCredentialsMerchantLevel { get; }

    public ApiKeyCompanyLevel ApiKeyCompanyLevel { get; }

    public ApiKeyMerchantLevel ApiKeyMerchantLevel { get; }

    public AccountCompanyLevel AccountCompanyLevel { get; }

    public AccountMerchantLevel AccountMerchantLevel { get; }

    public AccountStoreLevel AccountStoreLevel { get; }

    public AccountVerification AccountVerification { get; }

    public AccountHolders AccountHolders { get; }

    public Accounts Accounts { get; }

    public AllowedOriginsCompanyLevel AllowedOriginsCompanyLevel { get; }

    public AllowedOriginsMerchantLevel AllowedOriginsMerchantLevel { get; }

    public AndroidFilesCompanyLevel AndroidFilesCompanyLevel { get; }

    public AuthorizedCardUsers AuthorizedCardUsers { get; }

    public BalanceAccounts BalanceAccounts { get; }

    public BalanceTransfers BalanceTransfers { get; }

    public BalancesApi BalancesApi { get; }

    public BalancesOverview BalancesOverview { get; }

    public BankAccountValidation BankAccountValidation { get; }

    public BusinessLinesApi BusinessLinesApi { get; }

    public Capital Capital { get; }

    public CardOrders CardOrders { get; }

    public CashOutApi CashOutApi { get; }

    public ClientKeyCompanyLevel ClientKeyCompanyLevel { get; }

    public ClientKeyMerchantLevel ClientKeyMerchantLevel { get; }

    public CloudEndpointsAndConnection CloudEndpointsAndConnection { get; }

    public CustomPayoutSchedulesSweeps CustomPayoutSchedulesSweeps { get; }

    public DirectDebitMandates DirectDebitMandates { get; }

    public DisputeAttachments DisputeAttachments { get; }

    public Documents Documents { get; }

    public DonationCampaigns DonationCampaigns { get; }

    public Donations Donations { get; }

    public DynamicOffers DynamicOffers { get; }

    public General General { get; }

    public GrantAccounts GrantAccounts { get; }

    public GrantOffersApi GrantOffersApi { get; }

    public GrantsApi GrantsApi { get; }

    public HostedOnboarding HostedOnboarding { get; }

    public HostedOnboardingPage HostedOnboardingPage { get; }

    public Initialization Initialization { get; }

    public InstantPayouts InstantPayouts { get; }

    public LegalEntities LegalEntities { get; }

    public ManageScaDevices ManageScaDevices { get; }

    public ManageCardPin ManageCardPin { get; }

    public ManagedPayoutSchedules ManagedPayoutSchedules { get; }

    public Modifications Modifications { get; }

    public MyApiCredential MyApiCredential { get; }

    public NetworkTokens NetworkTokens { get; }

    public Orders Orders { get; }

    public PciComplianceQuestionnairePage PciComplianceQuestionnairePage { get; }

    public PciQuestionnaires PciQuestionnaires { get; }

    public PaymentInstrumentGroups PaymentInstrumentGroups { get; }

    public PaymentInstruments PaymentInstruments { get; }

    public PaymentLinks PaymentLinks { get; }

    public PaymentMethodsMerchantLevel PaymentMethodsMerchantLevel { get; }

    public Payments Payments { get; }

    public PaymentsApp PaymentsApp { get; }

    public PayoutSettingsMerchantLevel PayoutSettingsMerchantLevel { get; }

    public Platform Platform { get; }

    public RaiseDisputes RaiseDisputes { get; }

    public Rates Rates { get; }

    public RecurringApi RecurringApi { get; }

    public RecurringTopUps RecurringTopUps { get; }

    public Reviewing Reviewing { get; }

    public ScaAssociationManagement ScaAssociationManagement { get; }

    public ScaDeviceManagement ScaDeviceManagement { get; }

    public SessionAuthentication SessionAuthentication { get; }

    public SplitConfigurationMerchantLevel SplitConfigurationMerchantLevel { get; }

    public TaxEDeliveryConsent TaxEDeliveryConsent { get; }

    public TerminalActionsCompanyLevel TerminalActionsCompanyLevel { get; }

    public TerminalActionsTerminalLevel TerminalActionsTerminalLevel { get; }

    public TerminalOrdersCompanyLevel TerminalOrdersCompanyLevel { get; }

    public TerminalOrdersMerchantLevel TerminalOrdersMerchantLevel { get; }

    public TerminalSettingsCompanyLevel TerminalSettingsCompanyLevel { get; }

    public TerminalSettingsMerchantLevel TerminalSettingsMerchantLevel { get; }

    public TerminalSettingsStoreLevel TerminalSettingsStoreLevel { get; }

    public TerminalSettingsTerminalLevel TerminalSettingsTerminalLevel { get; }

    public TerminalsTerminalLevel TerminalsTerminalLevel { get; }

    public TermsOfService TermsOfService { get; }

    public TransactionRules TransactionRules { get; }

    public Transactions Transactions { get; }

    public TransferInstruments TransferInstruments { get; }

    public TransferLimitsBalanceAccountLevel TransferLimitsBalanceAccountLevel { get; }

    public TransferLimitsBalancePlatformLevel TransferLimitsBalancePlatformLevel { get; }

    public TransferRoutes TransferRoutes { get; }

    public Transfers Transfers { get; }

    public UsersCompanyLevel UsersCompanyLevel { get; }

    public UsersMerchantLevel UsersMerchantLevel { get; }

    public Utility Utility { get; }

    public Verification Verification { get; }

    public WebhooksCompanyLevel WebhooksCompanyLevel { get; }

    public WebhooksMerchantLevel WebhooksMerchantLevel { get; }

    public IDealProfiles IDealProfiles { get; }

    /// <summary>
    /// Abort Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="object"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Body of the Abort Request message.
    /// It conveys Information requested for identification of the message request carrying the transaction to abort. A message to display on the CustomerError Device could be sent by the Sale System (DisplayOutput).
    /// </remarks>
    public Task<object> AbortRequest(AbortRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/abort"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<object>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Admin Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AdminResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Empty.
    /// Content of the Custom Admin Request message.
    /// </remarks>
    public Task<AdminResponse1> AdminRequest(AdminRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/admin"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AdminResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// BalanceInquiry Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BalanceinquiryResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the account for which a Balance Inquiry is requested.
    /// Content of the Balance Inquiry Request message.
    /// </remarks>
    public Task<BalanceinquiryResponse1> BalanceInquiryRequest(BalanceInquiryRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/balanceinquiry"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BalanceinquiryResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// CardAcquisition Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardacquisitionResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the payment and loyalty cards to read and analyse. This message pair is usually followed by a message pair (e.g. payment or loyalty) which refers to this Card Acquisition message pair.
    /// Content of the Card Acquisition Request message.
    /// </remarks>
    public Task<CardacquisitionResponse4> CardAcquisitionRequest(CardAcquisitionRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cardacquisition"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CardacquisitionResponse4>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// CardReaderAPDU Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CardreaderapduResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It contains the APDU request to send to the chip of the card, and a possible invitation message to display on the CashierInterface or the CustomerInterface.
    /// Content of the Card Reader APDU Request message.
    /// </remarks>
    public Task<CardreaderapduResponse4> CardReaderApdurequest(CardReaderApdurequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/cardreaderapdu"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CardreaderapduResponse4>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Diagnosis Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DiagnosisResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the target POI for which the diagnosis is requested.
    /// Content of the Diagnosis Request message.
    /// </remarks>
    public Task<DiagnosisResponse1> DiagnosisRequest(DiagnosisRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/diagnosis"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DiagnosisResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Display Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisplayResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys the data to display and the way to process the display. It contains the complete content to display. It might contain an operation (the DisplayOutput element) per Display Device type.
    /// Content of the Display Request message.
    /// </remarks>
    public Task<DisplayResponse1> DisplayRequest(DisplayRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/display"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DisplayResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// EnableService Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EnableserviceResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys the services that will be enabled for the POI Terminal without the request of the Sale System, and a possible invitation for the Customer to start the services.
    /// Content of the Enable Service Request message.
    /// </remarks>
    public Task<EnableserviceResponse1> EnableServiceRequest(EnableServiceRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/enableservice"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<EnableserviceResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// GetTotals Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GettotalsResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys information from the Sale System related to the scope and the format of the totals to be computed by the POI System.
    /// Content of the Get Totals Request message.
    /// </remarks>
    public Task<GettotalsResponse1> GetTotalsRequest(GetTotalsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/gettotals"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GettotalsResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Input Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="InputResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the <c>InputRequest</c> message. It conveys the data to display and how to process it. In addition to the display on the Input Device, it might contain an operation (the <c>DisplayOutput</c> element) per Display Device type.
    /// </remarks>
    public Task<InputResponse1> InputRequest(InputRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/input"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<InputResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Login Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LoginResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys information related to the session (period between a Login and the following Logout) to process.
    /// Content of the <c>LoginRequest</c> message.
    /// </remarks>
    public Task<LoginResponse1> LoginRequest(LoginRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/login"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LoginResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Logout Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="LogoutResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Empty.
    /// Content of the Logout Request message.
    /// </remarks>
    public Task<LogoutResponse1> LogoutRequest(LogoutRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/logout"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<LogoutResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Payment Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaymentResponse6"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Request sent to terminal to initiate payment.
    /// It conveys Information related to the Payment transaction to process.
    /// Content of the <c>PaymentRequest</c> message.
    /// </remarks>
    public Task<PaymentResponse6> PaymentRequest(PaymentRequest2? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/payment"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PaymentResponse6>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Print Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PrintResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the Print Request message.
    /// It conveys the complete data to print and how to process the print.
    /// </remarks>
    public Task<PrintResponse1> PrintRequest(PrintRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/print"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PrintResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Reconciliation Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReconciliationResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the Reconciliation Request message.
    /// It conveys Information related to the Reconciliation requested by the Sale System.
    /// </remarks>
    public Task<ReconciliationResponse1> ReconciliationRequest(ReconciliationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reconciliation"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ReconciliationResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Reversal Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReversalResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the reversal of a previous payment or a loyalty transaction.
    /// Content of the Reversal Request message.
    /// </remarks>
    public Task<ReversalResponse4> ReversalRequest(ReversalRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/reversal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ReversalResponse4>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// StoredValue Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredvalueResponse4"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// It conveys Information related to the Stored Value transaction to process.
    /// Content of the Stored Value Request message.
    /// </remarks>
    public Task<StoredvalueResponse4> StoredValueRequest(StoredValueRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/storedvalue"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredvalueResponse4>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// TransactionStatus Request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionstatusResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Content of the TransactionStatus Request message.
    /// It conveys Information requested for status of the last or current Payment, Loyalty or Reversal transaction.
    /// </remarks>
    public Task<TransactionstatusResponse1> TransactionStatusRequest(TransactionStatusRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/transactionstatus"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransactionstatusResponse1>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

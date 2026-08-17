using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class General
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal General(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Accept a dispute
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAcceptDisputeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts a specific dispute.
    /// </remarks>
    public Task<AcceptDisputeResponse> PostAcceptDispute(AcceptDisputeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default22("/acceptDispute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AcceptDisputeResponse>(),
            PostAcceptDisputeErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the balances of an account holder
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolderBalanceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAccountHolderBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the account balances of an account holder. An account's balances are organized according by currencies. This mean that an account may have multiple balances: one for each currency.
    /// </remarks>
    public Task<AccountHolderBalanceResponse> PostAccountHolderBalance(CloseAccountHolderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/accountHolderBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountHolderBalanceResponse>(),
            PostAccountHolderBalanceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of transactions
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolderTransactionListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAccountHolderTransactionListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transactions for an account holder's accounts. You can specify the accounts and transaction statuses to be included on the list. The call returns a maximum of 50 transactions for each account. To retrieve all transactions, you must make another call with the 'page' value incremented. Transactions are listed in chronological order, with the most recent transaction first.
    /// </remarks>
    public Task<AccountHolderTransactionListResponse> PostAccountHolderTransactionList(AccountHolderTransactionListRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/accountHolderTransactionList"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AccountHolderTransactionListResponse>(),
            PostAccountHolderTransactionListErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Assign terminals
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssignTerminalsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostAssignTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns one or more payment terminals to a merchant account or a store. You can also use this endpoint to reassign terminals between merchant accounts or stores, and to unassign a terminal and return it to company inventory.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<AssignTerminalsResponse> PostAssignTerminals(AssignTerminalsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default28("/assignTerminals"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<AssignTerminalsResponse>(),
            PostAssignTerminalsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Changes the status of the payment method.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueStatusChangeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostChangeStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the status of the provided payment method to the specified status.
    /// </remarks>
    public Task<StoredValueStatusChangeResponse> PostChangeStatus(StoredValueStatusChangeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/changeStatus"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueStatusChangeResponse>(),
            PostChangeStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Checks the balance.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueBalanceCheckResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCheckBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks the balance of the provided payment method.
    /// </remarks>
    public Task<StoredValueBalanceCheckResponse> PostCheckBalance(StoredValueBalanceCheckRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/checkBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueBalanceCheckResponse>(),
            PostCheckBalanceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Subscribe to notifications
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCreateNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a subscription to notifications informing you of events on your platform. After the subscription is created, the events specified in the configuration will be sent to the URL specified in the configuration. Subscriptions must be configured on a per-event basis (as opposed to, for example, a per-account holder basis), so all event notifications of a marketplace and of a given type will be sent to the same endpoint(s). A marketplace may have multiple endpoints if desired; an event notification may be sent to as many or as few different endpoints as configured.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostCreateNotificationConfiguration(CreateNotificationConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/createNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostCreateNotificationConfigurationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create new permits linked to a recurring contract.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreatePermitResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCreatePermitError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create permits for a recurring contract, including support for defining restrictions.
    /// </remarks>
    public Task<CreatePermitResult> PostCreatePermit(CreatePermitRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/createPermit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreatePermitResult>(),
            PostCreatePermitErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Creates one or more test card ranges.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTestCardRangesResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCreateTestCardRangesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates one or more test card ranges.
    /// </remarks>
    public Task<CreateTestCardRangesResult> PostCreateTestCardRanges(CreateTestCardRangesRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default8("/createTestCardRanges"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CreateTestCardRangesResult>(),
            PostCreateTestCardRangesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Send a direct debit request
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DebitAccountHolderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDebitAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a direct debit request to an account holder's bank account. If the direct debit is successful, the funds are settled in the accounts specified in the split instructions. Adyen sends the result of the direct debit in a <see href="https://docs.adyen.com/api-explorer/#/NotificationService/latest/post/DIRECT_DEBIT_INITIATED"><c>DIRECT_DEBIT_INITIATED</c></see> notification webhook.
    /// <para>
    ///  To learn more about direct debits, see <see href="https://docs.adyen.com/classic-platforms/top-up-accounts">Top up accounts</see>.
    /// </para>
    /// </remarks>
    public Task<DebitAccountHolderResponse> PostDebitAccountHolder(DebitAccountHolderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/debitAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DebitAccountHolderResponse>(),
            PostDebitAccountHolderErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Defend a dispute
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DefendDisputeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDefendDisputeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Defends a specific dispute.
    /// </remarks>
    public Task<DefendDisputeResponse> PostDefendDispute(DefendDisputeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default22("/defendDispute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DefendDisputeResponse>(),
            PostDefendDisputeErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a defense document
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteDefenseDocumentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteDisputeDefenseDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a specific dispute defense document that was supplied earlier.
    /// </remarks>
    public Task<DeleteDefenseDocumentResponse> PostDeleteDisputeDefenseDocument(DeleteDefenseDocumentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default22("/deleteDisputeDefenseDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DeleteDefenseDocumentResponse>(),
            PostDeleteDisputeDefenseDocumentErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Delete a notification subscription configuration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDeleteNotificationConfigurationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing notification subscription configuration. After the subscription is deleted, no further event notifications will be sent to the URL defined in the subscription.
    /// </remarks>
    public Task<GenericResponse> PostDeleteNotificationConfigurations(DeleteNotificationConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/deleteNotificationConfigurations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteNotificationConfigurationsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Disable stored payment details
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisableResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDisableError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables stored payment details to stop charging a shopper with this particular recurring detail ID.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/classic-api-integration/tokenization/disable-stored-details">Disable stored details</see>.
    /// </para>
    /// </remarks>
    public Task<DisableResult> PostDisable(DisableRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/disable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DisableResult>(),
            PostDisableErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Disable an existing permit.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisablePermitResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostDisablePermitError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable a permit that was previously linked to a recurringDetailReference.
    /// </remarks>
    public Task<DisablePermitResult> PostDisablePermit(DisablePermitRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/disablePermit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DisablePermitResult>(),
            PostDisablePermitErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the account or store of a terminal
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FindTerminalResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostFindTerminalError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the company account, merchant account, or store that a payment terminal is assigned to.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<FindTerminalResponse> PostFindTerminal(FindTerminalRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default28("/findTerminal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<FindTerminalResponse>(),
            PostFindTerminalErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Check if 3D Secure is available
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ThreeDsAvailabilityResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGet3DsAvailabilityError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Verifies whether 3D Secure is available for the specified BIN or card brand. For 3D Secure 2, this endpoint also returns device fingerprinting keys.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">3D Secure 2</see>.
    /// </para>
    /// </remarks>
    public Task<ThreeDsAvailabilityResponse> PostGet3DsAvailability(ThreeDsAvailabilityRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default4("/get3dsAvailability"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ThreeDsAvailabilityResponse>(),
            PostGet3DsAvailabilityErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a fees cost estimate
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CostEstimateResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetCostEstimateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// &gt;This API is available only for merchants operating in Australia, the EU, and the UK.
    /// <para>
    /// Use the Adyen Cost Estimation API to pre-calculate interchange and scheme fee costs. Knowing these costs prior actual payment authorisation gives you an opportunity to charge those costs to the cardholder, if necessary.
    /// </para>
    /// <para>
    /// To retrieve this information, make the call to the <c>/getCostEstimate</c> endpoint. The response to this call contains the amount of the interchange and scheme fees charged by the network for this transaction, and also which surcharging policy is possible (based on current regulations).
    /// </para>
    /// <para>
    /// &gt; Since not all information is known in advance (for example, if the cardholder will successfully authenticate via 3D Secure or if you also plan to provide additional Level 2/3 data), the returned amounts are based on a set of assumption criteria you define in the <c>assumptions</c> parameter.
    /// </para>
    /// </remarks>
    public Task<CostEstimateResponse> PostGetCostEstimate(CostEstimateRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default4("/getCostEstimate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CostEstimateResponse>(),
            PostGetCostEstimateErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a notification subscription configuration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the configuration of a notification subscription.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostGetNotificationConfiguration(GetNotificationConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/getNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostGetNotificationConfigurationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get a list of notification subscription configurations
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationListResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetNotificationConfigurationListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the configurations of all of the notification subscriptions in the platform of the executing user.
    /// </remarks>
    public Task<GetNotificationConfigurationListResponse> PostGetNotificationConfigurationList(object? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/getNotificationConfigurationList"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetNotificationConfigurationListResponse>(),
            PostGetNotificationConfigurationListErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the stores of an account
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetStoresUnderAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetStoresUnderAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of stores associated with a company account or a merchant account, including the status of each store.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetStoresUnderAccountResponse> PostGetStoresUnderAccount(GetStoresUnderAccountRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default28("/getStoresUnderAccount"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetStoresUnderAccountResponse>(),
            PostGetStoresUnderAccountErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the details of a terminal
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalDetailsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetTerminalDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a payment terminal, including where the terminal is assigned to. The response returns the same details that are provided in the terminal list in your Customer Area and in the Terminal Fleet report.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetTerminalDetailsResponse> PostGetTerminalDetails(GetTerminalDetailsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default28("/getTerminalDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetTerminalDetailsResponse>(),
            PostGetTerminalDetailsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get the list of terminals
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalsUnderAccountResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostGetTerminalsUnderAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of payment terminals associated with a company account, merchant account, or store. The response shows whether the terminals are in the inventory, or in-store (ready for boarding or already boarded).
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetTerminalsUnderAccountResponse> PostGetTerminalsUnderAccount(GetTerminalsUnderAccountRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default28("/getTerminalsUnderAccount"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetTerminalsUnderAccountResponse>(),
            PostGetTerminalsUnderAccountErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Issues a new card.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueIssueResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostIssueError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Issues a new card of the given payment method.
    /// </remarks>
    public Task<StoredValueIssueResponse> PostIssue(StoredValueIssueRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/issue"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueIssueResponse>(),
            PostIssueErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get stored payment details
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringDetailsResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostListRecurringDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the stored payment details for a shopper, if there are any available. The recurring detail ID can be used with a regular authorisation request to charge the shopper. A summary of the payment detail is returned for presentation to the shopper.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/classic-integration/recurring-payments/retrieve-stored-details/">Retrieve stored details</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringDetailsResult> PostListRecurringDetails(RecurringDetailsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/listRecurringDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RecurringDetailsResult>(),
            PostListRecurringDetailsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Loads the payment method.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueLoadResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLoadError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Loads the payment method with the specified funds.
    /// </remarks>
    public Task<StoredValueLoadResponse> PostLoad(StoredValueLoadRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/load"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueLoadResponse>(),
            PostLoadErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Merge the balance of two cards.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueBalanceMergeResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostMergeBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Increases the balance of the paymentmethod by the full amount left on the source paymentmethod
    /// </remarks>
    public Task<StoredValueBalanceMergeResponse> PostMergeBalance(StoredValueBalanceMergeRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/mergeBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueBalanceMergeResponse>(),
            PostMergeBalanceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Ask issuer to notify the shopper
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NotifyShopperResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostNotifyShopperError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to the issuer so they can inform the shopper about the upcoming recurring payment. This endpoint is used only for local acquiring in India. For more information, refer to <see href="https://docs.adyen.com/payment-methods/cards/cards-recurring-india">Recurring card payments in India</see>.
    /// </remarks>
    public Task<NotifyShopperResult> PostNotifyShopper(NotifyShopperRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/notifyShopper"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<NotifyShopperResult>(),
            PostNotifyShopperErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Pay out from an account to the account holder
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutAccountHolderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostPayoutAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Pays out a specified amount from an account to the bank account of account holder.
    /// </remarks>
    public Task<PayoutAccountHolderResponse> PostPayoutAccountHolder(PayoutAccountHolderRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/payoutAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PayoutAccountHolderResponse>(),
            PostPayoutAccountHolderErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Refund a funds transfer
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RefundFundsTransferResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRefundFundsTransferError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds funds transferred from one account to another. Both accounts must be in the same platform, but can have different account holders.
    /// </remarks>
    public Task<RefundFundsTransferResponse> PostRefundFundsTransfer(RefundFundsTransferRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/refundFundsTransfer"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<RefundFundsTransferResponse>(),
            PostRefundFundsTransferErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Refund all transactions of an account since the most recent payout
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRefundNotPaidOutTransfersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds all the transactions of an account that have taken place since the most recent payout. This request is on a account basis (as opposed to a payment basis), so only the portion of the payment that was made to the specified account is refunded. The commissions, fees, and payments to other accounts remain in the accounts to which they were sent as designated by the original payment's split details.
    /// </remarks>
    public Task<GenericResponse> PostRefundNotPaidOutTransfers(RefundNotPaidOutTransfersRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/refundNotPaidOutTransfers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostRefundNotPaidOutTransfersErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Submit a Subject Erasure Request.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubjectErasureResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRequestSubjectErasureError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends the PSP reference containing the shopper data that should be deleted.
    /// </remarks>
    public Task<SubjectErasureResponse> PostRequestSubjectErasure(SubjectErasureByPspReferenceRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default6("/requestSubjectErasure"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SubjectErasureResponse>(),
            PostRequestSubjectErasureErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get applicable defense reasons
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DefenseReasonsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostRetrieveApplicableDefenseReasonsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all applicable defense reasons to defend a specific dispute.
    /// </remarks>
    public Task<DefenseReasonsResponse> PostRetrieveApplicableDefenseReasons(DefenseReasonsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default22("/retrieveApplicableDefenseReasons"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DefenseReasonsResponse>(),
            PostRetrieveApplicableDefenseReasonsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Schedule running the Account Updater
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ScheduleAccountUpdaterResult"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostScheduleAccountUpdaterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When making the API call, you can submit either the credit card information, or the recurring detail reference and the shopper reference:
    /// * If the card information is provided, all the sub-fields for <c>card</c> are mandatory.
    /// * If the recurring detail reference is provided, the fields for <c>shopperReference</c> and <c>selectedRecurringDetailReference</c> are mandatory.
    /// </remarks>
    public Task<ScheduleAccountUpdaterResult> PostScheduleAccountUpdater(ScheduleAccountUpdaterRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default2("/scheduleAccountUpdater"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ScheduleAccountUpdaterResult>(),
            PostScheduleAccountUpdaterErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Create a communication session
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CertificateLoadingResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a secure communications session between the POS Mobile SDK and the Adyen payments platform, through mutual authentication.
    /// The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
    /// &gt;This request applies to <b>mobile in-person</b> transactions. You cannot use this request to create online payments sessions.
    /// </remarks>
    public Task<CertificateLoadingResponse> PostSessions3(CreateSessionRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default27("/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CertificateLoadingResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Designate a beneficiary account and transfer the benefactor's current balance
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostSetupBeneficiaryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Defines a benefactor and a beneficiary relationship between two accounts. At the time of benefactor/beneficiary setup, the funds in the benefactor account are transferred to the beneficiary account, and any further payments to the benefactor account are automatically sent to the beneficiary account. A series of benefactor/beneficiaries may not exceed four beneficiaries and may not have a cycle in it.
    /// </remarks>
    public Task<GenericResponse> PostSetupBeneficiary(SetupBeneficiaryRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/setupBeneficiary"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GenericResponse>(),
            PostSetupBeneficiaryErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Supply a defense document
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SupplyDefenseDocumentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostSupplyDefenseDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Supplies a specific dispute defense document.
    /// </remarks>
    public Task<SupplyDefenseDocumentResponse> PostSupplyDefenseDocument(SupplyDefenseDocumentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default22("/supplyDefenseDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SupplyDefenseDocumentResponse>(),
            PostSupplyDefenseDocumentErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Test a notification configuration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TestNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTestNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Tests an existing notification subscription configuration. For each event type specified, a test notification will be generated and sent to the URL configured in the subscription specified.
    /// </remarks>
    public Task<TestNotificationConfigurationResponse> PostTestNotificationConfiguration(TestNotificationConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/testNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TestNotificationConfigurationResponse>(),
            PostTestNotificationConfigurationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Transfer funds between platform accounts
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferFundsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostTransferFundsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers funds from one account to another account. Both accounts must be in the same platform, but can have different account holders. The transfer must include a transfer code, which should be determined by the platform, in compliance with local regulations.
    /// </remarks>
    public Task<TransferFundsResponse> PostTransferFunds(TransferFundsRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default16("/transferFunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<TransferFundsResponse>(),
            PostTransferFundsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Update a notification subscription configuration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostUpdateNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing notification subscription configuration. If you are updating the event types, you must provide all event types, otherwise the previous event type configuration will be overwritten.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostUpdateNotificationConfiguration(UpdateNotificationConfigurationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default12("/updateNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostUpdateNotificationConfigurationErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Voids a transaction.
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueVoidResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostVoidTransactionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Voids the referenced stored value transaction.
    /// </remarks>
    public Task<StoredValueVoidResponse> PostVoidTransaction(StoredValueVoidRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default5("/voidTransaction"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<StoredValueVoidResponse>(),
            PostVoidTransactionErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

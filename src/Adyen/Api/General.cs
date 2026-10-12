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
using Adyen.Requests.General;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptDisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAcceptDisputeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts a specific dispute.
    /// </remarks>
    public Task<AcceptDisputeResponse> PostAcceptDispute(PostAcceptDisputeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default22("/acceptDispute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AcceptDisputeResponse>(),
            PostAcceptDisputeError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the balances of an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolderBalanceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAccountHolderBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the account balances of an account holder. An account's balances are organized according by currencies. This mean that an account may have multiple balances: one for each currency.
    /// </remarks>
    public Task<AccountHolderBalanceResponse> PostAccountHolderBalance(PostAccountHolderBalanceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/accountHolderBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountHolderBalanceResponse>(),
            PostAccountHolderBalanceError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of transactions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolderTransactionListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAccountHolderTransactionListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transactions for an account holder's accounts. You can specify the accounts and transaction statuses to be included on the list. The call returns a maximum of 50 transactions for each account. To retrieve all transactions, you must make another call with the 'page' value incremented. Transactions are listed in chronological order, with the most recent transaction first.
    /// </remarks>
    public Task<AccountHolderTransactionListResponse> PostAccountHolderTransactionList(PostAccountHolderTransactionListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/accountHolderTransactionList"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountHolderTransactionListResponse>(),
            PostAccountHolderTransactionListError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Assign terminals
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AssignTerminalsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAssignTerminalsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Assigns one or more payment terminals to a merchant account or a store. You can also use this endpoint to reassign terminals between merchant accounts or stores, and to unassign a terminal and return it to company inventory.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<AssignTerminalsResponse> PostAssignTerminals(PostAssignTerminalsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default28("/assignTerminals"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AssignTerminalsResponse>(),
            PostAssignTerminalsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Changes the status of the payment method.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueStatusChangeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostChangeStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the status of the provided payment method to the specified status.
    /// </remarks>
    public Task<StoredValueStatusChangeResponse> PostChangeStatus(PostChangeStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/changeStatus"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueStatusChangeResponse>(),
            PostChangeStatusError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Checks the balance.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueBalanceCheckResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCheckBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Checks the balance of the provided payment method.
    /// </remarks>
    public Task<StoredValueBalanceCheckResponse> PostCheckBalance(PostCheckBalanceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/checkBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueBalanceCheckResponse>(),
            PostCheckBalanceError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Subscribe to notifications
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCreateNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a subscription to notifications informing you of events on your platform. After the subscription is created, the events specified in the configuration will be sent to the URL specified in the configuration. Subscriptions must be configured on a per-event basis (as opposed to, for example, a per-account holder basis), so all event notifications of a marketplace and of a given type will be sent to the same endpoint(s). A marketplace may have multiple endpoints if desired; an event notification may be sent to as many or as few different endpoints as configured.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostCreateNotificationConfiguration(PostCreateNotificationConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/createNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostCreateNotificationConfigurationError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create new permits linked to a recurring contract.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreatePermitResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCreatePermitError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create permits for a recurring contract, including support for defining restrictions.
    /// </remarks>
    public Task<CreatePermitResult> PostCreatePermit(PostCreatePermitRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/createPermit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreatePermitResult>(),
            PostCreatePermitError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Creates one or more test card ranges.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateTestCardRangesResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCreateTestCardRangesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates one or more test card ranges.
    /// </remarks>
    public Task<CreateTestCardRangesResult> PostCreateTestCardRanges(PostCreateTestCardRangesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default8("/createTestCardRanges"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateTestCardRangesResult>(),
            PostCreateTestCardRangesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Send a direct debit request
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DebitAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDebitAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a direct debit request to an account holder's bank account. If the direct debit is successful, the funds are settled in the accounts specified in the split instructions. Adyen sends the result of the direct debit in a <see href="https://docs.adyen.com/api-explorer/#/NotificationService/latest/post/DIRECT_DEBIT_INITIATED"><c>DIRECT_DEBIT_INITIATED</c></see> notification webhook.
    /// <para>
    ///  To learn more about direct debits, see <see href="https://docs.adyen.com/classic-platforms/top-up-accounts">Top up accounts</see>.
    /// </para>
    /// </remarks>
    public Task<DebitAccountHolderResponse> PostDebitAccountHolder(PostDebitAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/debitAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DebitAccountHolderResponse>(),
            PostDebitAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Defend a dispute
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DefendDisputeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDefendDisputeError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Defends a specific dispute.
    /// </remarks>
    public Task<DefendDisputeResponse> PostDefendDispute(PostDefendDisputeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default22("/defendDispute"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DefendDisputeResponse>(),
            PostDefendDisputeError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a defense document
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DeleteDefenseDocumentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteDisputeDefenseDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a specific dispute defense document that was supplied earlier.
    /// </remarks>
    public Task<DeleteDefenseDocumentResponse> PostDeleteDisputeDefenseDocument(PostDeleteDisputeDefenseDocumentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default22("/deleteDisputeDefenseDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DeleteDefenseDocumentResponse>(),
            PostDeleteDisputeDefenseDocumentError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Delete a notification subscription configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDeleteNotificationConfigurationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes an existing notification subscription configuration. After the subscription is deleted, no further event notifications will be sent to the URL defined in the subscription.
    /// </remarks>
    public Task<GenericResponse> PostDeleteNotificationConfigurations(PostDeleteNotificationConfigurationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/deleteNotificationConfigurations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostDeleteNotificationConfigurationsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Disable stored payment details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisableResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDisableError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables stored payment details to stop charging a shopper with this particular recurring detail ID.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/classic-integrations/classic-api-integration/tokenization/disable-stored-details">Disable stored details</see>.
    /// </para>
    /// </remarks>
    public Task<DisableResult> PostDisable(PostDisableRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/disable"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DisableResult>(),
            PostDisableError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Disable an existing permit.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DisablePermitResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostDisablePermitError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disable a permit that was previously linked to a recurringDetailReference.
    /// </remarks>
    public Task<DisablePermitResult> PostDisablePermit(PostDisablePermitRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/disablePermit"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DisablePermitResult>(),
            PostDisablePermitError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the account or store of a terminal
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FindTerminalResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostFindTerminalError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the company account, merchant account, or store that a payment terminal is assigned to.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<FindTerminalResponse> PostFindTerminal(PostFindTerminalRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default28("/findTerminal"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FindTerminalResponse>(),
            PostFindTerminalError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Check if 3D Secure is available
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ThreeDsAvailabilityResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGet3DsAvailabilityError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Verifies whether 3D Secure is available for the specified BIN or card brand. For 3D Secure 2, this endpoint also returns device fingerprinting keys.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/online-payments/3d-secure/native-3ds2">3D Secure 2</see>.
    /// </para>
    /// </remarks>
    public Task<ThreeDsAvailabilityResponse> PostGet3DsAvailability(PostGet3DsAvailabilityRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default4("/get3dsAvailability"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ThreeDsAvailabilityResponse>(),
            PostGet3DsAvailabilityError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a fees cost estimate
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CostEstimateResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetCostEstimateError"/> when the server returns an error response.</exception>
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
    public Task<CostEstimateResponse> PostGetCostEstimate(PostGetCostEstimateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default4("/getCostEstimate"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CostEstimateResponse>(),
            PostGetCostEstimateError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a notification subscription configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the configuration of a notification subscription.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostGetNotificationConfiguration(PostGetNotificationConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/getNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostGetNotificationConfigurationError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of notification subscription configurations
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationListResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetNotificationConfigurationListError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the configurations of all of the notification subscriptions in the platform of the executing user.
    /// </remarks>
    public Task<GetNotificationConfigurationListResponse> PostGetNotificationConfigurationList(PostGetNotificationConfigurationListRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/getNotificationConfigurationList"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetNotificationConfigurationListResponse>(),
            PostGetNotificationConfigurationListError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the stores of an account
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetStoresUnderAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetStoresUnderAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of stores associated with a company account or a merchant account, including the status of each store.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetStoresUnderAccountResponse> PostGetStoresUnderAccount(PostGetStoresUnderAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default28("/getStoresUnderAccount"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetStoresUnderAccountResponse>(),
            PostGetStoresUnderAccountError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the details of a terminal
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalDetailsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetTerminalDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of a payment terminal, including where the terminal is assigned to. The response returns the same details that are provided in the terminal list in your Customer Area and in the Terminal Fleet report.
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetTerminalDetailsResponse> PostGetTerminalDetails(PostGetTerminalDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default28("/getTerminalDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetTerminalDetailsResponse>(),
            PostGetTerminalDetailsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the list of terminals
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTerminalsUnderAccountResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetTerminalsUnderAccountError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of payment terminals associated with a company account, merchant account, or store. The response shows whether the terminals are in the inventory, or in-store (ready for boarding or already boarded).
    /// <para>
    /// &gt;From January 1, 2025 POS Terminal Management API is deprecated and support stops on April 1, 2025. To automate the management of your terminal fleet, use our <see href="https://docs.adyen.com/api-explorer/Management/latest/overview">Management API</see>.
    /// </para>
    /// </remarks>
    public Task<GetTerminalsUnderAccountResponse> PostGetTerminalsUnderAccount(PostGetTerminalsUnderAccountRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default28("/getTerminalsUnderAccount"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetTerminalsUnderAccountResponse>(),
            PostGetTerminalsUnderAccountError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Issues a new card.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueIssueResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostIssueError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Issues a new card of the given payment method.
    /// </remarks>
    public Task<StoredValueIssueResponse> PostIssue(PostIssueRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/issue"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueIssueResponse>(),
            PostIssueError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get stored payment details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RecurringDetailsResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostListRecurringDetailsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Lists the stored payment details for a shopper, if there are any available. The recurring detail ID can be used with a regular authorisation request to charge the shopper. A summary of the payment detail is returned for presentation to the shopper.
    /// <para>
    /// For more information, refer to <see href="https://docs.adyen.com/classic-integration/recurring-payments/retrieve-stored-details/">Retrieve stored details</see>.
    /// </para>
    /// </remarks>
    public Task<RecurringDetailsResult> PostListRecurringDetails(PostListRecurringDetailsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/listRecurringDetails"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RecurringDetailsResult>(),
            PostListRecurringDetailsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Loads the payment method.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueLoadResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostLoadError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Loads the payment method with the specified funds.
    /// </remarks>
    public Task<StoredValueLoadResponse> PostLoad(PostLoadRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/load"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueLoadResponse>(),
            PostLoadError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Merge the balance of two cards.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueBalanceMergeResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostMergeBalanceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Increases the balance of the paymentmethod by the full amount left on the source paymentmethod
    /// </remarks>
    public Task<StoredValueBalanceMergeResponse> PostMergeBalance(PostMergeBalanceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/mergeBalance"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueBalanceMergeResponse>(),
            PostMergeBalanceError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Ask issuer to notify the shopper
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="NotifyShopperResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostNotifyShopperError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends a request to the issuer so they can inform the shopper about the upcoming recurring payment. This endpoint is used only for local acquiring in India. For more information, refer to <see href="https://docs.adyen.com/payment-methods/cards/cards-recurring-india">Recurring card payments in India</see>.
    /// </remarks>
    public Task<NotifyShopperResult> PostNotifyShopper(PostNotifyShopperRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/notifyShopper"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<NotifyShopperResult>(),
            PostNotifyShopperError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Pay out from an account to the account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PayoutAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostPayoutAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Pays out a specified amount from an account to the bank account of account holder.
    /// </remarks>
    public Task<PayoutAccountHolderResponse> PostPayoutAccountHolder(PostPayoutAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/payoutAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PayoutAccountHolderResponse>(),
            PostPayoutAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund a funds transfer
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="RefundFundsTransferResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRefundFundsTransferError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds funds transferred from one account to another. Both accounts must be in the same platform, but can have different account holders.
    /// </remarks>
    public Task<RefundFundsTransferResponse> PostRefundFundsTransfer(PostRefundFundsTransferRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/refundFundsTransfer"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<RefundFundsTransferResponse>(),
            PostRefundFundsTransferError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Refund all transactions of an account since the most recent payout
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRefundNotPaidOutTransfersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Refunds all the transactions of an account that have taken place since the most recent payout. This request is on a account basis (as opposed to a payment basis), so only the portion of the payment that was made to the specified account is refunded. The commissions, fees, and payments to other accounts remain in the accounts to which they were sent as designated by the original payment's split details.
    /// </remarks>
    public Task<GenericResponse> PostRefundNotPaidOutTransfers(PostRefundNotPaidOutTransfersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/refundNotPaidOutTransfers"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostRefundNotPaidOutTransfersError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Submit a Subject Erasure Request.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubjectErasureResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRequestSubjectErasureError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Sends the PSP reference containing the shopper data that should be deleted.
    /// </remarks>
    public Task<SubjectErasureResponse> PostRequestSubjectErasure(PostRequestSubjectErasureRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default6("/requestSubjectErasure"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubjectErasureResponse>(),
            PostRequestSubjectErasureError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get applicable defense reasons
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DefenseReasonsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostRetrieveApplicableDefenseReasonsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of all applicable defense reasons to defend a specific dispute.
    /// </remarks>
    public Task<DefenseReasonsResponse> PostRetrieveApplicableDefenseReasons(PostRetrieveApplicableDefenseReasonsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default22("/retrieveApplicableDefenseReasons"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DefenseReasonsResponse>(),
            PostRetrieveApplicableDefenseReasonsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Schedule running the Account Updater
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ScheduleAccountUpdaterResult"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostScheduleAccountUpdaterError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// When making the API call, you can submit either the credit card information, or the recurring detail reference and the shopper reference:
    /// * If the card information is provided, all the sub-fields for <c>card</c> are mandatory.
    /// * If the recurring detail reference is provided, the fields for <c>shopperReference</c> and <c>selectedRecurringDetailReference</c> are mandatory.
    /// </remarks>
    public Task<ScheduleAccountUpdaterResult> PostScheduleAccountUpdater(PostScheduleAccountUpdaterRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default2("/scheduleAccountUpdater"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ScheduleAccountUpdaterResult>(),
            PostScheduleAccountUpdaterError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a communication session
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CertificateLoadingResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Establishes a secure communications session between the POS Mobile SDK and the Adyen payments platform, through mutual authentication.
    /// The request sends a setup token that identifies the SDK and the device. The response returns a session token that the SDK can use to authenticate responses received from the Adyen payments platform.
    /// &gt;This request applies to <b>mobile in-person</b> transactions. You cannot use this request to create online payments sessions.
    /// </remarks>
    public Task<CertificateLoadingResponse> PostSessions3(PostSessions3Request request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default27("/sessions"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CertificateLoadingResponse>(),
            RawErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Designate a beneficiary account and transfer the benefactor's current balance
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSetupBeneficiaryError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Defines a benefactor and a beneficiary relationship between two accounts. At the time of benefactor/beneficiary setup, the funds in the benefactor account are transferred to the beneficiary account, and any further payments to the benefactor account are automatically sent to the beneficiary account. A series of benefactor/beneficiaries may not exceed four beneficiaries and may not have a cycle in it.
    /// </remarks>
    public Task<GenericResponse> PostSetupBeneficiary(PostSetupBeneficiaryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/setupBeneficiary"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostSetupBeneficiaryError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Supply a defense document
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SupplyDefenseDocumentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSupplyDefenseDocumentError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Supplies a specific dispute defense document.
    /// </remarks>
    public Task<SupplyDefenseDocumentResponse> PostSupplyDefenseDocument(PostSupplyDefenseDocumentRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default22("/supplyDefenseDocument"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SupplyDefenseDocumentResponse>(),
            PostSupplyDefenseDocumentError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Test a notification configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TestNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTestNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Tests an existing notification subscription configuration. For each event type specified, a test notification will be generated and sent to the URL configured in the subscription specified.
    /// </remarks>
    public Task<TestNotificationConfigurationResponse> PostTestNotificationConfiguration(PostTestNotificationConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/testNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TestNotificationConfigurationResponse>(),
            PostTestNotificationConfigurationError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Transfer funds between platform accounts
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransferFundsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostTransferFundsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Transfers funds from one account to another account. Both accounts must be in the same platform, but can have different account holders. The transfer must include a transfer code, which should be determined by the platform, in compliance with local regulations.
    /// </remarks>
    public Task<TransferFundsResponse> PostTransferFunds(PostTransferFundsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default16("/transferFunds"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<TransferFundsResponse>(),
            PostTransferFundsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a notification subscription configuration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetNotificationConfigurationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUpdateNotificationConfigurationError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an existing notification subscription configuration. If you are updating the event types, you must provide all event types, otherwise the previous event type configuration will be overwritten.
    /// </remarks>
    public Task<GetNotificationConfigurationResponse> PostUpdateNotificationConfiguration(PostUpdateNotificationConfigurationRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default12("/updateNotificationConfiguration"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetNotificationConfigurationResponse>(),
            PostUpdateNotificationConfigurationError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Voids a transaction.
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="StoredValueVoidResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostVoidTransactionError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Voids the referenced stored value transaction.
    /// </remarks>
    public Task<StoredValueVoidResponse> PostVoidTransaction(PostVoidTransactionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default5("/voidTransaction"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<StoredValueVoidResponse>(),
            PostVoidTransactionError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

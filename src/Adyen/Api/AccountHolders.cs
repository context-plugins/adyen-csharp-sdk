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
using Adyen.Requests.AccountHolders;

namespace Adyen.Api;

public sealed class AccountHolders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountHolders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountHoldersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns an account holder.
    /// </remarks>
    public Task<AccountHolder> GetAccountHoldersId(GetAccountHoldersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountHolder>(),
            GetAccountHoldersIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all balance accounts of an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PaginatedBalanceAccountsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountHoldersIdBalanceAccountsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of the balance accounts associated with an account holder. To fetch multiple pages, use the query parameters.
    /// <para>
    /// For example, to limit the page to 5 balance accounts and skip the first 10, use <c>/accountHolders/{id}/balanceAccounts?limit=5&amp;offset=10</c>.
    /// </para>
    /// </remarks>
    public Task<PaginatedBalanceAccountsResponse> GetAccountHoldersIdBalanceAccounts(GetAccountHoldersIdBalanceAccountsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}/balanceAccounts"),
            [new TemplateParam("id", request.Id)],
            [new Param("offset", request.Offset), new Param("limit", request.Limit)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PaginatedBalanceAccountsResponse>(),
            GetAccountHoldersIdBalanceAccountsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get summary of tax forms for an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TaxFormSummaryResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a summary of all tax forms for an account holder.
    /// </remarks>
    public Task<TaxFormSummaryResponse> GetAccountHoldersIdTaxFormSummary(GetAccountHoldersIdTaxFormSummaryRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}/taxFormSummary"),
            [new TemplateParam("id", request.Id)],
            [new Param("formType", request.FormType)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TaxFormSummaryResponse>(),
            RawErrorResponse.Instance,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a tax form
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTaxFormResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountHoldersIdTaxFormsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a tax form for account holders operating in the US. For more information, refer to US tax forms for <see href="https://docs.adyen.com/marketplaces/us-tax-forms/">marketplaces</see> or <see href="https://docs.adyen.com/platforms/us-tax-forms/">platforms</see> .
    /// </remarks>
    public Task<GetTaxFormResponse1> GetAccountHoldersIdTaxForms(GetAccountHoldersIdTaxFormsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}/taxForms"),
            [new TemplateParam("id", request.Id)],
            [
                new Param("formType", request.FormType),
                new Param("year", request.Year),
                new Param("legalEntityId", request.LegalEntityId),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTaxFormResponse1>(),
            GetAccountHoldersIdTaxFormsError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get all transaction rules for an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="TransactionRulesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetAccountHoldersIdTransactionRulesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of transaction rules associated with an account holder.
    /// </remarks>
    public Task<TransactionRulesResponse> GetAccountHoldersIdTransactionRules(GetAccountHoldersIdTransactionRulesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}/transactionRules"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<TransactionRulesResponse>(),
            GetAccountHoldersIdTransactionRulesError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchAccountHoldersIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates an account holder. When updating an account holder resource, if a parameter is not provided in the request, it is left unchanged.
    /// </remarks>
    public Task<AccountHolder> PatchAccountHoldersId(PatchAccountHoldersIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders/{id}"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountHolder>(),
            PatchAccountHoldersIdError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountHolder"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostAccountHoldersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an account holder linked to a <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities">legal entity</see>.
    /// </remarks>
    public Task<AccountHolder> PostAccountHolders(PostAccountHoldersRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/accountHolders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AccountHolder>(),
            PostAccountHoldersError.Response,
            [new AuthSchemeAny(_auth.ClientKey, _auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Close an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CloseAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCloseAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses">status of an account holder</see> to <b>Closed</b>. This state is final. If an account holder is closed, you can't process transactions, pay out funds, or reopen it. If payments are made to an account of an account holder with a <b>Closed</b> <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status"><c>status</c></see>, the payments are sent to your liable account.
    /// </remarks>
    public Task<CloseAccountHolderResponse> PostCloseAccountHolder(PostCloseAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/closeAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CloseAccountHolderResponse>(),
            PostCloseAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Close stores
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GenericResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCloseStoresError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes stores associated with an account holder.
    /// </remarks>
    public Task<GenericResponse> PostCloseStores(PostCloseStoresRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/closeStores"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GenericResponse>(),
            PostCloseStoresError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CreateAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCreateAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an account holder that <see href="https://docs.adyen.com/classic-platforms/account-structure#your-platform">represents the sub-merchant's entity</see> in your platform. The details that you need to provide in the request depend on the sub-merchant's legal entity type. For more information, refer to <see href="https://docs.adyen.com/classic-platforms/account-holders-and-accounts#legal-entity-types">Account holder and accounts</see>.
    /// </remarks>
    public Task<CreateAccountHolderResponse> PostCreateAccountHolder(PostCreateAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/createAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CreateAccountHolderResponse>(),
            PostCreateAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of an account holder.
    /// </remarks>
    public Task<GetAccountHolderResponse> PostGetAccountHolder(PostGetAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/getAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetAccountHolderResponse>(),
            PostGetAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a tax form
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTaxFormResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostGetTaxFormError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates a tax form for account holders operating in the US. For more information, refer to <see href="https://docs.adyen.com/classic-platforms/tax-forms">Providing tax forms</see>.
    /// </remarks>
    public Task<GetTaxFormResponse> PostGetTaxForm(PostGetTaxFormRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/getTaxForm"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetTaxFormResponse>(),
            PostGetTaxFormError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Suspend an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SuspendAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostSuspendAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses">status of an account holder</see> to <b>Suspended</b>.
    /// </remarks>
    public Task<SuspendAccountHolderResponse> PostSuspendAccountHolder(PostSuspendAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/suspendAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SuspendAccountHolderResponse>(),
            PostSuspendAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Unsuspend an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UnSuspendAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUnSuspendAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Changes the <see href="https://docs.adyen.com/classic-platforms/account-holders-and-accounts#account-holder-statuses">status of an account holder</see> from <b>Suspended</b> to <b>Inactive</b>.
    /// Account holders can have a <b>Suspended</b> <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status"><c>status</c></see> if you suspend them through the <see href="https://docs.adyen.com/api-explorer/#/Account/v5/post/suspendAccountHolder"><c>/suspendAccountHolder</c></see> endpoint or if a verification deadline expires.
    /// <para>
    /// You can only unsuspend account holders if they do not have verification checks with a <b>FAILED</b> <see href="https://docs.adyen.com/api-explorer/#/Account/latest/post/getAccountHolder__resParam_verification-accountHolder-checks-status"><c>status</c></see>.
    /// </para>
    /// </remarks>
    public Task<UnSuspendAccountHolderResponse> PostUnSuspendAccountHolder(PostUnSuspendAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/unSuspendAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UnSuspendAccountHolderResponse>(),
            PostUnSuspendAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="UpdateAccountHolderResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUpdateAccountHolderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the <c>accountHolderDetails</c> and <c>processingTier</c> of an account holder, and adds bank accounts and shareholders.
    /// <para>
    /// When updating <c>accountHolderDetails</c>, parameters that are not included in the request are left unchanged except for the following object:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>metadata</c>: Updating the metadata replaces the entire object. This means that to update an existing key-value pair, you must provide the changes, as well as other existing key-value pairs.</description></item>
    /// </list>
    /// <para>
    /// When updating any field in the following objects, you must submit all the fields required for validation:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>address</c></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>fullPhoneNumber</c></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>bankAccountDetails.BankAccountDetail</c></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>businessDetails.shareholders.ShareholderContact</c></description></item>
    /// </list>
    /// <para>
    ///  For example, to update the <c>address.postalCode</c>, you must also submit the <c>address.country</c>, <c>.city</c>, <c>.street</c>, <c>.postalCode</c>, and possibly <c>.stateOrProvince</c> so that the address can be validated.
    /// </para>
    /// <para>
    /// To add a bank account or shareholder, provide the bank account or shareholder details without a <c>bankAccountUUID</c> or a <c>shareholderCode</c>.
    /// </para>
    /// </remarks>
    public Task<UpdateAccountHolderResponse> PostUpdateAccountHolder(PostUpdateAccountHolderRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/updateAccountHolder"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<UpdateAccountHolderResponse>(),
            PostUpdateAccountHolderError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update payout or processing state
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAccountHolderStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostUpdateAccountHolderStateError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Disables or enables the processing or payout state of an account holder.
    /// </remarks>
    public Task<GetAccountHolderStatusResponse> PostUpdateAccountHolderState(PostUpdateAccountHolderStateRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default10("/updateAccountHolderState"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetAccountHolderStatusResponse>(),
            PostUpdateAccountHolderStateError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

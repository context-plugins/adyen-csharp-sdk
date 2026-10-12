using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Authentication;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;
using Adyen.Requests.DonationCampaigns;

namespace Adyen.Api;

public sealed class DonationCampaigns
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal DonationCampaigns(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Delete a donation campaign
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the donation campaign specified in the path. This request is only allowed if the campaign has the status <b>inactive</b>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/campaignManagement/{donationCampaignId}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("donationCampaignId", request.DonationCampaignId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get the donation campaigns for an account holder
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDonationCampaignsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of donation campaigns associated with the account holder specified in the path. You can filter the list by campaign status.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Campaign Management read
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<ListDonationCampaignsResponse> GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/campaignManagement/accountHolders/{accountHolderId}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("accountHolderId", request.AccountHolderId),
            ],
            [
                new Param("status", request.Status),
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDonationCampaignsResponse>(),
            GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Update a donation campaign
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates the properties of the donation campaign specified in the path. Note the following restrictions:
    /// <list type="bullet">
    ///   <item><description>You cannot use a PATCH request to update the campaign status. To activate or end a campaign, make a POST request to the <c>/campaignManagement/{campaignId}/status/{status}</c> endpoint.</description></item>
    ///   <item><description>You get a validation error if you add account holders that are not compatible with the nonprofit.</description></item>
    /// </list>
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<DonationCampaign1> PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/campaignManagement/{donationCampaignId}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("donationCampaignId", request.DonationCampaignId),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DonationCampaign1>(),
            PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a donation campaign
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCompaniesCompanyIdCampaignManagementError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new donation campaign, to give shoppers the option to donate to a nonprofit organization when making a payment. A campaign can be for online payments, in-person payments, or both online and in-person payments.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<DonationCampaign1> PostCompaniesCompanyIdCampaignManagement(PostCompaniesCompanyIdCampaignManagementRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/campaignManagement"),
            [new TemplateParam("companyId", request.CompanyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<DonationCampaign1>(),
            PostCompaniesCompanyIdCampaignManagementError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Activate or end a donation campaign
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts or stops the donation campaign specified in the path, by providing a path parameter.
    /// Use the path parameter <b>activate</b> to start an inactive campaign, or <b>end</b> to stop an active campaign. Other status transitions are not allowed.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<DonationCampaign1> PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/campaignManagement/{donationCampaignId}/status/{status}"),
            [
                new TemplateParam("companyId", request.CompanyId),
                new TemplateParam("donationCampaignId", request.DonationCampaignId),
                new TemplateParam("status", request.Status),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DonationCampaign1>(),
            PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get a list of nonprofits
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListNonprofitsResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostCompaniesCompanyIdNonprofitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of supported nonprofit organizations to choose from when creating a donation campaign. The list only contains nonprofits that are compatible with all the account holders specified in the request.
    /// </remarks>
    public Task<ListNonprofitsResponse> PostCompaniesCompanyIdNonprofits(PostCompaniesCompanyIdNonprofitsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default9("/companies/{companyId}/nonprofits"),
            [new TemplateParam("companyId", request.CompanyId)],
            [
                new Param("searchTerm", request.SearchTerm),
                new Param("pageNumber", request.PageNumber),
                new Param("pageSize", request.PageSize),
                new Param("goal", request.Goal),
            ],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<ListNonprofitsResponse>(),
            PostCompaniesCompanyIdNonprofitsError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

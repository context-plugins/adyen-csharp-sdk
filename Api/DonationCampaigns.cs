using System;
using System.Collections.Generic;
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
using Adyen.Models.Enums;

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
    /// delete-companies-companyId-campaignManagement-donationCampaignId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="donationCampaignId">The unique identifier of the donation campaign to be deleted.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Removes the donation campaign specified in the path. This request is only allowed if the campaign has the status <b>inactive</b>.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task DeleteCompaniesCompanyIdCampaignManagementDonationCampaignId(string companyId,
        string donationCampaignId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/campaignManagement/{donationCampaignId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("donationCampaignId", donationCampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteCompaniesCompanyIdCampaignManagementDonationCampaignIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-campaignManagement-accountHolders-accountHolderId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="accountHolderId">The unique identifier of the account holder.</param>
    /// <param name="status">The campaign status to return campaigns that match. Allowed values: <b>inactive</b>, <b>active</b>, or <b>ended</b>.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListDonationCampaignsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a paginated list of donation campaigns associated with the account holder specified in the path. You can filter the list by campaign status.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Campaign Management read
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<ListDonationCampaignsResponse> GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderId(string companyId,
        string accountHolderId,
        string? status,
        int? pageNumber = 1,
        int? pageSize = 10,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/campaignManagement/accountHolders/{accountHolderId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("accountHolderId", accountHolderId)],
            [new Param("status", status), new Param("pageNumber", pageNumber), new Param("pageSize", pageSize)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<ListDonationCampaignsResponse>(),
            GetCompaniesCompanyIdCampaignManagementAccountHoldersAccountHolderIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-companies-companyId-campaignManagement-donationCampaignId
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="donationCampaignId">The unique identifier of the donation campaign to be updated.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdError"/> when the server returns an error response.</exception>
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
    public Task<DonationCampaign1> PatchCompaniesCompanyIdCampaignManagementDonationCampaignId(string companyId,
        string donationCampaignId,
        DonationCampaignUpdate? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/campaignManagement/{donationCampaignId}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("donationCampaignId", donationCampaignId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<DonationCampaign1>(),
            PatchCompaniesCompanyIdCampaignManagementDonationCampaignIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-campaignManagement
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdCampaignManagementError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates a new donation campaign, to give shoppers the option to donate to a nonprofit organization when making a payment. A campaign can be for online payments, in-person payments, or both online and in-person payments.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<DonationCampaign1> PostCompaniesCompanyIdCampaignManagement(string companyId,
        DonationCampaignRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/campaignManagement"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<DonationCampaign1>(),
            PostCompaniesCompanyIdCampaignManagementErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-campaignManagement-donationCampaignId-status-status
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="donationCampaignId">The unique identifier of the donation campaign to activate or end.</param>
    /// <param name="status">The desired status change. Possible values: <b>activate</b> or <b>end</b>.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="DonationCampaign1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Starts or stops the donation campaign specified in the path, by providing a path parameter.
    /// Use the path parameter <b>activate</b> to start an inactive campaign, or <b>end</b> to stop an active campaign. Other status transitions are not allowed.
    /// <para>
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Campaign Management read and write
    /// </para>
    /// </remarks>
    public Task<DonationCampaign1> PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatus(string companyId,
        string donationCampaignId,
        CampaignStatusTransition1 status,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/campaignManagement/{donationCampaignId}/status/{status}"),
            [new TemplateParam("companyId", companyId),
                new TemplateParam("donationCampaignId", donationCampaignId),
                new TemplateParam("status", status)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<DonationCampaign1>(),
            PostCompaniesCompanyIdCampaignManagementDonationCampaignIdStatusStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-nonprofits
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="searchTerm">A query to return nonprofit organizations for, maximum 100 characters. For example, <c>&amp;searchTerm=clean%20water</c>.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="goal">One or more United Nations Sustainable Development Goals to return nonprofit organizations for. Format: <c>unsdg_&lt;number&gt;</c>, for example, <c>&amp;goal=unsdg_6&amp;goal=unsdg_2</c>.</param>
    /// <param name="body"></param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 10 items on a page.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ListNonprofitsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdNonprofitsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of supported nonprofit organizations to choose from when creating a donation campaign. The list only contains nonprofits that are compatible with all the account holders specified in the request.
    /// </remarks>
    public Task<ListNonprofitsResponse> PostCompaniesCompanyIdNonprofits(string companyId,
        string? searchTerm,
        int? pageNumber,
        IReadOnlyList<string>? goal,
        ListNonprofitsRequest? body,
        int? pageSize = 10,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/nonprofits"),
            [new TemplateParam("companyId", companyId)],
            [new Param("searchTerm", searchTerm),
                new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize),
                new Param("goal", goal)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<ListNonprofitsResponse>(),
            PostCompaniesCompanyIdNonprofitsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

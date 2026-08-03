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

namespace Adyen.Api;

public sealed class AndroidFilesCompanyLevel
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AndroidFilesCompanyLevel(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-companies-companyId-androidApps
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
    /// <param name="packageName">The package name that uniquely identifies the Android app.</param>
    /// <param name="versionCode">The version number of the app.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidAppsResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdAndroidAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the Android apps that are available for the company identified in the path.
    /// These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidAppsResponse> GetCompaniesCompanyIdAndroidApps(string companyId,
        int? pageNumber,
        int? pageSize,
        string? packageName,
        int? versionCode,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidApps"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize),
                new Param("packageName", packageName),
                new Param("versionCode", versionCode)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidAppsResponse>(),
            GetCompaniesCompanyIdAndroidAppsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-androidApps-id
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="id">The unique identifier of the app.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidApp"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdAndroidAppsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the Android app identified in the path.
    /// These apps have been uploaded to Adyen and can be installed or uninstalled on Android payment terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidApp> GetCompaniesCompanyIdAndroidAppsId(string companyId,
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidApps/{id}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidApp>(),
            GetCompaniesCompanyIdAndroidAppsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-companies-companyId-androidCertificates
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="pageNumber">The number of the page to fetch.</param>
    /// <param name="pageSize">The number of items to have on a page, maximum 100. The default is 20 items on a page.</param>
    /// <param name="certificateName">The name of the certificate.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AndroidCertificatesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetCompaniesCompanyIdAndroidCertificatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of the Android certificates that are available for the company identified in the path.
    /// Typically, these certificates enable running apps on Android payment terminals. The certificates in the list have been uploaded to Adyen and can be installed or uninstalled on Android terminals through <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management/terminal-actions-api">terminal actions</see>.
    /// <para>
    /// To make this request, your API credential must have one of the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">roles</see>:
    /// * Management API—Android files read
    /// * Management API—Android files read and write
    /// * Management API—Terminal actions read
    /// * Management API—Terminal actions read and write
    /// </para>
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<AndroidCertificatesResponse> GetCompaniesCompanyIdAndroidCertificates(string companyId,
        int? pageNumber,
        int? pageSize,
        string? certificateName,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidCertificates"),
            [new TemplateParam("companyId", companyId)],
            [new Param("pageNumber", pageNumber),
                new Param("pageSize", pageSize),
                new Param("certificateName", certificateName)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AndroidCertificatesResponse>(),
            GetCompaniesCompanyIdAndroidCertificatesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// patch-companies-companyId-androidApps-id
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="id">The unique identifier of the app.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="ReprocessAndroidAppResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchCompaniesCompanyIdAndroidAppsIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Reuploads the Android app identified in the path.
    /// To make this request, your API credential must have this <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Android files read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// &gt;By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.
    /// </para>
    /// </remarks>
    public Task<ReprocessAndroidAppResponse> PatchCompaniesCompanyIdAndroidAppsId(string companyId,
        string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidApps/{id}"),
            [new TemplateParam("companyId", companyId), new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            EmptyBody.Instance,
            JsonResponse.Create<ReprocessAndroidAppResponse>(),
            PatchCompaniesCompanyIdAndroidAppsIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-androidApps
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityReference"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdAndroidAppsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads an Android APK file to Adyen.
    /// The maximum APK file size is 200 MB.
    /// To make this request, your API credential must have the following <see href="https://docs.adyen.com/development-resources/api-credentials#api-permissions">role</see>:
    /// * Management API—Android files read and write
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// &gt;By choosing to upload, install, or run any third-party applications on an Adyen payment terminal, you accept full responsibility and liability for any consequences of uploading, installing, or running any such applications.
    /// </para>
    /// </remarks>
    public Task<EntityReference> PostCompaniesCompanyIdAndroidApps(string companyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidApps"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<EntityReference>(),
            PostCompaniesCompanyIdAndroidAppsErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-companies-companyId-androidCertificates
    /// </summary>
    /// <param name="companyId">The unique identifier of the company account.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="EntityReference"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostCompaniesCompanyIdAndroidCertificatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Uploads an Android Certificate file to Adyen.
    /// <para>
    /// In the live environment, requests to this endpoint are subject to <see href="https://docs.adyen.com/point-of-sale/automating-terminal-management#rate-limits-in-the-live-environment">rate limits</see>.
    /// </para>
    /// </remarks>
    public Task<EntityReference> PostCompaniesCompanyIdAndroidCertificates(string companyId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/companies/{companyId}/androidCertificates"),
            [new TemplateParam("companyId", companyId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            EmptyBody.Instance,
            JsonResponse.Create<EntityReference>(),
            PostCompaniesCompanyIdAndroidCertificatesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

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

public sealed class TermsOfService
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal TermsOfService(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get accepted Terms of Service document
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity. For sole proprietorship, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.</param>
    /// <param name="termsofserviceacceptancereference">An Adyen-generated reference for the accepted Terms of Service.</param>
    /// <param name="termsOfServiceDocumentFormat">The format of the Terms of Service document. Possible values: <b>JSON</b>, <b>PDF</b>, or <b>TXT</b></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAcceptedTermsOfServiceDocumentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the accepted Terms of Service document for a legal entity.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<GetAcceptedTermsOfServiceDocumentResponse> GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(string id,
        string termsofserviceacceptancereference,
        string? termsOfServiceDocumentFormat,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference}"),
            [new TemplateParam("id", id),
                new TemplateParam("termsofserviceacceptancereference", termsofserviceacceptancereference)],
            [new Param("termsOfServiceDocumentFormat", termsOfServiceDocumentFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAcceptedTermsOfServiceDocumentResponse>(),
            GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get Terms of Service information for a legal entity
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTermsOfServiceAcceptanceInfosResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns Terms of Service information for a legal entity.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<GetTermsOfServiceAcceptanceInfosResponse> GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/termsOfServiceAcceptanceInfos"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTermsOfServiceAcceptanceInfosResponse>(),
            GetLegalEntitiesIdTermsOfServiceAcceptanceInfosErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get Terms of Service status
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateTermsOfServiceStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLegalEntitiesIdTermsOfServiceStatusError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the required types of Terms of Service that need to be accepted by a legal entity.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<CalculateTermsOfServiceStatusResponse> GetLegalEntitiesIdTermsOfServiceStatus(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/termsOfServiceStatus"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CalculateTermsOfServiceStatusResponse>(),
            GetLegalEntitiesIdTermsOfServiceStatusErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Accept Terms of Service
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity.  For sole proprietorships, this is the individual legal entity ID of the owner.  For organizations, this is the ID of the organization.  For legal representatives of individuals, this is the ID of the individual.</param>
    /// <param name="termsofservicedocumentid">The unique identifier of the Terms of Service document.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptTermsOfServiceResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Accepts Terms of Service.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<AcceptTermsOfServiceResponse> PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(string id,
        string termsofservicedocumentid,
        AcceptTermsOfServiceRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/termsOfService/{termsofservicedocumentid}"),
            [new TemplateParam("id", id), new TemplateParam("termsofservicedocumentid", termsofservicedocumentid)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<AcceptTermsOfServiceResponse>(),
            PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get Terms of Service document
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity. For sole proprietorships, this is the individual legal entity ID of the owner. For organizations, this is the ID of the organization.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTermsOfServiceDocumentResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLegalEntitiesIdTermsOfServiceError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the Terms of Service document for a legal entity.
    /// <para>
    /// Requests to this endpoint are subject to rate limits:
    /// </para>
    /// <list type="bullet">
    ///   <item><description>Live environments: 700 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Test environments: 200 requests per 5 seconds.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>Failed requests are subject to a limit of 5 failures per 10 seconds.</description></item>
    /// </list>
    /// </remarks>
    public Task<GetTermsOfServiceDocumentResponse> PostLegalEntitiesIdTermsOfService(string id,
        GetTermsOfServiceDocumentRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/termsOfService"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GetTermsOfServiceDocumentResponse>(),
            PostLegalEntitiesIdTermsOfServiceErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

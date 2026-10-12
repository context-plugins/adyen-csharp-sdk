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
using Adyen.Requests.TermsOfService;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetAcceptedTermsOfServiceDocumentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError"/> when the server returns an error response.</exception>
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
    public Task<GetAcceptedTermsOfServiceDocumentResponse> GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereference(GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/acceptedTermsOfServiceDocument/{termsofserviceacceptancereference}"),
            [
                new TemplateParam("id", request.Id),
                new TemplateParam("termsofserviceacceptancereference", request.Termsofserviceacceptancereference),
            ],
            [new Param("termsOfServiceDocumentFormat", request.TermsOfServiceDocumentFormat)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetAcceptedTermsOfServiceDocumentResponse>(),
            GetLegalEntitiesIdAcceptedTermsOfServiceDocumentTermsofserviceacceptancereferenceError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Terms of Service information for a legal entity
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTermsOfServiceAcceptanceInfosResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError"/> when the server returns an error response.</exception>
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
    public Task<GetTermsOfServiceAcceptanceInfosResponse> GetLegalEntitiesIdTermsOfServiceAcceptanceInfos(GetLegalEntitiesIdTermsOfServiceAcceptanceInfosRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/termsOfServiceAcceptanceInfos"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetTermsOfServiceAcceptanceInfosResponse>(),
            GetLegalEntitiesIdTermsOfServiceAcceptanceInfosError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Terms of Service status
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculateTermsOfServiceStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLegalEntitiesIdTermsOfServiceStatusError"/> when the server returns an error response.</exception>
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
    public Task<CalculateTermsOfServiceStatusResponse> GetLegalEntitiesIdTermsOfServiceStatus(GetLegalEntitiesIdTermsOfServiceStatusRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/termsOfServiceStatus"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<CalculateTermsOfServiceStatusResponse>(),
            GetLegalEntitiesIdTermsOfServiceStatusError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Accept Terms of Service
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AcceptTermsOfServiceResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError"/> when the server returns an error response.</exception>
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
    public Task<AcceptTermsOfServiceResponse> PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentid(PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/termsOfService/{termsofservicedocumentid}"),
            [
                new TemplateParam("id", request.Id),
                new TemplateParam("termsofservicedocumentid", request.Termsofservicedocumentid),
            ],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<AcceptTermsOfServiceResponse>(),
            PatchLegalEntitiesIdTermsOfServiceTermsofservicedocumentidError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get Terms of Service document
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetTermsOfServiceDocumentResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostLegalEntitiesIdTermsOfServiceError"/> when the server returns an error response.</exception>
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
    public Task<GetTermsOfServiceDocumentResponse> PostLegalEntitiesIdTermsOfService(PostLegalEntitiesIdTermsOfServiceRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/termsOfService"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GetTermsOfServiceDocumentResponse>(),
            PostLegalEntitiesIdTermsOfServiceError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

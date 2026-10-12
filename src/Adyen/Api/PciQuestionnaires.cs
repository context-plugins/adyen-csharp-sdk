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
using Adyen.Requests.PciQuestionnaires;

namespace Adyen.Api;

public sealed class PciQuestionnaires
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PciQuestionnaires(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get PCI questionnaire details
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciQuestionnaireInfosResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLegalEntitiesIdPciQuestionnairesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Get a list of signed PCI questionnaires.
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
    public Task<GetPciQuestionnaireInfosResponse> GetLegalEntitiesIdPciQuestionnaires(GetLegalEntitiesIdPciQuestionnairesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/pciQuestionnaires"),
            [new TemplateParam("id", request.Id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPciQuestionnaireInfosResponse>(),
            GetLegalEntitiesIdPciQuestionnairesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get PCI questionnaire
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciQuestionnaireResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="GetLegalEntitiesIdPciQuestionnairesPciidError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the signed PCI questionnaire.
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
    public Task<GetPciQuestionnaireResponse> GetLegalEntitiesIdPciQuestionnairesPciid(GetLegalEntitiesIdPciQuestionnairesPciidRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/pciQuestionnaires/{pciid}"),
            [new TemplateParam("id", request.Id), new TemplateParam("pciid", request.Pciid)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPciQuestionnaireResponse>(),
            GetLegalEntitiesIdPciQuestionnairesPciidError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Generate PCI questionnaire
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeneratePciDescriptionResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Generates the required PCI questionnaires based on the user's <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines__reqParam_salesChannels">salesChannel</see>.
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
    public Task<GeneratePciDescriptionResponse> PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/pciQuestionnaires/generatePciTemplates"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<GeneratePciDescriptionResponse>(),
            PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Sign PCI questionnaire
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PciSigningResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Signs the required PCI questionnaire.
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
    public Task<PciSigningResponse> PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/pciQuestionnaires/signPciTemplates"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<PciSigningResponse>(),
            PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Calculate PCI status of a legal entity
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculatePciStatusResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesSigningRequiredError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Calculate PCI status of a legal entity.
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
    public Task<CalculatePciStatusResponse> PostLegalEntitiesIdPciQuestionnairesSigningRequired(PostLegalEntitiesIdPciQuestionnairesSigningRequiredRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default18("/legalEntities/{id}/pciQuestionnaires/signingRequired"),
            [new TemplateParam("id", request.Id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<CalculatePciStatusResponse>(),
            PostLegalEntitiesIdPciQuestionnairesSigningRequiredError.Response,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            cancellationToken);
}

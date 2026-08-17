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
    /// <param name="id">The unique identifier of the legal entity to get PCI questionnaire information.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciQuestionnaireInfosResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLegalEntitiesIdPciQuestionnairesError"/> when the server returns an error response.</exception>
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
    public Task<GetPciQuestionnaireInfosResponse> GetLegalEntitiesIdPciQuestionnaires(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/pciQuestionnaires"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPciQuestionnaireInfosResponse>(),
            GetLegalEntitiesIdPciQuestionnairesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Get PCI questionnaire
    /// </summary>
    /// <param name="id">The legal entity ID of the individual who signed the PCI questionnaire.</param>
    /// <param name="pciid">The unique identifier of the signed PCI questionnaire.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GetPciQuestionnaireResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetLegalEntitiesIdPciQuestionnairesPciidError"/> when the server returns an error response.</exception>
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
    public Task<GetPciQuestionnaireResponse> GetLegalEntitiesIdPciQuestionnairesPciid(string id,
        string pciid,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/pciQuestionnaires/{pciid}"),
            [new TemplateParam("id", id), new TemplateParam("pciid", pciid)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<GetPciQuestionnaireResponse>(),
            GetLegalEntitiesIdPciQuestionnairesPciidErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Generate PCI questionnaire
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity to get PCI questionnaire information.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="GeneratePciDescriptionResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesError"/> when the server returns an error response.</exception>
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
    public Task<GeneratePciDescriptionResponse> PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplates(string id,
        GeneratePciDescriptionRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/pciQuestionnaires/generatePciTemplates"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<GeneratePciDescriptionResponse>(),
            PostLegalEntitiesIdPciQuestionnairesGeneratePciTemplatesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Sign PCI questionnaire
    /// </summary>
    /// <param name="id">The legal entity ID of the user that has a contractual relationship with your platform.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PciSigningResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesError"/> when the server returns an error response.</exception>
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
    public Task<PciSigningResponse> PostLegalEntitiesIdPciQuestionnairesSignPciTemplates(string id,
        PciSigningRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/pciQuestionnaires/signPciTemplates"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<PciSigningResponse>(),
            PostLegalEntitiesIdPciQuestionnairesSignPciTemplatesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// Calculate PCI status of a legal entity
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity to calculate PCI status.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="CalculatePciStatusResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLegalEntitiesIdPciQuestionnairesSigningRequiredError"/> when the server returns an error response.</exception>
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
    public Task<CalculatePciStatusResponse> PostLegalEntitiesIdPciQuestionnairesSigningRequired(string id,
        CalculatePciStatusRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default18("/legalEntities/{id}/pciQuestionnaires/signingRequired"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<CalculatePciStatusResponse>(),
            PostLegalEntitiesIdPciQuestionnairesSigningRequiredErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

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

public sealed class HostedOnboarding
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal HostedOnboarding(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// get-themes
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnboardingThemes"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetThemesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a list of hosted onboarding page themes.
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
    public Task<OnboardingThemes> GetThemes(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/themes"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnboardingThemes>(),
            GetThemesErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// get-themes-id
    /// </summary>
    /// <param name="id">The unique identifier of the theme</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnboardingTheme"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="GetThemesIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the details of the theme identified in the path.
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
    public Task<OnboardingTheme> GetThemesId(string id,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/themes/{id}"),
            [new TemplateParam("id", id)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<OnboardingTheme>(),
            GetThemesIdErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);

    /// <summary>
    /// post-legalEntities-id-onboardingLinks
    /// </summary>
    /// <param name="id">The unique identifier of the legal entity</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="OnboardingLink"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostLegalEntitiesIdOnboardingLinksError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a link to an Adyen-hosted onboarding page where you need to redirect your user.
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
    public Task<OnboardingLink> PostLegalEntitiesIdOnboardingLinks(string id,
        OnboardingLinkInfo? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/legalEntities/{id}/onboardingLinks"),
            [new TemplateParam("id", id)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<OnboardingLink>(),
            PostLegalEntitiesIdOnboardingLinksErrorResponse.Instance,
            [new AuthSchemeAny(_auth.BasicAuth, _auth.ApiKeyAuth)],
            requestOptions,
            ct);
}

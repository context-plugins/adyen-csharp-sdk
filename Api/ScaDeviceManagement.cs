using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core;
using Adyen.Core.Exceptions;
using Adyen.Core.Models;
using Adyen.Core.Request;
using Adyen.Core.Response;
using Adyen.Errors;
using Adyen.Models;

namespace Adyen.Api;

public sealed class ScaDeviceManagement
{
    private readonly RawClient _rawClient;
    private readonly Server _server;

    internal ScaDeviceManagement(RawClient rawClient, Server server)
    {
        _rawClient = rawClient;
        _server = server;
    }

    /// <summary>
    /// Delete an SCA device
    /// </summary>
    /// <param name="deviceId">The unique identifier of the SCA device to delete.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteScaDevicesDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task DeleteScaDevicesDeviceId(string deviceId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaDevices/{deviceId}"),
            [new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteScaDevicesDeviceIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Finish registration process for a SCA device
    /// </summary>
    /// <param name="deviceId">The unique identifier of the SCA device that you are associating with a resource.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinishScaDeviceRegistrationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PatchScaDevicesDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Finishes the registration process for a new Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task<FinishScaDeviceRegistrationResponse> PatchScaDevicesDeviceId(string deviceId,
        FinishScaDeviceRegistrationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaDevices/{deviceId}"),
            [new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<FinishScaDeviceRegistrationResponse>(),
            PatchScaDevicesDeviceIdErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Begin SCA device registration
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeginScaDeviceRegistrationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostScaDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Begins the registration process for a new Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task<BeginScaDeviceRegistrationResponse> PostScaDevices(BeginScaDeviceRegistrationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaDevices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<BeginScaDeviceRegistrationResponse>(),
            PostScaDevicesErrorResponse.Instance,
            [],
            requestOptions,
            ct);

    /// <summary>
    /// Create a new SCA association for a device
    /// </summary>
    /// <param name="deviceId">The unique identifier of the SCA device that you are associating with a resource.</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitScaAssociationResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostScaDevicesDeviceIdScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an association between an SCA-enabled device and an entity, such as an account holder. This action does not guarantee the association is immediately ready for use; its status may be <c>pendingApproval</c> if the account holder has existing devices.
    /// </remarks>
    public Task<SubmitScaAssociationResponse> PostScaDevicesDeviceIdScaAssociations(string deviceId,
        SubmitScaAssociationRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default13("/scaDevices/{deviceId}/scaAssociations"),
            [new TemplateParam("deviceId", deviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<SubmitScaAssociationResponse>(),
            PostScaDevicesDeviceIdScaAssociationsErrorResponse.Instance,
            [],
            requestOptions,
            ct);
}

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
using Adyen.Requests.ScaDeviceManagement;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteScaDevicesDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Deletes a Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task DeleteScaDevicesDeviceId(DeleteScaDevicesDeviceIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaDevices/{deviceId}"),
            [new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteScaDevicesDeviceIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Finish registration process for a SCA device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="FinishScaDeviceRegistrationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PatchScaDevicesDeviceIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Finishes the registration process for a new Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task<FinishScaDeviceRegistrationResponse> PatchScaDevicesDeviceId(PatchScaDevicesDeviceIdRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaDevices/{deviceId}"),
            [new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(request.Body),
            JsonResponse.Create<FinishScaDeviceRegistrationResponse>(),
            PatchScaDevicesDeviceIdError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Begin SCA device registration
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="BeginScaDeviceRegistrationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostScaDevicesError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Begins the registration process for a new Strong Customer Authentication (SCA) device.
    /// </remarks>
    public Task<BeginScaDeviceRegistrationResponse> PostScaDevices(PostScaDevicesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaDevices"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<BeginScaDeviceRegistrationResponse>(),
            PostScaDevicesError.Response,
            [],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Create a new SCA association for a device
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="SubmitScaAssociationResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="PostScaDevicesDeviceIdScaAssociationsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Creates an association between an SCA-enabled device and an entity, such as an account holder. This action does not guarantee the association is immediately ready for use; its status may be <c>pendingApproval</c> if the account holder has existing devices.
    /// </remarks>
    public Task<SubmitScaAssociationResponse> PostScaDevicesDeviceIdScaAssociations(PostScaDevicesDeviceIdScaAssociationsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default13("/scaDevices/{deviceId}/scaAssociations"),
            [new TemplateParam("deviceId", request.DeviceId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(request.Body),
            JsonResponse.Create<SubmitScaAssociationResponse>(),
            PostScaDevicesDeviceIdScaAssociationsError.Response,
            [],
            requestOptions,
            cancellationToken);
}

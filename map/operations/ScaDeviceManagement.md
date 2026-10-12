<!-- Generated file — do not edit; regenerated with the SDK. -->

# ScaDeviceManagement — operations

Accessor: `client.ScaDeviceManagement` · Source: `src/Adyen/Api/ScaDeviceManagement.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteScaDevicesDeviceId

- **Server group**: `Default13`
- **Signature**: `DeleteScaDevicesDeviceId(DeleteScaDevicesDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteScaDevicesDeviceIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteScaDevicesDeviceIdRequest` | `src/Adyen/Requests/ScaDeviceManagement/DeleteScaDevicesDeviceIdRequest.cs` |
| `DeleteScaDevicesDeviceIdError` | `src/Adyen/Errors/DeleteScaDevicesDeviceIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchScaDevicesDeviceId

- **Server group**: `Default13`
- **Signature**: `PatchScaDevicesDeviceId(PatchScaDevicesDeviceIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `FinishScaDeviceRegistrationResponse`
- **Error**: `ApiException<PatchScaDevicesDeviceIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchScaDevicesDeviceIdRequest` | `src/Adyen/Requests/ScaDeviceManagement/PatchScaDevicesDeviceIdRequest.cs` |
| `FinishScaDeviceRegistrationRequest` | `src/Adyen/Models/FinishScaDeviceRegistrationRequest.cs` |
| `FinishScaDeviceRegistrationResponse` | `src/Adyen/Models/FinishScaDeviceRegistrationResponse.cs` |
| `PatchScaDevicesDeviceIdError` | `src/Adyen/Errors/PatchScaDevicesDeviceIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostScaDevices

- **Server group**: `Default13`
- **Signature**: `PostScaDevices(PostScaDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BeginScaDeviceRegistrationResponse`
- **Error**: `ApiException<PostScaDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostScaDevicesRequest` | `src/Adyen/Requests/ScaDeviceManagement/PostScaDevicesRequest.cs` |
| `BeginScaDeviceRegistrationRequest` | `src/Adyen/Models/BeginScaDeviceRegistrationRequest.cs` |
| `BeginScaDeviceRegistrationResponse` | `src/Adyen/Models/BeginScaDeviceRegistrationResponse.cs` |
| `PostScaDevicesError` | `src/Adyen/Errors/PostScaDevicesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostScaDevicesDeviceIdScaAssociations

- **Server group**: `Default13`
- **Signature**: `PostScaDevicesDeviceIdScaAssociations(PostScaDevicesDeviceIdScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `SubmitScaAssociationResponse`
- **Error**: `ApiException<PostScaDevicesDeviceIdScaAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostScaDevicesDeviceIdScaAssociationsRequest` | `src/Adyen/Requests/ScaDeviceManagement/PostScaDevicesDeviceIdScaAssociationsRequest.cs` |
| `SubmitScaAssociationRequest` | `src/Adyen/Models/SubmitScaAssociationRequest.cs` |
| `SubmitScaAssociationResponse` | `src/Adyen/Models/SubmitScaAssociationResponse.cs` |
| `PostScaDevicesDeviceIdScaAssociationsError` | `src/Adyen/Errors/PostScaDevicesDeviceIdScaAssociationsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


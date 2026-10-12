<!-- Generated file — do not edit; regenerated with the SDK. -->

# ManageScaDevices — operations

Accessor: `client.ManageScaDevices` · Source: `src/Adyen/Api/ManageScaDevices.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteRegisteredDevicesId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteRegisteredDevicesId(DeleteRegisteredDevicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `PaymentInstrumentId`
- **Query params (wire ← C#)**: `paymentInstrumentId` ← `PaymentInstrumentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteRegisteredDevicesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteRegisteredDevicesIdRequest` | `src/Adyen/Requests/ManageScaDevices/DeleteRegisteredDevicesIdRequest.cs` |
| `DeleteRegisteredDevicesIdError` | `src/Adyen/Errors/DeleteRegisteredDevicesIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetRegisteredDevices

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetRegisteredDevices(GetRegisteredDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentInstrumentId`
- **Query params (wire ← C#)**: `paymentInstrumentId` ← `PaymentInstrumentId`, `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `SearchRegisteredDevicesResponse`
- **Error**: `ApiException<GetRegisteredDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRegisteredDevicesRequest` | `src/Adyen/Requests/ManageScaDevices/GetRegisteredDevicesRequest.cs` |
| `SearchRegisteredDevicesResponse` | `src/Adyen/Models/SearchRegisteredDevicesResponse.cs` |
| `GetRegisteredDevicesError` | `src/Adyen/Errors/GetRegisteredDevicesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchRegisteredDevicesDeviceIdAssociations

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchRegisteredDevicesDeviceIdAssociations(PatchRegisteredDevicesDeviceIdAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `AssociationFinaliseResponse`
- **Error**: `ApiException<PatchRegisteredDevicesDeviceIdAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchRegisteredDevicesDeviceIdAssociationsRequest` | `src/Adyen/Requests/ManageScaDevices/PatchRegisteredDevicesDeviceIdAssociationsRequest.cs` |
| `AssociationFinaliseRequest` | `src/Adyen/Models/AssociationFinaliseRequest.cs` |
| `AssociationFinaliseResponse` | `src/Adyen/Models/AssociationFinaliseResponse.cs` |
| `PatchRegisteredDevicesDeviceIdAssociationsError` | `src/Adyen/Errors/PatchRegisteredDevicesDeviceIdAssociationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchRegisteredDevicesId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchRegisteredDevicesId(PatchRegisteredDevicesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `RegisterScaFinalResponse`
- **Error**: `ApiException<PatchRegisteredDevicesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchRegisteredDevicesIdRequest` | `src/Adyen/Requests/ManageScaDevices/PatchRegisteredDevicesIdRequest.cs` |
| `RegisterScaRequest` | `src/Adyen/Models/RegisterScaRequest.cs` |
| `RegisterScaFinalResponse` | `src/Adyen/Models/RegisterScaFinalResponse.cs` |
| `PatchRegisteredDevicesIdError` | `src/Adyen/Errors/PatchRegisteredDevicesIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostRegisteredDevices

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRegisteredDevices(PostRegisteredDevicesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `RegisterScaResponse`
- **Error**: `ApiException<PostRegisteredDevicesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRegisteredDevicesRequest` | `src/Adyen/Requests/ManageScaDevices/PostRegisteredDevicesRequest.cs` |
| `RegisterScaRequest` | `src/Adyen/Models/RegisterScaRequest.cs` |
| `RegisterScaResponse` | `src/Adyen/Models/RegisterScaResponse.cs` |
| `PostRegisteredDevicesError` | `src/Adyen/Errors/PostRegisteredDevicesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostRegisteredDevicesDeviceIdAssociations

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRegisteredDevicesDeviceIdAssociations(PostRegisteredDevicesDeviceIdAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DeviceId`
- **Returns**: `AssociationInitiateResponse`
- **Error**: `ApiException<PostRegisteredDevicesDeviceIdAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRegisteredDevicesDeviceIdAssociationsRequest` | `src/Adyen/Requests/ManageScaDevices/PostRegisteredDevicesDeviceIdAssociationsRequest.cs` |
| `AssociationInitiateRequest` | `src/Adyen/Models/AssociationInitiateRequest.cs` |
| `AssociationInitiateResponse` | `src/Adyen/Models/AssociationInitiateResponse.cs` |
| `PostRegisteredDevicesDeviceIdAssociationsError` | `src/Adyen/Errors/PostRegisteredDevicesDeviceIdAssociationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |


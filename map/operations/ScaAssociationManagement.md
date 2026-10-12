<!-- Generated file — do not edit; regenerated with the SDK. -->

# ScaAssociationManagement — operations

Accessor: `client.ScaAssociationManagement` · Source: `src/Adyen/Api/ScaAssociationManagement.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteScaAssociations

- **Server group**: `Default13`
- **Signature**: `DeleteScaAssociations(DeleteScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WwwAuthenticate`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteScaAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteScaAssociationsRequest` | `src/Adyen/Requests/ScaAssociationManagement/DeleteScaAssociationsRequest.cs` |
| `RemoveAssociationRequest` | `src/Adyen/Models/RemoveAssociationRequest.cs` |
| `DeleteScaAssociationsError` | `src/Adyen/Errors/DeleteScaAssociationsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetScaAssociations

- **Server group**: `Default13`
- **Signature**: `GetScaAssociations(GetScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `EntityType`, `EntityId`, `PageSize`, `PageNumber`
- **Query params (wire ← C#)**: `entityType` ← `EntityType`, `entityId` ← `EntityId`, `pageSize` ← `PageSize`, `pageNumber` ← `PageNumber`
- **Returns**: `ListAssociationsResponse`
- **Error**: `ApiException<GetScaAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetScaAssociationsRequest` | `src/Adyen/Requests/ScaAssociationManagement/GetScaAssociationsRequest.cs` |
| `ScaEntityType` | `src/Adyen/Models/Enums/ScaEntityType.cs` |
| `ListAssociationsResponse` | `src/Adyen/Models/ListAssociationsResponse.cs` |
| `GetScaAssociationsError` | `src/Adyen/Errors/GetScaAssociationsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchScaAssociations

- **Server group**: `Default13`
- **Signature**: `PatchScaAssociations(PatchScaAssociationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WwwAuthenticate`
- **Returns**: `ApproveAssociationResponse`
- **Error**: `ApiException<PatchScaAssociationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchScaAssociationsRequest` | `src/Adyen/Requests/ScaAssociationManagement/PatchScaAssociationsRequest.cs` |
| `ApproveAssociationRequest` | `src/Adyen/Models/ApproveAssociationRequest.cs` |
| `ApproveAssociationResponse` | `src/Adyen/Models/ApproveAssociationResponse.cs` |
| `PatchScaAssociationsError` | `src/Adyen/Errors/PatchScaAssociationsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


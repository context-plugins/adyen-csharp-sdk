<!-- Generated file — do not edit; regenerated with the SDK. -->

# RaiseDisputes — operations

Accessor: `client.RaiseDisputes` · Source: `src/Adyen/Api/RaiseDisputes.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetDisputes

- **Server group**: `Default23`
- **Signature**: `GetDisputes(GetDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `paymentInstrument` ← `PaymentInstrument`, `createdSince` ← `CreatedSince`, `createdUntil` ← `CreatedUntil`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `IReadOnlyList<IReadOnlyList<DisputeResponse>>`
- **Error**: `ApiException<GetDisputesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisputesRequest` | `src/Adyen/Requests/RaiseDisputes/GetDisputesRequest.cs` |
| `DisputeResponse` | `src/Adyen/Models/DisputeResponse.cs` |
| `GetDisputesError` | `src/Adyen/Errors/GetDisputesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetDisputesId

- **Server group**: `Default23`
- **Signature**: `GetDisputesId(GetDisputesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DisputeResponse`
- **Error**: `ApiException<GetDisputesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisputesIdRequest` | `src/Adyen/Requests/RaiseDisputes/GetDisputesIdRequest.cs` |
| `DisputeResponse` | `src/Adyen/Models/DisputeResponse.cs` |
| `GetDisputesIdError` | `src/Adyen/Errors/GetDisputesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchDisputesId

- **Server group**: `Default23`
- **Signature**: `PatchDisputesId(PatchDisputesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `DisputeResponse`
- **Error**: `ApiException<PatchDisputesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchDisputesIdRequest` | `src/Adyen/Requests/RaiseDisputes/PatchDisputesIdRequest.cs` |
| `PatchableDisputeRequest` | `src/Adyen/Models/PatchableDisputeRequest.cs` |
| `DisputeResponse` | `src/Adyen/Models/DisputeResponse.cs` |
| `PatchDisputesIdError` | `src/Adyen/Errors/PatchDisputesIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostDisputes

- **Server group**: `Default23`
- **Signature**: `PostDisputes(PostDisputesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `DisputeResponse`
- **Error**: `ApiException<PostDisputesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDisputesRequest` | `src/Adyen/Requests/RaiseDisputes/PostDisputesRequest.cs` |
| `DisputeRequest` | `src/Adyen/Models/DisputeRequest.cs` |
| `DisputeResponse` | `src/Adyen/Models/DisputeResponse.cs` |
| `PostDisputesError` | `src/Adyen/Errors/PostDisputesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferLimitsBalancePlatformLevel — operations

Accessor: `client.TransferLimitsBalancePlatformLevel` · Source: `src/Adyen/Api/TransferLimitsBalancePlatformLevel.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalancePlatformsIdTransferLimitsTransferLimitId

- **Server group**: `Default13`
- **Signature**: `DeleteBalancePlatformsIdTransferLimitsTransferLimitId(DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TransferLimitId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest` | `src/Adyen/Requests/TransferLimitsBalancePlatformLevel/DeleteBalancePlatformsIdTransferLimitsTransferLimitIdRequest.cs` |
| `DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError` | `src/Adyen/Errors/DeleteBalancePlatformsIdTransferLimitsTransferLimitIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsIdTransferLimits

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsIdTransferLimits(GetBalancePlatformsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `scope` ← `Scope`, `transferType` ← `TransferType`, `status` ← `Status`
- **Returns**: `TransferLimitListResponse`
- **Error**: `ApiException<GetBalancePlatformsIdTransferLimitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsIdTransferLimitsRequest` | `src/Adyen/Requests/TransferLimitsBalancePlatformLevel/GetBalancePlatformsIdTransferLimitsRequest.cs` |
| `Scope` | `src/Adyen/Models/Enums/Scope.cs` |
| `TransferType` | `src/Adyen/Models/Enums/TransferType.cs` |
| `LimitStatus` | `src/Adyen/Models/Enums/LimitStatus.cs` |
| `TransferLimitListResponse` | `src/Adyen/Models/TransferLimitListResponse.cs` |
| `GetBalancePlatformsIdTransferLimitsError` | `src/Adyen/Errors/GetBalancePlatformsIdTransferLimitsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalancePlatformsIdTransferLimitsTransferLimitId

- **Server group**: `Default13`
- **Signature**: `GetBalancePlatformsIdTransferLimitsTransferLimitId(GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TransferLimitId`
- **Returns**: `TransferLimit`
- **Error**: `ApiException<GetBalancePlatformsIdTransferLimitsTransferLimitIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest` | `src/Adyen/Requests/TransferLimitsBalancePlatformLevel/GetBalancePlatformsIdTransferLimitsTransferLimitIdRequest.cs` |
| `TransferLimit` | `src/Adyen/Models/TransferLimit.cs` |
| `GetBalancePlatformsIdTransferLimitsTransferLimitIdError` | `src/Adyen/Errors/GetBalancePlatformsIdTransferLimitsTransferLimitIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalancePlatformsIdTransferLimits

- **Server group**: `Default13`
- **Signature**: `PostBalancePlatformsIdTransferLimits(PostBalancePlatformsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TransferLimit`
- **Error**: `ApiException<PostBalancePlatformsIdTransferLimitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalancePlatformsIdTransferLimitsRequest` | `src/Adyen/Requests/TransferLimitsBalancePlatformLevel/PostBalancePlatformsIdTransferLimitsRequest.cs` |
| `CreateTransferLimitRequest` | `src/Adyen/Models/CreateTransferLimitRequest.cs` |
| `TransferLimit` | `src/Adyen/Models/TransferLimit.cs` |
| `PostBalancePlatformsIdTransferLimitsError` | `src/Adyen/Errors/PostBalancePlatformsIdTransferLimitsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


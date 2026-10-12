<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransferLimitsBalanceAccountLevel — operations

Accessor: `client.TransferLimitsBalanceAccountLevel` · Source: `src/Adyen/Api/TransferLimitsBalanceAccountLevel.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBalanceAccountsIdTransferLimitsTransferLimitId

- **Server group**: `Default13`
- **Signature**: `DeleteBalanceAccountsIdTransferLimitsTransferLimitId(DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TransferLimitId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/DeleteBalanceAccountsIdTransferLimitsTransferLimitIdRequest.cs` |
| `DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError` | `src/Adyen/Errors/DeleteBalanceAccountsIdTransferLimitsTransferLimitIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsIdTransferLimits

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsIdTransferLimits(GetBalanceAccountsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `scope` ← `Scope`, `transferType` ← `TransferType`, `status` ← `Status`
- **Returns**: `TransferLimitListResponse`
- **Error**: `ApiException<GetBalanceAccountsIdTransferLimitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdTransferLimitsRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsRequest.cs` |
| `Scope` | `src/Adyen/Models/Enums/Scope.cs` |
| `TransferType` | `src/Adyen/Models/Enums/TransferType.cs` |
| `LimitStatus` | `src/Adyen/Models/Enums/LimitStatus.cs` |
| `TransferLimitListResponse` | `src/Adyen/Models/TransferLimitListResponse.cs` |
| `GetBalanceAccountsIdTransferLimitsError` | `src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsIdTransferLimitsCurrent

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsIdTransferLimitsCurrent(GetBalanceAccountsIdTransferLimitsCurrentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `scope` ← `Scope`, `transferType` ← `TransferType`
- **Returns**: `TransferLimitListResponse`
- **Error**: `ApiException<GetBalanceAccountsIdTransferLimitsCurrentError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdTransferLimitsCurrentRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsCurrentRequest.cs` |
| `Scope` | `src/Adyen/Models/Enums/Scope.cs` |
| `TransferType` | `src/Adyen/Models/Enums/TransferType.cs` |
| `TransferLimitListResponse` | `src/Adyen/Models/TransferLimitListResponse.cs` |
| `GetBalanceAccountsIdTransferLimitsCurrentError` | `src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsCurrentError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceAccountsIdTransferLimitsTransferLimitId

- **Server group**: `Default13`
- **Signature**: `GetBalanceAccountsIdTransferLimitsTransferLimitId(GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TransferLimitId`
- **Returns**: `TransferLimit`
- **Error**: `ApiException<GetBalanceAccountsIdTransferLimitsTransferLimitIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/GetBalanceAccountsIdTransferLimitsTransferLimitIdRequest.cs` |
| `TransferLimit` | `src/Adyen/Models/TransferLimit.cs` |
| `GetBalanceAccountsIdTransferLimitsTransferLimitIdError` | `src/Adyen/Errors/GetBalanceAccountsIdTransferLimitsTransferLimitIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalanceAccountsIdTransferLimits

- **Server group**: `Default13`
- **Signature**: `PostBalanceAccountsIdTransferLimits(PostBalanceAccountsIdTransferLimitsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `TransferLimit`
- **Error**: `ApiException<PostBalanceAccountsIdTransferLimitsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsIdTransferLimitsRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/PostBalanceAccountsIdTransferLimitsRequest.cs` |
| `CreateTransferLimitRequest` | `src/Adyen/Models/CreateTransferLimitRequest.cs` |
| `TransferLimit` | `src/Adyen/Models/TransferLimit.cs` |
| `PostBalanceAccountsIdTransferLimitsError` | `src/Adyen/Errors/PostBalanceAccountsIdTransferLimitsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostBalanceAccountsIdTransferLimitsApprove

- **Server group**: `Default13`
- **Signature**: `PostBalanceAccountsIdTransferLimitsApprove(PostBalanceAccountsIdTransferLimitsApproveRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostBalanceAccountsIdTransferLimitsApproveError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsIdTransferLimitsApproveRequest` | `src/Adyen/Requests/TransferLimitsBalanceAccountLevel/PostBalanceAccountsIdTransferLimitsApproveRequest.cs` |
| `ApproveTransferLimitRequest` | `src/Adyen/Models/ApproveTransferLimitRequest.cs` |
| `PostBalanceAccountsIdTransferLimitsApproveError` | `src/Adyen/Errors/PostBalanceAccountsIdTransferLimitsApproveError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


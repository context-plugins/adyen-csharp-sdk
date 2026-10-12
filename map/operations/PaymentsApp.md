<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentsApp — operations

Accessor: `client.PaymentsApp` · Source: `src/Adyen/Api/PaymentsApp.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdPaymentsApps

- **Server group**: `Default26`
- **Signature**: `GetMerchantsMerchantIdPaymentsApps(GetMerchantsMerchantIdPaymentsAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `statuses` ← `Statuses`, `limit` ← `Limit`, `offset` ← `Offset`
- **Returns**: `PaymentsAppResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdPaymentsAppsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdPaymentsAppsRequest` | `src/Adyen/Requests/PaymentsApp/GetMerchantsMerchantIdPaymentsAppsRequest.cs` |
| `PaymentsAppResponse` | `src/Adyen/Models/PaymentsAppResponse.cs` |
| `GetMerchantsMerchantIdPaymentsAppsError` | `src/Adyen/Errors/GetMerchantsMerchantIdPaymentsAppsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetMerchantsMerchantIdStoresStoreIdPaymentsApps

- **Server group**: `Default26`
- **Signature**: `GetMerchantsMerchantIdStoresStoreIdPaymentsApps(GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`
- **Query params (wire ← C#)**: `statuses` ← `Statuses`, `limit` ← `Limit`, `offset` ← `Offset`
- **Returns**: `PaymentsAppResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest` | `src/Adyen/Requests/PaymentsApp/GetMerchantsMerchantIdStoresStoreIdPaymentsAppsRequest.cs` |
| `PaymentsAppResponse` | `src/Adyen/Models/PaymentsAppResponse.cs` |
| `GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError` | `src/Adyen/Errors/GetMerchantsMerchantIdStoresStoreIdPaymentsAppsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken

- **Server group**: `Default26`
- **Signature**: `PostMerchantsMerchantIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Body`
- **Returns**: `BoardingTokenResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest` | `src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenRequest.cs` |
| `BoardingTokenRequest` | `src/Adyen/Models/BoardingTokenRequest.cs` |
| `BoardingTokenResponse` | `src/Adyen/Models/BoardingTokenResponse.cs` |
| `PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError` | `src/Adyen/Errors/PostMerchantsMerchantIdGeneratePaymentsAppBoardingTokenError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke

- **Server group**: `Default26`
- **Signature**: `PostMerchantsMerchantIdPaymentsAppsInstallationIdRevoke(PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `InstallationId`
- **Returns**: `JsonElement`
- **Error**: `ApiException<PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest` | `src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeRequest.cs` |
| `PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError` | `src/Adyen/Errors/PostMerchantsMerchantIdPaymentsAppsInstallationIdRevokeError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken

- **Server group**: `Default26`
- **Signature**: `PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingToken(PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`, `Body`
- **Returns**: `BoardingTokenResponse`
- **Error**: `ApiException<PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest` | `src/Adyen/Requests/PaymentsApp/PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenRequest.cs` |
| `BoardingTokenRequest` | `src/Adyen/Models/BoardingTokenRequest.cs` |
| `BoardingTokenResponse` | `src/Adyen/Models/BoardingTokenResponse.cs` |
| `PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError` | `src/Adyen/Errors/PostMerchantsMerchantIdStoresStoreIdGeneratePaymentsAppBoardingTokenError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |


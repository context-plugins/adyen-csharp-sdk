<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountStoreLevel — operations

Accessor: `client.AccountStoreLevel` · Source: `src/Adyen/Api/AccountStoreLevel.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdStores

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdStores(GetMerchantsMerchantIdStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `reference` ← `Reference`
- **Returns**: `ListStoresResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdStoresRequest` | `src/Adyen/Requests/AccountStoreLevel/GetMerchantsMerchantIdStoresRequest.cs` |
| `ListStoresResponse` | `src/Adyen/Models/ListStoresResponse.cs` |
| `GetMerchantsMerchantIdStoresError` | `src/Adyen/Errors/GetMerchantsMerchantIdStoresError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdStoresStoreId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdStoresStoreId(GetMerchantsMerchantIdStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<GetMerchantsMerchantIdStoresStoreIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdStoresStoreIdRequest` | `src/Adyen/Requests/AccountStoreLevel/GetMerchantsMerchantIdStoresStoreIdRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `GetMerchantsMerchantIdStoresStoreIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdStoresStoreIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetStores

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStores(GetStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`, `reference` ← `Reference`, `merchantId` ← `MerchantId`
- **Returns**: `ListStoresResponse`
- **Error**: `ApiException<GetStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoresRequest` | `src/Adyen/Requests/AccountStoreLevel/GetStoresRequest.cs` |
| `ListStoresResponse` | `src/Adyen/Models/ListStoresResponse.cs` |
| `GetStoresError` | `src/Adyen/Errors/GetStoresError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetStoresStoreId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoresStoreId(GetStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<GetStoresStoreIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetStoresStoreIdRequest` | `src/Adyen/Requests/AccountStoreLevel/GetStoresStoreIdRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `GetStoresStoreIdError` | `src/Adyen/Errors/GetStoresStoreIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdStoresStoreId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdStoresStoreId(PatchMerchantsMerchantIdStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<PatchMerchantsMerchantIdStoresStoreIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdStoresStoreIdRequest` | `src/Adyen/Requests/AccountStoreLevel/PatchMerchantsMerchantIdStoresStoreIdRequest.cs` |
| `UpdateStoreRequest` | `src/Adyen/Models/UpdateStoreRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `PatchMerchantsMerchantIdStoresStoreIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdStoresStoreIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchStoresStoreId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchStoresStoreId(PatchStoresStoreIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoreId`
- **Returns**: `Store`
- **Error**: `ApiException<PatchStoresStoreIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchStoresStoreIdRequest` | `src/Adyen/Requests/AccountStoreLevel/PatchStoresStoreIdRequest.cs` |
| `UpdateStoreRequest` | `src/Adyen/Models/UpdateStoreRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `PatchStoresStoreIdError` | `src/Adyen/Errors/PatchStoresStoreIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdStores

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdStores(PostMerchantsMerchantIdStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `Store`
- **Error**: `ApiException<PostMerchantsMerchantIdStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdStoresRequest` | `src/Adyen/Requests/AccountStoreLevel/PostMerchantsMerchantIdStoresRequest.cs` |
| `StoreCreationRequest` | `src/Adyen/Models/StoreCreationRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `PostMerchantsMerchantIdStoresError` | `src/Adyen/Errors/PostMerchantsMerchantIdStoresError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostStores

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostStores(PostStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Store`
- **Error**: `ApiException<PostStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostStoresRequest` | `src/Adyen/Requests/AccountStoreLevel/PostStoresRequest.cs` |
| `StoreCreationWithMerchantCodeRequest` | `src/Adyen/Models/StoreCreationWithMerchantCodeRequest.cs` |
| `Store` | `src/Adyen/Models/Store.cs` |
| `PostStoresError` | `src/Adyen/Errors/PostStoresError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |


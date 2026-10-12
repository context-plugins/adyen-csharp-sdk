<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalOrdersMerchantLevel — operations

Accessor: `client.TerminalOrdersMerchantLevel` · Source: `src/Adyen/Api/TerminalOrdersMerchantLevel.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetMerchantsMerchantIdBillingEntities

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdBillingEntities(GetMerchantsMerchantIdBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `BillingEntitiesResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdBillingEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdBillingEntitiesRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdBillingEntitiesRequest.cs` |
| `BillingEntitiesResponse` | `src/Adyen/Models/BillingEntitiesResponse.cs` |
| `GetMerchantsMerchantIdBillingEntitiesError` | `src/Adyen/Errors/GetMerchantsMerchantIdBillingEntitiesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdShippingLocations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdShippingLocations(GetMerchantsMerchantIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `name` ← `Name`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `ShippingLocationsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdShippingLocationsRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdShippingLocationsRequest.cs` |
| `ShippingLocationsResponse` | `src/Adyen/Models/ShippingLocationsResponse.cs` |
| `GetMerchantsMerchantIdShippingLocationsError` | `src/Adyen/Errors/GetMerchantsMerchantIdShippingLocationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdTerminalModels

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalModels(GetMerchantsMerchantIdTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalModelsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalModelsRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalModelsRequest.cs` |
| `TerminalModelsResponse` | `src/Adyen/Models/TerminalModelsResponse.cs` |
| `GetMerchantsMerchantIdTerminalModelsError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalModelsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdTerminalOrders

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalOrders(GetMerchantsMerchantIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Query params (wire ← C#)**: `customerOrderReference` ← `CustomerOrderReference`, `status` ← `Status`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalOrdersResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalOrdersRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalOrdersRequest.cs` |
| `TerminalOrdersResponse` | `src/Adyen/Models/TerminalOrdersResponse.cs` |
| `GetMerchantsMerchantIdTerminalOrdersError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalOrdersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdTerminalOrdersOrderId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalOrdersOrderId(GetMerchantsMerchantIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalOrdersOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalOrdersOrderIdRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalOrdersOrderIdRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `GetMerchantsMerchantIdTerminalOrdersOrderIdError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalOrdersOrderIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetMerchantsMerchantIdTerminalProducts

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetMerchantsMerchantIdTerminalProducts(GetMerchantsMerchantIdTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `Country`
- **Query params (wire ← C#)**: `country` ← `Country`, `terminalModelId` ← `TerminalModelId`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalProductsResponse`
- **Error**: `ApiException<GetMerchantsMerchantIdTerminalProductsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetMerchantsMerchantIdTerminalProductsRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/GetMerchantsMerchantIdTerminalProductsRequest.cs` |
| `TerminalProductsResponse` | `src/Adyen/Models/TerminalProductsResponse.cs` |
| `GetMerchantsMerchantIdTerminalProductsError` | `src/Adyen/Errors/GetMerchantsMerchantIdTerminalProductsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchMerchantsMerchantIdTerminalOrdersOrderId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchMerchantsMerchantIdTerminalOrdersOrderId(PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PatchMerchantsMerchantIdTerminalOrdersOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/PatchMerchantsMerchantIdTerminalOrdersOrderIdRequest.cs` |
| `TerminalOrderRequest` | `src/Adyen/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PatchMerchantsMerchantIdTerminalOrdersOrderIdError` | `src/Adyen/Errors/PatchMerchantsMerchantIdTerminalOrdersOrderIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdShippingLocations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdShippingLocations(PostMerchantsMerchantIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `ShippingLocation`
- **Error**: `ApiException<PostMerchantsMerchantIdShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdShippingLocationsRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdShippingLocationsRequest.cs` |
| `ShippingLocation` | `src/Adyen/Models/ShippingLocation.cs` |
| `PostMerchantsMerchantIdShippingLocationsError` | `src/Adyen/Errors/PostMerchantsMerchantIdShippingLocationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdTerminalOrders

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdTerminalOrders(PostMerchantsMerchantIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PostMerchantsMerchantIdTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdTerminalOrdersRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdTerminalOrdersRequest.cs` |
| `TerminalOrderRequest` | `src/Adyen/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PostMerchantsMerchantIdTerminalOrdersError` | `src/Adyen/Errors/PostMerchantsMerchantIdTerminalOrdersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostMerchantsMerchantIdTerminalOrdersOrderIdCancel

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostMerchantsMerchantIdTerminalOrdersOrderIdCancel(PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest` | `src/Adyen/Requests/TerminalOrdersMerchantLevel/PostMerchantsMerchantIdTerminalOrdersOrderIdCancelRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError` | `src/Adyen/Errors/PostMerchantsMerchantIdTerminalOrdersOrderIdCancelError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |


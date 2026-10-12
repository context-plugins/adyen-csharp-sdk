<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalOrdersCompanyLevel — operations

Accessor: `client.TerminalOrdersCompanyLevel` · Source: `src/Adyen/Api/TerminalOrdersCompanyLevel.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCompaniesCompanyIdBillingEntities

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdBillingEntities(GetCompaniesCompanyIdBillingEntitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `BillingEntitiesResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdBillingEntitiesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdBillingEntitiesRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdBillingEntitiesRequest.cs` |
| `BillingEntitiesResponse` | `src/Adyen/Models/BillingEntitiesResponse.cs` |
| `GetCompaniesCompanyIdBillingEntitiesError` | `src/Adyen/Errors/GetCompaniesCompanyIdBillingEntitiesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdShippingLocations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdShippingLocations(GetCompaniesCompanyIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `name` ← `Name`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `ShippingLocationsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdShippingLocationsRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdShippingLocationsRequest.cs` |
| `ShippingLocationsResponse` | `src/Adyen/Models/ShippingLocationsResponse.cs` |
| `GetCompaniesCompanyIdShippingLocationsError` | `src/Adyen/Errors/GetCompaniesCompanyIdShippingLocationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalModels

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalModels(GetCompaniesCompanyIdTerminalModelsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalModelsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalModelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalModelsRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalModelsRequest.cs` |
| `TerminalModelsResponse` | `src/Adyen/Models/TerminalModelsResponse.cs` |
| `GetCompaniesCompanyIdTerminalModelsError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalModelsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalOrders

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalOrders(GetCompaniesCompanyIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Query params (wire ← C#)**: `customerOrderReference` ← `CustomerOrderReference`, `status` ← `Status`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalOrdersResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalOrdersRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalOrdersRequest.cs` |
| `TerminalOrdersResponse` | `src/Adyen/Models/TerminalOrdersResponse.cs` |
| `GetCompaniesCompanyIdTerminalOrdersError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalOrdersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalOrdersOrderId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalOrdersOrderId(GetCompaniesCompanyIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalOrdersOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalOrdersOrderIdRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalOrdersOrderIdRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `GetCompaniesCompanyIdTerminalOrdersOrderIdError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalOrdersOrderIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCompaniesCompanyIdTerminalProducts

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCompaniesCompanyIdTerminalProducts(GetCompaniesCompanyIdTerminalProductsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `Country`
- **Query params (wire ← C#)**: `country` ← `Country`, `terminalModelId` ← `TerminalModelId`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `TerminalProductsResponse`
- **Error**: `ApiException<GetCompaniesCompanyIdTerminalProductsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCompaniesCompanyIdTerminalProductsRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/GetCompaniesCompanyIdTerminalProductsRequest.cs` |
| `TerminalProductsResponse` | `src/Adyen/Models/TerminalProductsResponse.cs` |
| `GetCompaniesCompanyIdTerminalProductsError` | `src/Adyen/Errors/GetCompaniesCompanyIdTerminalProductsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchCompaniesCompanyIdTerminalOrdersOrderId

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchCompaniesCompanyIdTerminalOrdersOrderId(PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PatchCompaniesCompanyIdTerminalOrdersOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/PatchCompaniesCompanyIdTerminalOrdersOrderIdRequest.cs` |
| `TerminalOrderRequest` | `src/Adyen/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PatchCompaniesCompanyIdTerminalOrdersOrderIdError` | `src/Adyen/Errors/PatchCompaniesCompanyIdTerminalOrdersOrderIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdShippingLocations

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdShippingLocations(PostCompaniesCompanyIdShippingLocationsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `ShippingLocation`
- **Error**: `ApiException<PostCompaniesCompanyIdShippingLocationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdShippingLocationsRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdShippingLocationsRequest.cs` |
| `ShippingLocation` | `src/Adyen/Models/ShippingLocation.cs` |
| `PostCompaniesCompanyIdShippingLocationsError` | `src/Adyen/Errors/PostCompaniesCompanyIdShippingLocationsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdTerminalOrders

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdTerminalOrders(PostCompaniesCompanyIdTerminalOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PostCompaniesCompanyIdTerminalOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdTerminalOrdersRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdTerminalOrdersRequest.cs` |
| `TerminalOrderRequest` | `src/Adyen/Models/TerminalOrderRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PostCompaniesCompanyIdTerminalOrdersError` | `src/Adyen/Errors/PostCompaniesCompanyIdTerminalOrdersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCompaniesCompanyIdTerminalOrdersOrderIdCancel

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCompaniesCompanyIdTerminalOrdersOrderIdCancel(PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyId`, `OrderId`
- **Returns**: `TerminalOrder`
- **Error**: `ApiException<PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest` | `src/Adyen/Requests/TerminalOrdersCompanyLevel/PostCompaniesCompanyIdTerminalOrdersOrderIdCancelRequest.cs` |
| `TerminalOrder` | `src/Adyen/Models/TerminalOrder.cs` |
| `PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError` | `src/Adyen/Errors/PostCompaniesCompanyIdTerminalOrdersOrderIdCancelError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |


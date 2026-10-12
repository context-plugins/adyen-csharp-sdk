<!-- Generated file — do not edit; regenerated with the SDK. -->

# CardOrders — operations

Accessor: `client.CardOrders` · Source: `src/Adyen/Api/CardOrders.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCardorders

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCardorders(GetCardordersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `id` ← `Id`, `cardManufacturingProfileId` ← `CardManufacturingProfileId`, `status` ← `Status`, `txVariantCode` ← `TxVariantCode`, `createdSince` ← `CreatedSince`, `createdUntil` ← `CreatedUntil`, `lockedSince` ← `LockedSince`, `lockedUntil` ← `LockedUntil`, `serviceCenter` ← `ServiceCenter`, `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `PaginatedGetCardOrderResponse`
- **Error**: `ApiException<GetCardordersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCardordersRequest` | `src/Adyen/Requests/CardOrders/GetCardordersRequest.cs` |
| `PaginatedGetCardOrderResponse` | `src/Adyen/Models/PaginatedGetCardOrderResponse.cs` |
| `GetCardordersError` | `src/Adyen/Errors/GetCardordersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetCardordersIdItems

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetCardordersIdItems(GetCardordersIdItemsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `PaginatedGetCardOrderItemResponse`
- **Error**: `ApiException<GetCardordersIdItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCardordersIdItemsRequest` | `src/Adyen/Requests/CardOrders/GetCardordersIdItemsRequest.cs` |
| `PaginatedGetCardOrderItemResponse` | `src/Adyen/Models/PaginatedGetCardOrderItemResponse.cs` |
| `GetCardordersIdItemsError` | `src/Adyen/Errors/GetCardordersIdItemsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |


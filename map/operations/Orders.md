<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `src/Adyen/Api/Orders.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostOrders

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostOrders(PostOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateOrderResponse`
- **Error**: `ApiException<PostOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrdersRequest` | `src/Adyen/Requests/Orders/PostOrdersRequest.cs` |
| `CreateOrderRequest` | `src/Adyen/Models/CreateOrderRequest.cs` |
| `CreateOrderResponse` | `src/Adyen/Models/CreateOrderResponse.cs` |
| `PostOrdersError` | `src/Adyen/Errors/PostOrdersError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostOrdersCancel

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostOrdersCancel(PostOrdersCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CancelOrderResponse`
- **Error**: `ApiException<PostOrdersCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrdersCancelRequest` | `src/Adyen/Requests/Orders/PostOrdersCancelRequest.cs` |
| `CancelOrderRequest` | `src/Adyen/Models/CancelOrderRequest.cs` |
| `CancelOrderResponse` | `src/Adyen/Models/CancelOrderResponse.cs` |
| `PostOrdersCancelError` | `src/Adyen/Errors/PostOrdersCancelError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentMethodsBalance

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentMethodsBalance(PostPaymentMethodsBalanceRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BalanceCheckResponse`
- **Error**: `ApiException<PostPaymentMethodsBalanceError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentMethodsBalanceRequest` | `src/Adyen/Requests/Orders/PostPaymentMethodsBalanceRequest.cs` |
| `BalanceCheckRequest` | `src/Adyen/Models/BalanceCheckRequest.cs` |
| `BalanceCheckResponse` | `src/Adyen/Models/BalanceCheckResponse.cs` |
| `PostPaymentMethodsBalanceError` | `src/Adyen/Errors/PostPaymentMethodsBalanceError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |


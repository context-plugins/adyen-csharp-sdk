<!-- Generated file — do not edit; regenerated with the SDK. -->

# RecurringApi — operations

Accessor: `client.RecurringApi` · Source: `src/Adyen/Api/RecurringApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteStoredPaymentMethodsStoredPaymentMethodId

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteStoredPaymentMethodsStoredPaymentMethodId(DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StoredPaymentMethodId`, `ShopperReference`, `MerchantAccount`
- **Query params (wire ← C#)**: `shopperReference` ← `ShopperReference`, `merchantAccount` ← `MerchantAccount`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest` | `src/Adyen/Requests/RecurringApi/DeleteStoredPaymentMethodsStoredPaymentMethodIdRequest.cs` |

### GetStoredPaymentMethods

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetStoredPaymentMethods(GetStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `shopperReference` ← `ShopperReference`, `merchantAccount` ← `MerchantAccount`
- **Returns**: `ListStoredPaymentMethodsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetStoredPaymentMethodsRequest` | `src/Adyen/Requests/RecurringApi/GetStoredPaymentMethodsRequest.cs` |
| `ListStoredPaymentMethodsResponse` | `src/Adyen/Models/ListStoredPaymentMethodsResponse.cs` |

### PostForward

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostForward(PostForwardRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CheckoutForwardResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostForwardRequest` | `src/Adyen/Requests/RecurringApi/PostForwardRequest.cs` |
| `CheckoutForwardRequest` | `src/Adyen/Models/CheckoutForwardRequest.cs` |
| `CheckoutForwardResponse` | `src/Adyen/Models/CheckoutForwardResponse.cs` |

### PostStoredPaymentMethods

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostStoredPaymentMethods(PostStoredPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredPaymentMethodResource`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostStoredPaymentMethodsRequest` | `src/Adyen/Requests/RecurringApi/PostStoredPaymentMethodsRequest.cs` |
| `StoredPaymentMethodRequest` | `src/Adyen/Models/StoredPaymentMethodRequest.cs` |
| `StoredPaymentMethodResource` | `src/Adyen/Models/StoredPaymentMethodResource.cs` |


<!-- Generated file — do not edit; regenerated with the SDK. -->

# PaymentLinks — operations

Accessor: `client.PaymentLinks` · Source: `src/Adyen/Api/PaymentLinks.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetPaymentLinksLinkId

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetPaymentLinksLinkId(GetPaymentLinksLinkIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LinkId`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<GetPaymentLinksLinkIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentLinksLinkIdRequest` | `src/Adyen/Requests/PaymentLinks/GetPaymentLinksLinkIdRequest.cs` |
| `PaymentLinkResponse` | `src/Adyen/Models/PaymentLinkResponse.cs` |
| `GetPaymentLinksLinkIdError` | `src/Adyen/Errors/GetPaymentLinksLinkIdError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PatchPaymentLinksLinkId

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchPaymentLinksLinkId(PatchPaymentLinksLinkIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `LinkId`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<PatchPaymentLinksLinkIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchPaymentLinksLinkIdRequest` | `src/Adyen/Requests/PaymentLinks/PatchPaymentLinksLinkIdRequest.cs` |
| `UpdatePaymentLinkRequest` | `src/Adyen/Models/UpdatePaymentLinkRequest.cs` |
| `PaymentLinkResponse` | `src/Adyen/Models/PaymentLinkResponse.cs` |
| `PatchPaymentLinksLinkIdError` | `src/Adyen/Errors/PatchPaymentLinksLinkIdError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentLinks

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentLinks(PostPaymentLinksRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentLinkResponse`
- **Error**: `ApiException<PostPaymentLinksError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentLinksRequest` | `src/Adyen/Requests/PaymentLinks/PostPaymentLinksRequest.cs` |
| `PaymentLinkRequest` | `src/Adyen/Models/PaymentLinkRequest.cs` |
| `PaymentLinkResponse` | `src/Adyen/Models/PaymentLinkResponse.cs` |
| `PostPaymentLinksError` | `src/Adyen/Errors/PostPaymentLinksError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |


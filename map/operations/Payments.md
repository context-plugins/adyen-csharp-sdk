<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `src/Adyen/Api/Payments.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetSessionsSessionId

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetSessionsSessionId(GetSessionsSessionIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SessionId`, `SessionResult`
- **Query params (wire ← C#)**: `sessionResult` ← `SessionResult`
- **Returns**: `SessionResultResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetSessionsSessionIdRequest` | `src/Adyen/Requests/Payments/GetSessionsSessionIdRequest.cs` |
| `SessionResultResponse` | `src/Adyen/Models/SessionResultResponse.cs` |

### PostAuthorise

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAuthorise(PostAuthoriseRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResult`
- **Error**: `ApiException<PostAuthoriseError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAuthoriseRequest` | `src/Adyen/Requests/Payments/PostAuthoriseRequest.cs` |
| `PaymentRequest1` | `src/Adyen/Models/PaymentRequest1.cs` |
| `PaymentResult` | `src/Adyen/Models/PaymentResult.cs` |
| `PostAuthoriseError` | `src/Adyen/Errors/PostAuthoriseError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostAuthorise3D

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAuthorise3D(PostAuthorise3DRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResult`
- **Error**: `ApiException<PostAuthorise3DError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAuthorise3DRequest` | `src/Adyen/Requests/Payments/PostAuthorise3DRequest.cs` |
| `PaymentRequest3D` | `src/Adyen/Models/PaymentRequest3D.cs` |
| `PaymentResult` | `src/Adyen/Models/PaymentResult.cs` |
| `PostAuthorise3DError` | `src/Adyen/Errors/PostAuthorise3DError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostAuthorise3Ds2

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAuthorise3Ds2(PostAuthorise3Ds2Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResult`
- **Error**: `ApiException<PostAuthorise3Ds2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAuthorise3Ds2Request` | `src/Adyen/Requests/Payments/PostAuthorise3Ds2Request.cs` |
| `PaymentRequest3Ds2` | `src/Adyen/Models/PaymentRequest3Ds2.cs` |
| `PaymentResult` | `src/Adyen/Models/PaymentResult.cs` |
| `PostAuthorise3Ds2Error` | `src/Adyen/Errors/PostAuthorise3Ds2Error.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostCardDetails

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCardDetails(PostCardDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CardDetailsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostCardDetailsRequest` | `src/Adyen/Requests/Payments/PostCardDetailsRequest.cs` |
| `CardDetailsRequest` | `src/Adyen/Models/CardDetailsRequest.cs` |
| `CardDetailsResponse` | `src/Adyen/Models/CardDetailsResponse.cs` |

### PostGetAuthenticationResult

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetAuthenticationResult(PostGetAuthenticationResultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AuthenticationResultResponse`
- **Error**: `ApiException<PostGetAuthenticationResultError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetAuthenticationResultRequest` | `src/Adyen/Requests/Payments/PostGetAuthenticationResultRequest.cs` |
| `AuthenticationResultRequest` | `src/Adyen/Models/AuthenticationResultRequest.cs` |
| `AuthenticationResultResponse` | `src/Adyen/Models/AuthenticationResultResponse.cs` |
| `PostGetAuthenticationResultError` | `src/Adyen/Errors/PostGetAuthenticationResultError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentMethods

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentMethods(PostPaymentMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentMethodsResponse`
- **Error**: `ApiException<PostPaymentMethodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentMethodsRequest` | `src/Adyen/Requests/Payments/PostPaymentMethodsRequest.cs` |
| `PaymentMethodsRequest` | `src/Adyen/Models/PaymentMethodsRequest.cs` |
| `PaymentMethodsResponse` | `src/Adyen/Models/PaymentMethodsResponse.cs` |
| `PostPaymentMethodsError` | `src/Adyen/Errors/PostPaymentMethodsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPayments

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPayments(PostPaymentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResponse`
- **Error**: `ApiException<PostPaymentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsRequest` | `src/Adyen/Requests/Payments/PostPaymentsRequest.cs` |
| `PaymentRequest` | `src/Adyen/Models/PaymentRequest.cs` |
| `PaymentResponse` | `src/Adyen/Models/PaymentResponse.cs` |
| `PostPaymentsError` | `src/Adyen/Errors/PostPaymentsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsCancel

- **Server group**: `Default20`
- **Signature**: `PostPaymentsCancel(PostPaymentsCancelRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `CancelPaymentResponse`
- **Error**: `ApiException<PostPaymentsCancelError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsCancelRequest` | `src/Adyen/Requests/Payments/PostPaymentsCancelRequest.cs` |
| `CancelPaymentRequest` | `src/Adyen/Models/CancelPaymentRequest.cs` |
| `CancelPaymentResponse` | `src/Adyen/Models/CancelPaymentResponse.cs` |
| `PostPaymentsCancelError` | `src/Adyen/Errors/PostPaymentsCancelError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostPaymentsConfirm

- **Server group**: `Default20`
- **Signature**: `PostPaymentsConfirm(PostPaymentsConfirmRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `ConfirmPaymentResponse`
- **Error**: `ApiException<PostPaymentsConfirmError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsConfirmRequest` | `src/Adyen/Requests/Payments/PostPaymentsConfirmRequest.cs` |
| `ConfirmPaymentRequest` | `src/Adyen/Models/ConfirmPaymentRequest.cs` |
| `ConfirmPaymentResponse` | `src/Adyen/Models/ConfirmPaymentResponse.cs` |
| `PostPaymentsConfirmError` | `src/Adyen/Errors/PostPaymentsConfirmError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostPaymentsDetails

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostPaymentsDetails(PostPaymentsDetailsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentDetailsResponse`
- **Error**: `ApiException<PostPaymentsDetailsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsDetailsRequest` | `src/Adyen/Requests/Payments/PostPaymentsDetailsRequest.cs` |
| `PaymentDetailsRequest` | `src/Adyen/Models/PaymentDetailsRequest.cs` |
| `PaymentDetailsResponse` | `src/Adyen/Models/PaymentDetailsResponse.cs` |
| `PostPaymentsDetailsError` | `src/Adyen/Errors/PostPaymentsDetailsError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostPaymentsDetails1

- **Server group**: `Default20`
- **Signature**: `PostPaymentsDetails1(PostPaymentsDetails1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentDetailsResponse1`
- **Error**: `ApiException<PostPaymentsDetails1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentsDetails1Request` | `src/Adyen/Requests/Payments/PostPaymentsDetails1Request.cs` |
| `IdealPaymentDetailsRequest` | `src/Adyen/Models/AllOf/IdealPaymentDetailsRequest.cs` |
| `PaymentDetailsResponse1` | `src/Adyen/Models/PaymentDetailsResponse1.cs` |
| `PostPaymentsDetails1Error` | `src/Adyen/Errors/PostPaymentsDetails1Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostRetrieve3Ds2Result

- **Server group**: `Default1`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostRetrieve3Ds2Result(PostRetrieve3Ds2ResultRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ThreeDs2ResultResponse`
- **Error**: `ApiException<PostRetrieve3Ds2ResultError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError(out ServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostRetrieve3Ds2ResultRequest` | `src/Adyen/Requests/Payments/PostRetrieve3Ds2ResultRequest.cs` |
| `ThreeDs2ResultRequest` | `src/Adyen/Models/ThreeDs2ResultRequest.cs` |
| `ThreeDs2ResultResponse` | `src/Adyen/Models/ThreeDs2ResultResponse.cs` |
| `PostRetrieve3Ds2ResultError` | `src/Adyen/Errors/PostRetrieve3Ds2ResultError.cs` |
| `ServiceError` | `src/Adyen/Models/ServiceError.cs` |

### PostSessions

- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSessions(PostSessionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateCheckoutSessionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostSessionsRequest` | `src/Adyen/Requests/Payments/PostSessionsRequest.cs` |
| `CreateCheckoutSessionRequest` | `src/Adyen/Models/CreateCheckoutSessionRequest.cs` |
| `CreateCheckoutSessionResponse` | `src/Adyen/Models/CreateCheckoutSessionResponse.cs` |


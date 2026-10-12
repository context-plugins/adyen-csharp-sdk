<!-- Generated file — do not edit; regenerated with the SDK. -->

# AdyenClient — operations

Accessor: `client` · Source: `src/Adyen/AdyenClient.cs` · 18 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AbortRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `AbortRequest(AbortRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `object`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AbortRequestOperationRequest` | `src/Adyen/Requests/AbortRequestOperationRequest.cs` |
| `AbortRequest` | `src/Adyen/Models/AbortRequest.cs` |

### AdminRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `AdminRequest(AdminRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AdminResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AdminRequestOperationRequest` | `src/Adyen/Requests/AdminRequestOperationRequest.cs` |
| `AdminRequest` | `src/Adyen/Models/AdminRequest.cs` |
| `AdminResponse` | `src/Adyen/Models/AdminResponse.cs` |

### BalanceInquiryRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `BalanceInquiryRequest(BalanceInquiryRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BalanceInquiryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `BalanceInquiryRequestOperationRequest` | `src/Adyen/Requests/BalanceInquiryRequestOperationRequest.cs` |
| `BalanceInquiryRequest` | `src/Adyen/Models/BalanceInquiryRequest.cs` |
| `BalanceInquiryResponse` | `src/Adyen/Models/BalanceInquiryResponse.cs` |

### CardAcquisitionRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CardAcquisitionRequest(CardAcquisitionRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CardAcquisitionResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CardAcquisitionRequestOperationRequest` | `src/Adyen/Requests/CardAcquisitionRequestOperationRequest.cs` |
| `CardAcquisitionRequest` | `src/Adyen/Models/CardAcquisitionRequest.cs` |
| `CardAcquisitionResponse` | `src/Adyen/Models/CardAcquisitionResponse.cs` |

### CardReaderApduRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `CardReaderApduRequest(CardReaderApduRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CardReaderApduResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `CardReaderApduRequestOperationRequest` | `src/Adyen/Requests/CardReaderApduRequestOperationRequest.cs` |
| `CardReaderApduRequest` | `src/Adyen/Models/CardReaderApduRequest.cs` |
| `CardReaderApduResponse` | `src/Adyen/Models/CardReaderApduResponse.cs` |

### DiagnosisRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DiagnosisRequest(DiagnosisRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DiagnosisResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DiagnosisRequestOperationRequest` | `src/Adyen/Requests/DiagnosisRequestOperationRequest.cs` |
| `DiagnosisRequest` | `src/Adyen/Models/DiagnosisRequest.cs` |
| `DiagnosisResponse` | `src/Adyen/Models/DiagnosisResponse.cs` |

### DisplayRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DisplayRequest(DisplayRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `DisplayResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DisplayRequestOperationRequest` | `src/Adyen/Requests/DisplayRequestOperationRequest.cs` |
| `DisplayRequest` | `src/Adyen/Models/DisplayRequest.cs` |
| `DisplayResponse` | `src/Adyen/Models/DisplayResponse.cs` |

### EnableServiceRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `EnableServiceRequest(EnableServiceRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `EnableServiceResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `EnableServiceRequestOperationRequest` | `src/Adyen/Requests/EnableServiceRequestOperationRequest.cs` |
| `EnableServiceRequest` | `src/Adyen/Models/EnableServiceRequest.cs` |
| `EnableServiceResponse` | `src/Adyen/Models/EnableServiceResponse.cs` |

### GetTotalsRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTotalsRequest(GetTotalsRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetTotalsResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetTotalsRequestOperationRequest` | `src/Adyen/Requests/GetTotalsRequestOperationRequest.cs` |
| `GetTotalsRequest` | `src/Adyen/Models/GetTotalsRequest.cs` |
| `GetTotalsResponse` | `src/Adyen/Models/GetTotalsResponse.cs` |

### InputRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `InputRequest(InputRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `InputResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `InputRequestOperationRequest` | `src/Adyen/Requests/InputRequestOperationRequest.cs` |
| `InputRequest` | `src/Adyen/Models/InputRequest.cs` |
| `InputResponse` | `src/Adyen/Models/InputResponse.cs` |

### LoginRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `LoginRequest(LoginRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `LoginResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LoginRequestOperationRequest` | `src/Adyen/Requests/LoginRequestOperationRequest.cs` |
| `LoginRequest` | `src/Adyen/Models/LoginRequest.cs` |
| `LoginResponse` | `src/Adyen/Models/LoginResponse.cs` |

### LogoutRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `LogoutRequest(LogoutRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `LogoutResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LogoutRequestOperationRequest` | `src/Adyen/Requests/LogoutRequestOperationRequest.cs` |
| `LogoutRequest` | `src/Adyen/Models/LogoutRequest.cs` |
| `LogoutResponse` | `src/Adyen/Models/LogoutResponse.cs` |

### PaymentRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PaymentRequest(PaymentRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PaymentResponse4`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PaymentRequestOperationRequest` | `src/Adyen/Requests/PaymentRequestOperationRequest.cs` |
| `PaymentRequest2` | `src/Adyen/Models/PaymentRequest2.cs` |
| `PaymentResponse4` | `src/Adyen/Models/PaymentResponse4.cs` |

### PrintRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PrintRequest(PrintRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `PrintResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PrintRequestOperationRequest` | `src/Adyen/Requests/PrintRequestOperationRequest.cs` |
| `PrintRequest` | `src/Adyen/Models/PrintRequest.cs` |
| `PrintResponse` | `src/Adyen/Models/PrintResponse.cs` |

### ReconciliationRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ReconciliationRequest(ReconciliationRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReconciliationResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReconciliationRequestOperationRequest` | `src/Adyen/Requests/ReconciliationRequestOperationRequest.cs` |
| `ReconciliationRequest` | `src/Adyen/Models/ReconciliationRequest.cs` |
| `ReconciliationResponse` | `src/Adyen/Models/ReconciliationResponse.cs` |

### ReversalRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `ReversalRequest(ReversalRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `ReversalResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `ReversalRequestOperationRequest` | `src/Adyen/Requests/ReversalRequestOperationRequest.cs` |
| `ReversalRequest` | `src/Adyen/Models/ReversalRequest.cs` |
| `ReversalResponse` | `src/Adyen/Models/ReversalResponse.cs` |

### StoredValueRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `StoredValueRequest(StoredValueRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `StoredValueResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `StoredValueRequestOperationRequest` | `src/Adyen/Requests/StoredValueRequestOperationRequest.cs` |
| `StoredValueRequest` | `src/Adyen/Models/StoredValueRequest.cs` |
| `StoredValueResponse` | `src/Adyen/Models/StoredValueResponse.cs` |

### TransactionStatusRequest

- **Server group**: `Default24`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `TransactionStatusRequest(TransactionStatusRequestOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `TransactionStatusResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TransactionStatusRequestOperationRequest` | `src/Adyen/Requests/TransactionStatusRequestOperationRequest.cs` |
| `TransactionStatusRequest` | `src/Adyen/Models/TransactionStatusRequest.cs` |
| `TransactionStatusResponse` | `src/Adyen/Models/TransactionStatusResponse.cs` |


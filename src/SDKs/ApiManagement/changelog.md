## Microsoft.Azure.Management.ApiManagment release notes

### Changes in 4.8.0-preview

- Switch the .NET client to use api-version `2019-01-01`
- Add support for cloning Apis from an ApiRevision and ApiVersionSet
- Enabled support for Importing and Exporting Apis based on OpenApi specification
- Add support for creating Api Diagnostics
- Diagnostics support configuring detailed sampling and Header configuration
- Add support for creating and update Cache entity.
- Subscription Contract has breaking change. The ProductId property is replaced with Scope and UserId is replaced with OwnerId.
- Added support for creating Global Scope Subscriptions
- Added support for managing `Consumption` Sku services.
- Deprecated Api UpdateHostName and UploadCertificate for configurating ApiManagement service. Use CreateOrUpdate service instead.

### Changes in 4.0.6-preview

- Added support of OpenId authentication in ApiContract
- Fixed bug in UserContract which prevented setting the UserIdentities
- Added API for updating an API Issue

### Changes in 4.0.5-preview

- Added ApiRevisionDescription and ApiVersionDescription to ApiContract
- Fixed bug in ApiManagementService contract. The CertificateInformation has a setter for Update scenarios.

### Changes in 4.0.4-preview

- Added ApiRevisionDescription and ApiVersionDescription to ApiContract
- Fixed bug in ApiManagementService contract. The CertificateInformation has a setter for Update scenarios.

### Changes in 4.0.3-preview

- Fixed contract for Error in OperationResultContract
- Fixed validation for adding Apis to Product

### Changes in 4.0.2-preview

- Fixed Contract for ErrorResponse for Management Apis

### Changes in 4.0.1-preview

*** Resource Management APIs ***

- Added missing privateIP address in Additional Location

*** Management APIs ****

- Added support for Issue, Issue Comments and Issue Attachments
- Added support for accepting non-Xml Encoded policies.

### Changes in 4.0.0-preview

**Notes**

*** Resource Management APIs ***
- Added support for Basic Sku
- Added support for Intermediate Certificates
- Added support for creating MSI and KeyVault integration
- Added support for querying NetworkStatus endpoint

*** Management APIs ***
- Added support for creating an API by importing a WSDL document, containing multiple Service endpoints
- GetEntityTag API for all resources, to retrieve the ETag of the entity, to be used when Updating/Deleting the Entity.
- API support for API Revisions, API Releases and Api VersionSets
- API support for API Schemas.
- API support for Backend Reconnect.
- API support for Tag.
- API support for Diagnostics
- API support for Application insights Logger
- API support for managing Notifications, Notification Recipients and Notification Users.
- API support for Portal settings including SignIn, Signup and Delegation.
- API support for Importing Policies using Link
- Added support for Exporting Soap APIs in WSDL Format.
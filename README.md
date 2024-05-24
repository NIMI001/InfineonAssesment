# InfineonAssesment
I designed my application using clean code architecture where I seperated individual layers of the aplication to the below respectively:
-InfineonAssesment.Domain: This layer holds the User and Product model of the application
-InfineonAssessment.Infrastructure: This layer holds the persistence(dependency injection), repository layer, migration
_InfineonAssesment.Application: This contain the service layer and controllers where the aplication logic are written
_InfineonAssessment.WebApi: It holds the startup aspect of the application where service configuration are carried out, appsetting.json where the connection strings, email smtp and tokens ard registered.
_InfineonAssessment.Shared: It holds the DTO's of user and product models that the users interact with, it also contains the pagination class that assist for pagination upon user request.

The user class model inherited from MicrosoftIdentityUser, this library package helps in seamlessly creating a password hashing for the project.

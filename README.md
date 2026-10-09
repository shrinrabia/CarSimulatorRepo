- CarSimulator - Project Documention.
- Container Deployment:
+ Concept:Containerization packages an application along with all its dependencies and configurations into an isolated enviroment.

+ Benefits:

*Benefit:* It ensures the application runs consistently across development, testing, and production environments without system compatibility issues.
*Use Case:* Useful for running microservices and web APIs in scalable environments like Azure Container Apps or Kubernetes.

*Infrastructure and Security:

*Least Privilege:* Access rights and permissions are restricted to only what is strictly necessary for each user or service.
*Secrets Management:* Sensitive information (such as connection strings, API keys, and tokens) is stored in environment variables or Azure Key Vault, never hardcoded in the source code.
*Network Rules & Isolation:* Development and production environments are kept separate. Access is restricted using IP restrictions on Azure App Service and Azure SQL Server to allow only authorized traffic.

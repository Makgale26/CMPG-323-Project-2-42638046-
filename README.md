# CMPG-323-Project-2---42638046-

# NWU Tech Trends - Project2_API
## Project Overview
This project is part of the CMPG 323 course and is named "Project2_API." The main objective is to create a RESTful API using .NET 8 and Azure that tracks time and cost savings from automation processes. The API manages telemetry data related to various projects and clients, allowing for efficient performance analysis and reporting.

CRUD Operations: Manage telemetry data with Create, Read, Update, and Delete operations.
Telemetry Tracking: Capture detailed telemetry data, including time saved and cost saved per project and client.
Authentication: Secure the API endpoints using JWT-based authentication.
Swagger Documentation: Explore and interact with the API using Swagger UI.



## Database set up

Set up your SQL Server and create a database named sqlDatabaseCmpg323.
Update the connection string in the appsettings.json file (not included in version control for security reasons).
Apply Migrations:

Ensure your database schema is up-to-date by applying migrations.

## Privacy and Security 

.gitnore is used to ignore all data that contain sensitive information.


## Authentication Setup
This project uses JWT authentication.


## Usage Endpoints:

GET /api/JobTelemetries: Retrieve all telemetry records.
POST /api/JobTelemetries: Create a new telemetry record.
PUT /api/JobTelemetries/{id}: Update an existing telemetry record.
DELETE /api/JobTelemetries/{id}: Delete a telemetry record.


## License
This project is licensed under the MIT License - see the LICENSE file for details.


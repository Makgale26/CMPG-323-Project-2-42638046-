

# NWU Tech Trends - Project2_API
## Project Overview
 The main objective is to create a RESTful API using .NET 8 and Azure that tracks time and cost savings from automation processes. The API manages telemetry data related to various projects and clients, allowing for efficient performance analysis and reporting.

CRUD Operations: Manage telemetry data with Create, Read, Update, and Delete operations.
Telemetry Tracking: Capture detailed telemetry data, including time saved and cost saved per project and client.
Authentication: Secure the API endpoints using JWT-based authentication.
Swagger Documentation: Explore and interact with the API using Swagger UI.

## Problem Statement
### Problem Statement

In today's fast-paced business environment, organizations increasingly rely on automation to enhance efficiency and reduce operational costs. However, tracking the impact of these automation processes—specifically in terms of time saved and cost savings—remains a significant challenge. Many existing solutions lack the capability to effectively manage and analyze telemetry data related to various projects and clients.

The absence of a comprehensive tool leads to inefficiencies in decision-making, as organizations struggle to quantify the benefits of automation initiatives. Additionally, without robust tracking and reporting mechanisms, businesses cannot fully capitalize on their automation investments or identify areas for further improvement.

To address these challenges, we propose the development of a RESTful API using .NET 8 and Azure. This API will facilitate the efficient tracking, management, and analysis of telemetry data related to automation processes, enabling organizations to:

1. **Accurately track time and cost savings**: Provide detailed insights into the effectiveness of automation across various projects and clients.
2. **Simplify data management**: Enable users to easily create, read, update, and delete telemetry records.
3. **Enhance security**: Implement JWT-based authentication to safeguard sensitive data.
4. **Promote usability**: Offer a user-friendly interface via Swagger UI for exploration and interaction with the API.

By addressing these needs, the proposed API will empower organizations to make informed decisions, optimize their automation strategies, and ultimately achieve greater operational efficiency.
## Database set up

Set up your SQL Server and create a database named Geexpo.
Update the connection string in the appsettings.json file (not included in version control for security reasons).
Apply Migrations:

Ensure your database schema is up-to-date by applying migrations.

## Privacy and Security 

.gitignore is used to ignore all data that contain sensitive information.


## Authentication Setup
This project uses JWT authentication.


## Usage Endpoints:

GET /api/JobTelemetries: Retrieve all telemetry records.
POST /api/JobTelemetries: Create a new telemetry record.
PUT /api/JobTelemetries/{id}: Update an existing telemetry record.
DELETE /api/JobTelemetries/{id}: Delete a telemetry record.


## License
This project is licensed under the MIT License - see the LICENSE file for details.


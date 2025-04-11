This document contains technical stories for the 'hello-asp-net-developer' REST API from the perspective of a developer interaction

## TS01: Retrieve Greetings via GET Request
**As a developer**, I want to retrieve a greeting by providing optional first and last names, so that I can test the API with both named and anonymous inputs.

### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
  - **Given** a developer has not provided any names,
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with the message "Welcome Anonymous ASP.NET Developer"

- **Scenario 2: Personalized Greetings**
  - **Given** a developer has provided the first name 'John' and last name 'Doe',
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response containing a unique identifier, the full name 'John Doe', and the message 'Congrats John Doe! You are an ASP.NET Developer'

- **Scenario 3: Partial Input**
  - **Given** a developer has provided the first name 'John' without a lastname,
  - **When** the developer requests a greeting via GET,
  - **Then** the developer receives a response with the message "Welcome Anonymous ASP.NET Developer"



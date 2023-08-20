# EMRge

EMRge is a comprehensive Electronic Medical Records (EMR) desktop application built to manage the day-to-day operations of a hospital or healthcare facility. It brings patient records, clinical workflows, staff administration, and billing together in a single C# WinForms application backed by a SQL Server database, streamlining hospital operations, improving patient care, and reducing administrative overhead.

## Features

- **Login & Access Control** — Employees sign in with an ID and password. Access to each module is restricted based on the employee's role and credentials, with an "Access Denied" prompt for unauthorized modules.
- **Dashboard** — A summary view of key hospital stats is shown on launch, with a sidebar for navigating between modules.
- **Patient Management** — Maintain in-patient and out-patient records, including personal details, health stats (blood type, height, weight), emergency contacts, and registration/room information. Patients can be searched by ID or phone number, added, edited, and removed.
- **Examination Workflow** — View the queue of patients waiting for examination, order lab tests, prescribe medications, and record a diagnosis to complete an examination.
- **Laboratory Workflow** — View the queue of pending lab tests ordered by physicians, enter results, and submit them to complete the test.
- **Staff Management** — Browse, search, filter (by branch, department, salary range), and sort employee records, view detailed employee info, and add new staff.
- **Billing** — Look up a patient by ID or phone number to view their outstanding bills and mark them as paid. Bills for registrations, examinations, and lab tests are generated automatically via database triggers.
- **Automated Tests** — NUnit tests cover key forms such as adding patients, examination records, and laboratory tests.

## Tech Stack

- C# / .NET Framework (WinForms)
- Bunifu UI controls for the user interface
- Microsoft SQL Server for data storage (schema and stored procedures in [`SQLQueries.sql`](SQLQueries.sql))
- NUnit for unit testing (see [`NUnitTests`](NUnitTests))

## Getting Started

1. Set up a SQL Server instance and create the `EMRge` database using the schema, stored procedures, functions, and triggers defined in [`SQLQueries.sql`](SQLQueries.sql).
2. Point the connection string in `EMRgeDB` to your SQL Server instance.
3. Open `EMRge.sln` in Visual Studio and build the project.
4. Run the application and log in with a valid employee ID and password.

## Documentation

For a full breakdown of the application's modules and workflows, see the [User Documentation](User%20Documentation.pdf). For details on the underlying classes, database schema, stored procedures, and triggers, see the [System Documentation](System%20Documentation.pdf).

## Screenshots

#### Login
![Screenshot (44)](https://user-images.githubusercontent.com/112032056/198877273-2b39d8ee-2a22-45d4-a8ca-fcec913b4769.png)

#### Dashboard
![Screenshot (45)](https://user-images.githubusercontent.com/112032056/198877277-930e74ae-a00b-409d-91f1-c2e3ec7a22d2.png)

#### Patients
![Screenshot (46)](https://user-images.githubusercontent.com/112032056/198877280-ee88ffe0-0727-4066-a425-256772e7c545.png)
![Screenshot (47)](https://user-images.githubusercontent.com/112032056/198877282-66b0bbb0-688b-4e96-aaaa-4f6d055972d4.png)

#### Examination
![Screenshot (48)](https://user-images.githubusercontent.com/112032056/198877284-56fe6165-95fa-4fd0-b1d1-a2e6ab87e4bf.png)
![Screenshot (49)](https://user-images.githubusercontent.com/112032056/198877288-22871239-2176-4235-979d-369b941ecca1.png)

#### Laboratory
![Screenshot (50)](https://user-images.githubusercontent.com/112032056/198877289-876ccf1c-9eeb-41ec-af18-1770ee4487a0.png)

#### Examination
![Screenshot (51)](https://user-images.githubusercontent.com/112032056/198877290-b2086c60-373f-4bd1-9337-aac01c5269f6.png)

#### Billing
![Screenshot (52)](https://user-images.githubusercontent.com/112032056/198877291-a3ecbb6d-74f7-4048-ae4d-12b3985a5a56.png)

#### Staff
![Screenshot (53)](https://user-images.githubusercontent.com/112032056/198877294-b8eb26a8-a3de-498c-9565-c98e4f49a179.png)
![Screenshot (54)](https://user-images.githubusercontent.com/112032056/198877296-2dbf24c2-04b2-4b64-a6c4-88c492087a26.png)
![Screenshot (56)](https://user-images.githubusercontent.com/112032056/198877302-9e52aa45-89b1-415d-8611-7e1151ffabc7.png)
![Screenshot (57)](https://user-images.githubusercontent.com/112032056/198877305-e73ded66-a0a1-43c8-8faf-6d7880e86a45.png)

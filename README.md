# Food Application

Welcome to the Food Application! This web application allows users to explore and order recipes from various cuisines.

## Technologies Used

### Frontend
- **HTML/CSS/Bootstrap:** The frontend is built using HTML for structure, CSS for styling, and Bootstrap for responsive design.
- **Razor Pages:** Utilized Razor syntax for server-side rendering in ASP.NET Core.

### Backend
- **ASP.NET Core:** The backend is powered by ASP.NET Core, providing a robust and scalable server-side framework.
- **C#:** Primary programming language for server-side logic.
- **Entity Framework Core:** Used for data access and handling database operations.
- **Identity Framework:** Implemented for user authentication and authorization.
- **HttpClient:** Utilized for making HTTP requests to the Forkify API.

### Database
- **Entity Framework Core (Code-First):** Configured and interacted with the database using Entity Framework Core, following the Code-First approach.
- **SQL Server:** Chosen as the relational database to store user data and application information.

### External APIs
- **Forkify API:** Integrated to fetch recipes and details for the application.

### JavaScript/jQuery
- **jQuery:** Used for client-side scripting, particularly for the autocomplete feature in recipe search.

### Frontend Libraries
- **Font Awesome:** Included for adding icons to enhance the visual appeal.

## Folder Structure
- **DTO:** Data Transfer Objects for communication with external APIs.
- **Models:** Data models for the application entities.
- **Services:** Contains the RecipeService responsible for interacting with the Forkify API.
- **Views:** Razor Pages for the user interface.
- **wwwroot:** Static files, including images and CSS.

## Setup Instructions
1. Clone the repository.
2. Ensure you have .NET Core SDK and SQL Server installed.
3. Update the connection string in `appsettings.json`.
4. Run migrations to create the database: `dotnet ef database update`.
5. Launch the application: `dotnet run`.
6. Access the application in your browser at `https://localhost:5001`.

## ERD
![ٌُERD](images/ُER.jpg)


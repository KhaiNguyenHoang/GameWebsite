# GameWebsite

## Overview

GameWebsite is a full-stack web application for an online gaming platform built with ASP.NET Core for the backend API and React.js with Vite for the frontend. The project supports user registration, login, role-based access control using JWT authentication, and basic game features. It follows a modular architecture for scalability and maintainability, utilizing Entity Framework Core for database operations.

This project is designed for a large-scale game website, with clear separation of concerns between backend services, data access, and frontend components.

## Backend

### Technologies

- **Framework**: ASP.NET Core 9.0
- **Database**: Entity Framework Core with SQL Server (LocalDB for development)
- **Authentication**: JWT (JSON Web Tokens)
- **Validation**: Custom validation attributes
- **Testing**: xUnit/NUnit with Moq for unit tests, TestServer for integration tests

### Structure

The backend follows a layered architecture:

- **📁 Controllers**: API controllers handling HTTP requests (e.g., AuthController, GameController).
- **📁 Services**: Business logic implementation (e.g., UserService, GameService).
- **📁 Repositories**: Data access layer using EF Core (e.g., UserRepository).
- **📁 Models**: Entity classes for database schemas (e.g., Account, Role, Permission, IDCard).
- **📁 DTOs**: Data Transfer Objects for API responses (e.g., ApiResponseSuccess, ApiResponseFailed).
- **📁 Utils**: Utility classes and helpers (e.g., DatabaseContext.cs).
- **📁 CustomValidations**: Custom validation attributes (e.g., NumberIDCardValidate).
- **📁 Middleware**: Custom middleware for request processing (e.g., AuthenticationMiddleware).
- **📁 Extensions**: Extension methods for .NET types.
- **📁 Configurations**: Configuration classes (e.g., JwtConfiguration).
- **📁 Migrations**: EF Core migration files.
- **📁 wwwroot**: Static files (e.g., for Swagger UI).
- **📁 Tests**:
  - **UnitTests**: Unit tests for services and utilities.
  - **IntegrationTests**: End-to-end tests for APIs and database interactions.
- **Properties**: Launch settings for development.

Main configuration files:

- `appsettings.json`: General settings including JWT keys, connection strings.
- `appsettings.Development.json`: Environment-specific configurations.

### Backend Setup

1. Navigate to the `BackEnd` directory: `cd BackEnd`
2. Restore NuGet packages: `dotnet restore`
3. Create and apply migrations: `dotnet ef migrations add InitialCreate` followed by `dotnet ef database update`
4. Run the application: `dotnet run`
   - The API will be available at `https://localhost:7001` (HTTPS) or `http://localhost:5000` (HTTP).
5. Access Swagger UI for API documentation: `https://localhost:7001/swagger`

## Frontend

### Technologies

- **Framework**: React.js 18+
- **Build Tool**: Vite
- **Routing**: React Router (to be implemented in routes)
- **State Management**: Contexts or Redux/Zustand (in store)
- **HTTP Client**: Axios or Fetch (in services)
- **Testing**: Jest + React Testing Library (in tests)

### Structure

The frontend is organized for component-based development:

- **📁 src/App.jsx**: Main application component.
- **📁 src/main.jsx**: Entry point for rendering the app.
- **📁 src/components**: Reusable UI components (e.g., Button, Navbar).
- **📁 src/pages**: Page-level components (e.g., LoginPage, DashboardPage, GamePage).
- **📁 src/services**: API service functions for backend calls (e.g., authService.js).
- **📁 src/utils**: Helper utilities (e.g., formatDate.js, validation helpers).
- **📁 src/hooks**: Custom React hooks (e.g., useAuth.js, useGame.js).
- **📁 src/contexts**: Context providers for global state (e.g., AuthContext).
- **📁 src/routes**: Routing configuration with React Router.
- **📁 src/store**: State management store (e.g., Redux store).
- **📁 src/assets**: Static assets like images and fonts.
- **📁 tests**: Frontend test files.

Public folder contains static assets like `index.html` and `vite.svg`.

### Frontend Setup

1. Navigate to the `FrontEnd` directory: `cd FrontEnd`
2. Install dependencies: `npm install`
3. Run the development server: `npm run dev`
   - The app will be available at `http://localhost:5173`.
4. For production build: `npm run build`

To connect to the backend, configure proxy in `vite.config.js` or use full API URLs in services.

## Getting Started

### Prerequisites

- **Backend**: .NET SDK 9.0+, SQL Server LocalDB (included with Visual Studio or install separately)
- **Frontend**: Node.js 18+ and npm
- **IDE**: Visual Studio Code, Visual Studio, or any preferred editor
- **Database**: SQL Server for production; LocalDB for development

### Installation

1. Clone the repository: `git clone <repository-url>`
2. Follow Backend and Frontend setup steps above.

### Running the Application

1. Start the Backend: `cd BackEnd && dotnet run`
2. Start the Frontend: In a new terminal, `cd FrontEnd && npm run dev`
3. Access the app at `http://localhost:5173` (frontend) and test APIs via Swagger.

### API Endpoints

- **Authentication**:
  - POST `/api/auth/register` - User registration
  - POST `/api/auth/login` - User login (returns JWT token)
- **User Management**:
  - GET `/api/users/{id}` - Get user profile (requires JWT)
- **Game**:
  - POST `/api/game/start` - Start a new game (requires JWT)
- Full list available in Swagger.

## Features

- **User Authentication & Authorization**: JWT-based login/register with role-based access (Admin, User).
- **Database Integration**: EF Core for CRUD operations on users, roles, permissions.
- **API Standardization**: Consistent response format with success/failure codes.
- **Custom Validations**: For ID cards and dates.
- **Modular Structure**: Easy to extend for new game features like multiplayer, leaderboards.
- **Testing**: Unit and integration tests for backend; component tests for frontend.

## Testing

- **Backend**: Run all tests with `cd BackEnd && dotnet test`
- **Frontend**: Run tests with `cd FrontEnd && npm test`

## Contributing

1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

Please ensure code follows existing conventions and passes all tests.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contact

For questions or issues, open an issue on the repository or contact the maintainers.

---

_Note: This project is under active development. Additional game-specific features (e.g., real-time multiplayer with SignalR) can be added as needed._

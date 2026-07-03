# DatabaseMock

This example demonstrates how to mock a repository using **Moq** while testing business logic.

## Objective

- Mock a data repository.
- Return predefined values using `Setup()`.
- Verify repository interactions using `Verify()`.
- Test the service without connecting to a real database.

## Files

- `EmployeeService.cs` – Service that retrieves employee information.
- `IEmployeeRepository.cs` – Repository interface.
- `EmployeeServiceTests.cs` – NUnit test using Moq.

## Concepts Covered

- Dependency Injection
- Repository Pattern
- Mock Objects
- Setup()
- Returns()
- Verify()
- NUnit Assertions

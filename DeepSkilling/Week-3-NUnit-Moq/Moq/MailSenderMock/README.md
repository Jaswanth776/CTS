# MailSenderMock

This example demonstrates how to mock an email service using **Moq**.

## Objective

- Mock an email service dependency.
- Configure the mocked method using `Setup()`.
- Use `It.IsAny<T>()` for flexible argument matching.
- Verify the mocked method invocation.
- Test business logic without sending real emails.

## Files

- `NotificationService.cs` – Sends welcome emails using an email service.
- `IEmailService.cs` – Email service interface.
- `NotificationServiceTests.cs` – NUnit test using Moq.

## Concepts Covered

- Dependency Injection
- Mock Objects
- Setup()
- Returns()
- Verify()
- It.IsAny<T>()
- NUnit Assertions

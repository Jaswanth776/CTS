# CurrencyConverterMock

This example demonstrates how to use **Moq** to test a class that depends on an external currency service.

## Objective

- Mock an external dependency using Moq.
- Configure expected values with `Setup()`.
- Verify interactions using `Verify()`.
- Test the conversion logic without calling a real service.

## Files

- `CurrencyConverter.cs` – Performs currency conversion.
- `ICurrencyService.cs` – Interface representing the external service.
- `CurrencyConverterTests.cs` – NUnit test using Moq.

## Concepts Covered

- Dependency Injection
- Mock Objects
- Setup()
- Returns()
- Verify()
- NUnit Assertions

# FileSystemMock

This example demonstrates how to mock file system operations using **Moq**.

## Objective

- Mock file reading operations.
- Return predefined file contents.
- Test file access logic without reading an actual file.
- Verify interactions with the mocked dependency.

## Files

- `FileReader.cs` – Reads file content using an abstract file system.
- `IFileSystem.cs` – File system interface.
- `FileReaderTests.cs` – NUnit test using Moq.

## Concepts Covered

- Dependency Injection
- Mock Objects
- Setup()
- Returns()
- Verify()
- NUnit Assertions

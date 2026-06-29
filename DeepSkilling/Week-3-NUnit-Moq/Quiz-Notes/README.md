# NUnit and Moq Quiz Notes

This folder contains important concepts and revision notes for NUnit and Moq.

## NUnit

### TestFixture
Marks a class that contains test methods.

### Test
Marks a method as a test case.

### SetUp
Runs before every test method.

### TearDown
Runs after every test method.

### Assertions

- Assert.AreEqual()
- Assert.IsTrue()
- Assert.IsFalse()
- Assert.IsNull()
- Assert.Throws()

### Parameterized Tests

- TestCase
- TestCaseSource

### Collection Assertions

- CollectionAssert.AreEqual()
- CollectionAssert.Contains()

---

## Moq

### Mock<T>

Creates a mock object.

### Setup()

Defines the behavior of mocked methods.

### Verify()

Checks whether a mocked method was called.

### Returns()

Specifies the return value of a mocked method.

### Times.Once()

Ensures the method is invoked exactly once.

### Dependency Injection

Used to inject mocked dependencies during testing.

## Best Practices

- Keep tests independent.
- Mock only external dependencies.
- Test one behavior per test.
- Use meaningful test names.
- Keep unit tests fast and deterministic.

## Learning Outcomes

- Understand NUnit attributes.
- Use assertions effectively.
- Write parameterized tests.
- Mock dependencies using Moq.
- Verify interactions between objects.

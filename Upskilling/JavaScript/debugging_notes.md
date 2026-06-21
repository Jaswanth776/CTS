# JavaScript Debugging Notes

## Introduction

Debugging is the process of identifying, analyzing, and fixing errors in a program. JavaScript provides several tools and techniques to help developers find and resolve issues efficiently.

---

## 1. Console Logging

The simplest debugging technique is using `console.log()` to display variable values and execution flow.

### Example

```javascript
let name = "Jaswanth";
console.log(name);
```

### Output

```
Jaswanth
```

You can also print multiple values:

```javascript
let age = 21;
console.log("Name:", name, "Age:", age);
```

---

## 2. Browser Developer Tools

Modern browsers provide built-in developer tools.

### Open Developer Tools

- F12
- Ctrl + Shift + I
- Right Click → Inspect

### Useful Tabs

#### Console

Displays logs, warnings, and errors.

#### Elements

Inspect and modify HTML and CSS.

#### Sources

Debug JavaScript and set breakpoints.

#### Network

Monitor requests and responses.

#### Application

Inspect Local Storage, Session Storage, and Cookies.

---

## 3. Breakpoints

Breakpoints allow you to pause code execution and inspect variable values.

### Steps

1. Open Developer Tools.
2. Go to Sources tab.
3. Select a JavaScript file.
4. Click a line number.
5. Refresh or run the program.

Execution will stop at the breakpoint.

### Benefits

- Inspect variables.
- Track execution flow.
- Find logic errors.

---

## 4. Using debugger Keyword

JavaScript provides a built-in `debugger` statement.

### Example

```javascript
let x = 10;
let y = 20;

debugger;

let sum = x + y;
console.log(sum);
```

When Developer Tools are open, execution pauses at the `debugger` statement.

---

## 5. Common JavaScript Errors

### Syntax Error

Occurs when code violates JavaScript syntax rules.

```javascript
console.log("Hello"
```

Error:

```
Uncaught SyntaxError
```

---

### Reference Error

Occurs when a variable is not defined.

```javascript
console.log(userName);
```

Error:

```
ReferenceError: userName is not defined
```

---

### Type Error

Occurs when an operation is performed on an incompatible type.

```javascript
let num = 10;
num.toUpperCase();
```

Error:

```
TypeError: num.toUpperCase is not a function
```

---

### Range Error

Occurs when a value is outside the allowed range.

```javascript
let arr = new Array(-1);
```

Error:

```
RangeError: Invalid array length
```

---

## 6. Error Handling with try...catch

Use `try...catch` to handle runtime errors gracefully.

### Example

```javascript
try {
    let result = x + y;
}
catch(error) {
    console.log(error.message);
}
```

### Example with Custom Message

```javascript
try {
    throw new Error("Custom Error");
}
catch(error) {
    console.log(error.message);
}
```

Output:

```
Custom Error
```

---

## 7. Using finally Block

The `finally` block executes whether an error occurs or not.

```javascript
try {
    console.log("Inside try block");
}
catch(error) {
    console.log(error);
}
finally {
    console.log("Always executed");
}
```

---

## 8. Inspecting Objects

Use `console.table()` to display object data clearly.

### Example

```javascript
const students = [
    { id: 1, name: "John" },
    { id: 2, name: "Alice" }
];

console.table(students);
```

This displays data in a tabular format.

---

## 9. Monitoring Variable Changes

Use `console.log()` at different stages.

```javascript
let count = 0;

console.log(count);

count++;

console.log(count);
```

Output:

```
0
1
```

---

## 10. Best Practices for Debugging

### Read Error Messages Carefully

JavaScript errors usually indicate:

- Error type
- Line number
- File name

### Debug Incrementally

Test small sections of code before combining them.

### Use Meaningful Variable Names

Bad:

```javascript
let a = 100;
```

Good:

```javascript
let studentCount = 100;
```

### Validate User Inputs

Always verify data entered by users.

```javascript
if(name === ""){
    alert("Name is required");
}
```

### Keep Functions Small

Smaller functions are easier to test and debug.

---

## 11. Debugging Asynchronous Code

Use logging inside asynchronous operations.

### Example

```javascript
async function fetchData() {
    console.log("Fetching data...");

    const response = await fetch("https://jsonplaceholder.typicode.com/users");

    console.log("Response received");

    const data = await response.json();

    console.log(data);
}

fetchData();
```

---

## 12. Debugging DOM Manipulation

Check whether elements exist before accessing them.

```javascript
const element = document.getElementById("demo");

if(element){
    console.log("Element found");
}
else{
    console.log("Element not found");
}
```

---

## Conclusion

JavaScript debugging is an essential skill for every developer. By using browser developer tools, console logging, breakpoints, debugger statements, and proper error handling techniques, developers can efficiently identify and fix issues in their applications.

Mastering debugging leads to faster development, cleaner code, and more reliable web applications.

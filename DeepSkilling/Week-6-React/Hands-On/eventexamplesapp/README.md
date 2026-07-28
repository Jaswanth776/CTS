# eventexamplesapp

## Project Name
eventexamplesapp

## Objective
Demonstrate React event handling — event handlers, `this` keyword, argument passing, synthetic events.

## HOL Reference
React HOL 11 — Event Handling (Mandatory)

## Technologies
- React 19 (Class components)
- Create React App (react-scripts 5.0.1)
- JavaScript ES6

## Event Handling Features
| Feature | Component | Implementation |
|---------|-----------|----------------|
| Increment/Decrement | `Counter` | Button click updates state |
| Multiple method invocation | `Counter` | `handleIncrement()` calls `this.sayHello()` |
| Argument passing | `Counter` | `onClick={() => this.handleSayWelcome("welcome")}` |
| Synthetic event | `Counter` | `handleOnPress(e)` receives event object |
| Form submit event | `CurrencyConvertor` | `onSubmit={this.handleSubmit}` |

## Components
### Counter
- **Increment** button → increases counter + alerts "Hello! Member" (multiple methods)
- **Decrement** button → decreases counter
- **Say welcome** button → alerts "welcome" (argument passing)
- **Click on me** button → alerts "I was clicked" (synthetic event)

### CurrencyConvertor
- Accepts Amount (numeric input) and Currency (text input)
- Submit button → converts INR to Euro using formula: `amount × 80`
- Alert displays: `"Converting to: Euro Amount is 6400"` (for amount = 80)

## Steps to Run
```bash
npm install
npm start
```

## Build
```bash
npm run build
```

## Folder Structure
```
eventexamplesapp/
  src/
    App.js
    App.css
    index.js
    components/
      Counter.js           ← Increment/Decrement, Say welcome, Click on me
      CurrencyConvertor.js ← Rupee to Euro conversion
  public/
  package.json
```

## Expected Output
1. Counter: 5 (example)
   - [Increment] [Decrement] [Say welcome] [Click on me]
2. Currency Convertor!!!
   - Amount: [input]
   - Currency: [input]
   - [Submit]

## Alerts
- Increment → "Hello! Member"
- Say welcome → "welcome"
- Click on me → "I was clicked"
- Submit (Amount=80, Currency=Euro) → "Converting to: Euro Amount is 6400"

## Completion Status
✅ Completed

# officespacerentalapp

## Project Name
officespacerentalapp

## Objective
Demonstrate JSX usage in React — elements, attributes, objects, loops, and inline CSS with conditional styling.

## HOL Reference
React HOL 10 — JSX (Mandatory)

## Technologies
- React 19
- Create React App (react-scripts 5.0.1)
- JavaScript ES6 + JSX

## JSX Features Demonstrated
| Feature | Implementation |
|---------|----------------|
| JSX element | `const element = "Office Space"` → `<h1>{element}</h1>` |
| JSX attribute | `<img src={officeImage} width="25%" height="25%" alt="Office Space" />` |
| JSX object | `const ItemName = { Name: "DBS", Rent: 50000, Address: "Chennai" }` |
| Looping with `map()` | Renders an array of office spaces |
| Conditional CSS | Rent ≤ 60000 → Red, Rent > 60000 → Green |

## Color Logic
```javascript
const getRentColor = (rent) => {
  return rent <= 60000 ? "textRed" : "textGreen";
};
```

- **Red** (`.textRed`) → Rent ≤ Rs. 60,000
- **Green** (`.textGreen`) → Rent > Rs. 60,000

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
officespacerentalapp/
  src/
    App.js         ← Main component with JSX logic
    App.css        ← Red/Green color classes
    index.js
    index.css
    reportWebVitals.js
    assets/
      office.jpg   ← Office space placeholder image
  public/
  package.json
```

## Expected Output
- Heading: "Office Space, at Affordable Range"
- Office image displayed at 25% width/height
- Single office item: **DBS**, Rent: **Rs. 50000** (RED), Address: **Chennai**
- List of 3 office spaces with conditional color:
  - DBS (50000 - RED)
  - Tech Park (75000 - GREEN)
  - Corporate Hub (45000 - RED)

## Completion Status
✅ Completed

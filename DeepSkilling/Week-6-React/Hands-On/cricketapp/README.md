# cricketapp

## Project Name
cricketapp

## Objective
Demonstrate ES6 features in React — `map()`, arrow functions, array destructuring, and the spread/merge operator.

## HOL Reference
React HOL 9 — ES6 Features (Mandatory)

## Technologies
- React 19
- Create React App (react-scripts 5.0.1)
- JavaScript ES6

## ES6 Features Demonstrated
| Feature | Where used |
|---------|-----------|
| `map()` | `ListofPlayers`, `Scorebelow70`, `ListofIndianPlayers` |
| Arrow functions | `filter()` callback in `Scorebelow70` |
| Array destructuring | `OddPlayers`, `EvenPlayers` components |
| Spread operator | Merging `T20Players` + `RanjiTrophyPlayers` → `IndianPlayers` |

## Components
- `ListofPlayers` — renders all 11 players via `map()`
- `Scorebelow70` — filters players with score ≤ 70 using arrow function
- `OddPlayers` — extracts 1st, 3rd, 5th player via array destructuring
- `EvenPlayers` — extracts 2nd, 4th, 6th player via array destructuring
- `ListofIndianPlayers` — renders the merged IndianPlayers array

## Flag Behaviour
Edit `flag` in `App.js`:
- `flag = true` → Shows List of Players + Players below 70
- `flag = false` → Shows Indian Team destructuring + Merged list

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
cricketapp/
  src/
    App.js
    App.css
    index.js
    data/
      players.js        ← 11-player array
      indianPlayers.js  ← IndianTeam + IndianPlayers (spread)
    components/
      ListofPlayers.js
      Scorebelow70.js
      OddPlayers.js
      EvenPlayers.js
      ListofIndianPlayers.js
  public/
  package.json
```

## Expected Output
**flag = true:**
- List of all 11 players (name + score)
- List of players with score ≤ 70 (Jack 50, Michael 70, John 40, Ann 61, Elisabeth 61, Jadeja 64)

**flag = false:**
- Odd Players: Sachin1, Virat3, Yuvaraj5
- Even Players: Dhoni2, Rohit4, Raina6
- Merged Indian Players list (First–Sixth Player)

## Completion Status
✅ Completed

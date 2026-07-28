// IndianTeam array for destructuring exercise
export const IndianTeam = [
  "Sachin1",
  "Dhoni2",
  "Virat3",
  "Rohit4",
  "Yuvaraj5",
  "Raina6",
];

// Merge T20Players and RanjiTrophyPlayers using spread operator (ES6)
const T20Players = ["First Player", "Second Player", "Third Player"];
const RanjiTrophyPlayers = ["Fourth Player", "Fifth Player", "Sixth Player"];
export const IndianPlayers = [...T20Players, ...RanjiTrophyPlayers];

import React from "react";

// Filters players with score <= 70 using arrow function
function Scorebelow70({ players }) {
  const filtered = players.filter((item) => item.score <= 70);
  return (
    <ul>
      {filtered.map((item) => (
        <div key={item.name}>
          <li>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        </div>
      ))}
    </ul>
  );
}

export default Scorebelow70;

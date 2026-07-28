import React from "react";

// Renders all players using ES6 map()
function ListofPlayers({ players }) {
  return (
    <ul>
      {players.map((item) => (
        <div key={item.name}>
          <li>
            Mr. {item.name} <span>{item.score}</span>
          </li>
        </div>
      ))}
    </ul>
  );
}

export default ListofPlayers;

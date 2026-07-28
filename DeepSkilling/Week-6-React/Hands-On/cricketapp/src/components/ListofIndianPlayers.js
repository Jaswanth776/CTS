import React from "react";

// Renders merged IndianPlayers array (spread operator result)
function ListofIndianPlayers({ IndianPlayers }) {
  return (
    <ul>
      {IndianPlayers.map((player) => (
        <li key={player}>Mr. {player}</li>
      ))}
    </ul>
  );
}

export default ListofIndianPlayers;

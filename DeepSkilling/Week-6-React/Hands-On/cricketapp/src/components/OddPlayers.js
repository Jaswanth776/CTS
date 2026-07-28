import React from "react";

// Uses ES6 array destructuring to extract odd-index players
export function OddPlayers([first, , third, , fifth]) {
  return (
    <div>
      <ul>
        <li>First : {first}</li>
        <li>Third : {third}</li>
        <li>Fifth : {fifth}</li>
      </ul>
    </div>
  );
}

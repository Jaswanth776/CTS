import "./App.css";
import players from "./data/players";
import { IndianTeam, IndianPlayers } from "./data/indianPlayers";
import ListofPlayers from "./components/ListofPlayers";
import Scorebelow70 from "./components/Scorebelow70";
import { OddPlayers } from "./components/OddPlayers";
import { EvenPlayers } from "./components/EvenPlayers";
import ListofIndianPlayers from "./components/ListofIndianPlayers";

// flag = true  → shows ListofPlayers and Scorebelow70
// flag = false → shows IndianTeam destructuring and merged IndianPlayers
var flag = true;

function App() {
  if (flag === true) {
    return (
      <div>
        <h1>List of Players</h1>
        <ListofPlayers players={players} />
        <hr />
        <h1>List of Players having Scores Less than 70</h1>
        <Scorebelow70 players={players} />
      </div>
    );
  } else {
    return (
      <div>
        <div>
          <h1>Indian Team</h1>
          <h1>Odd Players</h1>
          {OddPlayers(IndianTeam)}
          <hr />
          <h1>Even Players</h1>
          {EvenPlayers(IndianTeam)}
        </div>
        <hr />
        <div>
          <h1>List of Indian Players Merged:</h1>
          <ListofIndianPlayers IndianPlayers={IndianPlayers} />
        </div>
      </div>
    );
  }
}

export default App;

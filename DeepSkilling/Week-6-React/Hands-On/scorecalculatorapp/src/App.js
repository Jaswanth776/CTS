import "./App.css";
import CalculateScore from "./Components/CalculateScore";

function App() {
  return (
    <div className="App">
      <CalculateScore
        name="Jaswanth"
        school="Cognizant Academy"
        total={450}
        goal={5}
      />
    </div>
  );
}

export default App;

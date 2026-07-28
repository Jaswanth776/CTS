import "./App.css";
import officeImage from "./assets/office.jpg";

function App() {
  // JSX element
  const element = "Office Space";

  // JSX attribute
  const jsxatt = (
    <img src={officeImage} width="25%" height="25%" alt="Office Space" />
  );

  // JSX object
  const ItemName = { Name: "DBS", Rent: 50000, Address: "Chennai" };

  // Array of office spaces
  const offices = [
    { Name: "DBS", Rent: 50000, Address: "Chennai" },
    { Name: "Tech Park", Rent: 75000, Address: "Bangalore" },
    { Name: "Corporate Hub", Rent: 45000, Address: "Hyderabad" },
  ];

  // Determine color class based on rent
  const getRentColor = (rent) => {
    return rent <= 60000 ? "textRed" : "textGreen";
  };

  return (
    <div className="App">
      <h1>{element}, at Affordable Range</h1>
      {jsxatt}

      <h1>Name: {ItemName.Name}</h1>
      <h3 className={getRentColor(ItemName.Rent)}>
        Rent: Rs. {ItemName.Rent}
      </h3>
      <h3>Address: {ItemName.Address}</h3>

      <hr />
      <h2>Available Office Spaces</h2>
      <ul>
        {offices.map((office, index) => (
          <li key={index}>
            <strong>{office.Name}</strong> -{" "}
            <span className={getRentColor(office.Rent)}>
              Rs. {office.Rent}
            </span>{" "}
            - {office.Address}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;

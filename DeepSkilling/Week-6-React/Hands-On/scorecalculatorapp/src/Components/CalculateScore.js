import React from "react";
import "../Stylesheets/mystyle.css";

function CalculateScore(props) {
    const average = props.total / props.goal;

    return (
        <div className="container">
            <h1>Student Details</h1>

            <p><strong>Name:</strong> {props.name}</p>

            <p><strong>School:</strong> {props.school}</p>

            <p><strong>Total Marks:</strong> {props.total}</p>

            <p><strong>Subjects:</strong> {props.goal}</p>

            <h2>Average Score : {average}</h2>
        </div>
    );
}

export default CalculateScore;

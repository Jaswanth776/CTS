import React from "react";

// Conditional rendering using && operator
function CourseDetails({ courses }) {
  const coursedet =
    courses &&
    courses.length > 0 &&
    courses.map((course) => (
      <div key={course.id}>
        <h3>{course.name}</h3>
        <p>{course.date}</p>
      </div>
    ));

  return (
    <div className="mystyle1">
      <h1>Course Details</h1>
      {coursedet}
    </div>
  );
}

export default CourseDetails;

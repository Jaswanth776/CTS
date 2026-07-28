import "./App.css";
import { books } from "./data/books";
import { blogs } from "./data/blogs";
import { courses } from "./data/courses";
import BookDetails from "./components/BookDetails";
import BlogDetails from "./components/BlogDetails";
import CourseDetails from "./components/CourseDetails";

function App() {
  return (
    <div className="App">
      <div className="container">
        <CourseDetails courses={courses} />
        <BookDetails books={books} />
        <BlogDetails blogs={blogs} />
      </div>
    </div>
  );
}

export default App;

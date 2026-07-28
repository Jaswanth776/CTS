import { render, screen } from "@testing-library/react";
import App from "./App";

test("renders GitHub repositories heading", () => {
  render(<App />);

  const heading = screen.getByText(/GitHub Repositories/i);

  expect(heading).toBeInTheDocument();
});

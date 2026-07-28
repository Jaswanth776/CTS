# ticketbookingapp

## Project Name
ticketbookingapp

## Objective
Demonstrate conditional rendering in React using element variables and state-based UI toggling.

## HOL Reference
React HOL 12 — Conditional Rendering (Mandatory)

## Technologies
- React 19 (Class components)
- Create React App (react-scripts 5.0.1)
- JavaScript ES6

## Conditional Rendering Features
| Feature | Implementation |
|---------|----------------|
| Element variables | `let button; if (isLoggedIn) { button = <LogoutButton /> } else { button = <LoginButton /> }` |
| State-based rendering | `isLoggedIn` state toggles between Guest and User view |
| Conditional component | `Greeting` renders `<UserGreeting />` or `<GuestGreeting />` |
| Prevent component rendering | Button component chosen based on login state |

## Components
- **LoginControl** — Main component managing `isLoggedIn` state
- **Greeting** — Conditionally renders UserGreeting or GuestGreeting
- **GuestGreeting** — Displays "Please sign up."
- **UserGreeting** — Displays "Welcome back"
- **LoginButton** — Login button (shown when logged out)
- **LogoutButton** — Logout button (shown when logged in)

## Behaviour
| State | Greeting | Button |
|-------|----------|--------|
| Logged Out | "Please sign up." | [Login] |
| Logged In | "Welcome back" | [Logout] |

## Steps to Run
```bash
npm install
npm start
```

## Build
```bash
npm run build
```

## Folder Structure
```
ticketbookingapp/
  src/
    App.js
    App.css
    index.js
    components/
      LoginControl.js    ← Main state manager
      Greeting.js        ← Conditional greeting
      GuestGreeting.js
      UserGreeting.js
      LoginButton.js
      LogoutButton.js
  public/
  package.json
```

## Expected Output
**Initial (Logged Out):**
- Heading: "Ticket Booking App"
- Greeting: "Please sign up."
- Button: [Login]

**After Login:**
- Greeting: "Welcome back"
- Button: [Logout]

**After Logout:**
- Returns to logged-out state

## Completion Status
✅ Completed

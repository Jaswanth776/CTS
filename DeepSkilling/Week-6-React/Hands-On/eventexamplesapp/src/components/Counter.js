import React, { Component } from "react";

class Counter extends Component {
  constructor(props) {
    super(props);
    this.state = { count: 0 };
    // Bind event handlers
    this.handleIncrement = this.handleIncrement.bind(this);
    this.handleDecrement = this.handleDecrement.bind(this);
    this.sayHello = this.sayHello.bind(this);
    this.handleSayWelcome = this.handleSayWelcome.bind(this);
    this.handleOnPress = this.handleOnPress.bind(this);
  }

  // Increments the counter value
  handleIncrement() {
    this.setState({ count: this.state.count + 1 });
    // Invoke multiple methods on same event
    this.sayHello();
  }

  // Says hello - invoked alongside increment (multiple method invocation)
  sayHello() {
    alert("Hello! Member");
  }

  // Decrements the counter value
  handleDecrement() {
    this.setState({ count: this.state.count - 1 });
  }

  // Argument passing: receives "welcome" as argument
  handleSayWelcome(message) {
    alert(message);
  }

  // Synthetic event handler
  handleOnPress(e) {
    alert("I was clicked");
  }

  render() {
    return (
      <div>
        <h2>Counter: {this.state.count}</h2>
        <button onClick={this.handleIncrement}>Increment</button>
        &nbsp;
        <button onClick={this.handleDecrement}>Decrement</button>
        <br /><br />
        {/* Argument passing using arrow function */}
        <button onClick={() => this.handleSayWelcome("welcome")}>
          Say welcome
        </button>
        <br /><br />
        {/* Synthetic event */}
        <button onClick={this.handleOnPress}>Click on me</button>
      </div>
    );
  }
}

export default Counter;

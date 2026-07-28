import React, { Component } from "react";

class CurrencyConvertor extends Component {
  constructor(props) {
    super(props);
    this.state = {
      amount: "",
      currency: "",
    };
    this.handleSubmit = this.handleSubmit.bind(this);
    this.handleAmountChange = this.handleAmountChange.bind(this);
    this.handleCurrencyChange = this.handleCurrencyChange.bind(this);
  }

  handleAmountChange(e) {
    this.setState({ amount: e.target.value });
  }

  handleCurrencyChange(e) {
    this.setState({ currency: e.target.value });
  }

  // Click event handler: performs rupee → euro conversion (80 × amount)
  handleSubmit(e) {
    e.preventDefault();
    const convertedAmount = this.state.amount * 80;
    alert(
      `Converting to: ${this.state.currency} Amount is ${convertedAmount}`
    );
  }

  render() {
    return (
      <div style={{ marginTop: "20px" }}>
        <h2>Currency Convertor!!!</h2>
        <form onSubmit={this.handleSubmit}>
          <label>Amount: </label>
          <input
            type="number"
            value={this.state.amount}
            onChange={this.handleAmountChange}
          />
          <br /><br />
          <label>Currency: </label>
          <input
            type="text"
            value={this.state.currency}
            onChange={this.handleCurrencyChange}
          />
          <br /><br />
          <button type="submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default CurrencyConvertor;

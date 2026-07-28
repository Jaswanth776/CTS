import React, { Component } from "react";

class Getuser extends Component {

    constructor(props) {
        super(props);

        this.state = {
            title: "",
            firstName: "",
            picture: ""
        };
    }

    async componentDidMount() {

        const response = await fetch("https://api.randomuser.me/");
        const data = await response.json();

        const user = data.results[0];

        this.setState({
            title: user.name.title,
            firstName: user.name.first,
            picture: user.picture.large
        });
    }

    render() {

        return (

            <div style={{ textAlign: "center", marginTop: "30px" }}>

                <h2>User Details</h2>

                <img
                    src={this.state.picture}
                    alt="User"
                    width="180"
                />

                <h3>
                    {this.state.title} {this.state.firstName}
                </h3>

            </div>

        );
    }
}

export default Getuser;

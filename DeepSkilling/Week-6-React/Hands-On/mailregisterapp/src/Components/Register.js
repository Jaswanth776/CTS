import { useState } from "react";

function Register() {

    const [name, setName] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");

    const [errors, setErrors] = useState({});

    const validate = () => {

        let temp = {};

        if (name.length < 5)
            temp.name = "Name should contain at least 5 characters.";

        if (!(email.includes("@") && email.includes(".")))
            temp.email = "Email should contain @ and .";

        if (password.length < 8)
            temp.password = "Password should contain at least 8 characters.";

        setErrors(temp);

        return Object.keys(temp).length === 0;
    };

    const handleSubmit = (e) => {

        e.preventDefault();

        if (validate()) {

            alert("Registration Successful");

            setName("");
            setEmail("");
            setPassword("");
            setErrors({});
        }

    };

    return (

        <div style={{ padding: "20px" }}>

            <h2>Mail Registration</h2>

            <form onSubmit={handleSubmit}>

                <label>Name</label>

                <br />

                <input
                    type="text"
                    value={name}
                    onChange={(e) => setName(e.target.value)}
                />

                <br />

                <span style={{ color: "red" }}>
                    {errors.name}
                </span>

                <br /><br />

                <label>Email</label>

                <br />

                <input
                    type="email"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                />

                <br />

                <span style={{ color: "red" }}>
                    {errors.email}
                </span>

                <br /><br />

                <label>Password</label>

                <br />

                <input
                    type="password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                />

                <br />

                <span style={{ color: "red" }}>
                    {errors.password}
                </span>

                <br /><br />

                <button type="submit">
                    Register
                </button>

            </form>

        </div>

    );
}

export default Register;

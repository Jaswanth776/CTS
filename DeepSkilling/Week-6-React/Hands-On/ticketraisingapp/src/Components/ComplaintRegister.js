import { useState } from "react";

function ComplaintRegister() {

    const [employeeName, setEmployeeName] = useState("");
    const [complaint, setComplaint] = useState("");

    const handleSubmit = (e) => {

        e.preventDefault();

        const referenceNumber =
            "REF" + Math.floor(Math.random() * 100000);

        alert(
            `Complaint Raised Successfully!\n\nReference Number : ${referenceNumber}`
        );

        setEmployeeName("");
        setComplaint("");
    };

    return (

        <div style={{ padding: "20px" }}>

            <h2>Ticket Raising Application</h2>

            <form onSubmit={handleSubmit}>

                <label>Employee Name</label>

                <br />

                <input
                    type="text"
                    value={employeeName}
                    onChange={(e) =>
                        setEmployeeName(e.target.value)
                    }
                    required
                />

                <br /><br />

                <label>Complaint</label>

                <br />

                <textarea
                    rows="6"
                    cols="40"
                    value={complaint}
                    onChange={(e) =>
                        setComplaint(e.target.value)
                    }
                    required
                />

                <br /><br />

                <button type="submit">
                    Submit Complaint
                </button>

            </form>

        </div>

    );
}

export default ComplaintRegister;

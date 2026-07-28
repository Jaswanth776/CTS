import { useEffect, useState } from "react";
import GitClient from "./GitClient";

function App() {

    const [repos, setRepos] = useState([]);

    useEffect(() => {
        GitClient.getRepositories("techiesyed")
            .then(setRepos)
            .catch(console.error);
    }, []);

    return (
        <div style={{ padding: "20px" }}>
            <h2>GitHub Repositories</h2>

            <ul>
                {repos.map(repo => (
                    <li key={repo}>{repo}</li>
                ))}
            </ul>
        </div>
    );
}

export default App;

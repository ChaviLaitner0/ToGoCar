import React, { useState } from 'react';
import axios from 'axios';
import './Login.css'; // Make sure to create this CSS file

const Login = () => {
    const [id, setId] = useState('');

    const handleChange = (e) => {
        setId(e.target.value);
    };

    const handleSubmit = (e) => {
        e.preventDefault();
        axios.post(`https://localhost:7140/api/subscriber/login?id=${id}`)
            .then(response => {
                if (response.data) {
                    alert(`Welcome, ${response.data.firstName} ${response.data.lastName}!`);
                } else {
                    alert('Subscriber does not exist. Please register.');
                }
            })
            .catch(error => {
                console.error('There was an error logging in!', error);
            });
    };

    return (
        <div className="login-container">
            <form className="login-form" onSubmit={handleSubmit}>
                <h1 className="login-title">Subscriber Login</h1>
                <input type="text" name="id" placeholder="ID" value={id} onChange={handleChange} required />
                <button className="login-button" type="submit">Login</button>
            </form>
        </div>
    );
};

export default Login;

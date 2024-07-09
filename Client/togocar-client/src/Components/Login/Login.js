import React, { useState } from 'react';
import axios from 'axios';
import './Login.css';

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');

    const handleLogin = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('https://localhost:7140/api/login', {
                username,
                password
            });
            console.log(response.data);
        } catch (error) {
            console.error('Error logging in:', error);
        }
    };

    return (
        <div className="container">
            <h2 className="title">כניסה</h2>
            <form className="form" onSubmit={handleLogin}>
                <div className="form-field">
                    <label className="label">שם משתמש:</label>
                    <input className="input" type="text" value={username} onChange={(e) => setUsername(e.target.value)} />
                </div>
                <div className="form-field">
                    <label className="label">סיסמה:</label>
                    <input className="input" type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                </div>
                <button className="button" type="submit">התחבר</button>
            </form>
        </div>
    );
};

export default Login;

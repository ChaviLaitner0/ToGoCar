import React, { useState } from 'react';
import axios from 'axios';
import './Register.css';

const Register = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [email, setEmail] = useState('');

    const handleRegister = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('https://localhost:7140/api/register', {
                username,
                password,
                email
            });
            console.log(response.data);
        } catch (error) {
            console.error('Error registering:', error);
        }
    };

    return (
        <div className="container">
            <h2 className="title">הרשמה</h2>
            <form className="form" onSubmit={handleRegister}>
                <div className="form-field">
                    <label className="label">שם משתמש:</label>
                    <input className="input" type="text" value={username} onChange={(e) => setUsername(e.target.value)} />
                </div>
                <div className="form-field">
                    <label className="label">סיסמה:</label>
                    <input className="input" type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
                </div>
                <div className="form-field">
                    <label className="label">אימייל:</label>
                    <input className="input" type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
                </div>
                <button className="button" type="submit">הרשם</button>
            </form>
        </div>
    );
};

export default Register;

import React, { useState } from 'react';
import axios from 'axios';
import './Register.css'; // Make sure to create this CSS file

const Register = () => {
    const [formData, setFormData] = useState({
        firstName: '',
        lastName: '',
        age: '',
        id: '',
        licenseNumber: '',
        phone: '',
    });

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('https://localhost:7140/api/subscriber/check', { id: formData.id }, {
                headers: {
                    'Content-Type': 'application/json',
                }
            });
            if (response.data) {
                alert('User already registered. Please log in.');
            } else {
                await axios.post('https://localhost:7140/api/subscriber', formData, {
                    headers: {
                        'Content-Type': 'application/json',
                    }
                });
                alert('Registration successful!');
            }
        } catch (error) {
            console.error('There was an error registering!', error);
        }
    };

    return (
        <div className="register-container">
            <form className="register-form" onSubmit={handleSubmit}>
                <h1 className="register-title">Subscriber Registration</h1>
                <input type="text" name="firstName" placeholder="First Name" value={formData.firstName} onChange={handleChange} required />
                <input type="text" name="lastName" placeholder="Last Name" value={formData.lastName} onChange={handleChange} required />
                <input type="number" name="age" placeholder="Age" value={formData.age} onChange={handleChange} required />
                <input type="text" name="id" placeholder="ID" value={formData.id} onChange={handleChange} required />
                <input type="text" name="licenseNumber" placeholder="License Number" value={formData.licenseNumber} onChange={handleChange} required />
                <input type="tel" name="phone" placeholder="Phone" value={formData.phone} onChange={handleChange} required />
                <button className="register-button" type="submit">Register</button>
            </form>
        </div>
    );
};

export default Register;





import React from 'react';
import { Link } from 'react-router-dom';
import './HomePage.css';

const HomePage = () => {
    return (
        <div className="container">
            <h1 className="title">ברוכים הבאים ל-TOGOCAR</h1>
            <div className="button-container">
                <Link className="styled-link" to="/login">כניסה</Link>
                <Link className="styled-link" to="/register">הרשמה</Link>
            </div>
        </div>
    );
};

export default HomePage;

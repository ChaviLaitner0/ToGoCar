import React from 'react';
import './App.css';
import Register from './Components/Register/Register';
import Login from './Components/Login/Login';

function App() {
    return (
        <div className="App">
            <div className="form-container">
                <Register />
                <Login />
            </div>
        </div>
    );
}

export default App;

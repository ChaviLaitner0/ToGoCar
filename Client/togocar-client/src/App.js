import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import CarComponent from './Components/Car/CarComponent';
import RentalComponent from './Components/Rental/RentalComponent';
import SubscriberComponent from './Components/Subscriber/SubscriberComponent';
import HomePage from './Components/HomePage/HomePage';
import Login from './Components/Login/Login';
import Register from './Components/Register/Register';

function App() {
    return (
        <Router>
            <div>
                <Routes>
                    <Route path="/cars" element={<CarComponent />} />
                    <Route path="/rentals" element={<RentalComponent />} />
                    <Route path="/subscribers" element={<SubscriberComponent />} />
                    <Route path="/" element={<HomePage />} />
                    <Route path="/login" element={<Login />} />
                    <Route path="/register" element={<Register />} />
                </Routes>
            </div>
        </Router>
              
         
    );
}

export default App;

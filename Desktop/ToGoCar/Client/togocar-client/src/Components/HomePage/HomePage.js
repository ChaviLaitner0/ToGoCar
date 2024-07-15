import React from 'react';
import './HomePage.css';

const HomePage = () => {
    return (
        <div className="homepage">
            {/* <div className="hero-section">
                <h1>Welcome to TOGOCAR</h1>
                <p>The leading cooperative car rental service</p>
            </div> */}
            <div className="content-section">
                <h2>Why Choose TOGOCAR?</h2>
                <ul>
                    <li>Immediate Availability: Our cars are available for rent 24/7, and you can book a vehicle at any time, directly from the app or the website.</li>
                    <li>Wide Range of Vehicles: A broad selection.</li>
                    <li>Competitive Prices: Affordable and convenient rental.</li>
                    <li>Simplicity and Convenience: The rental process.</li>
                    <li>Dedicated Customer Service: Our support.</li>
                </ul>
            </div>
            <div className="content-section">
                <h2>How Does It Work?</h2>
                <ol>
                    <li>Download the App: Download the TOGOCAR app to your mobile device.</li>
                    <li>Register: Complete a short registration.</li>
                    <li>Choose a Car: Search for the car that suits your needs based on location, type, and size.</li>
                    <li>Book and Pick Up: Book the car directly from the app and pick it up from the most convenient location for you.</li>
                    <li>Safe and Enjoyable Driving: Enjoy a safe and comfortable ride with a clean and well-maintained vehicle.</li>
                    <li>Return the Car: At the end of your use, return the car to one of TOGOCAR's return locations.</li>
                </ol>
            </div>
            <div className="join-section">
                <h2>Join Us!</h2>
                <p>Join the cooperative car rental revolution with TOGOCAR and enjoy the benefits of flexible, cost-effective, and eco-friendly transportation. Download the app and start moving freely!</p>
                <p>TOGOCAR - The Smart Way to Move.</p>
            </div>
        </div>
    );
};

export default HomePage;

import React, { useEffect, useState } from 'react';
import { getRentals } from '../../apiService';

const RentalComponent = () => {
    const [rentals, setRentals] = useState([]);

    useEffect(() => {
        getRentals()
            .then(data => setRentals(data))
            .catch(error => console.error("Error fetching rentals:", error));
    }, []);

    return (
        <div>
            <h2>Rentals List</h2>
            <ul>
                {rentals.map(rental => (
                    <li key={rental.id}>{rental.carName} - {rental.renterName}</li>
                ))}
            </ul>
        </div>
    );
};

export default RentalComponent;

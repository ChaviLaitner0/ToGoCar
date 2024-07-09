import React, { useEffect, useState } from 'react';
import { getCars } from '../../apiService';

const CarComponent = () => {
    const [cars, setCars] = useState([]);

    useEffect(() => {
        getCars()
            .then(data => setCars(data))
            .catch(error => console.error("Error fetching cars:", error));
    }, []);

    return (
        <div>
            <h2>Cars List</h2>
            <ul>
                {cars.map(car => (
                    <li key={car.id}>{car.name} - {car.type}</li>
                ))}
            </ul>
        </div>
    );
};

export default CarComponent;

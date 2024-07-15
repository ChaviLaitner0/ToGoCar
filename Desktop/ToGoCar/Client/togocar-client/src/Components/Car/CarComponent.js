import React, { useState, useEffect } from 'react';
import { getCars } from '../../apiService';

const CarComponent = () => {
    const [cars, setCars] = useState([]);
    const [selectedCar, setSelectedCar] = useState(null);

    const fetchCars = async () => {  // הגדרת הפונקציה fetchCars
        try {
            const data = await getCars();
            setCars(data);
        } catch (error) {
            console.error("Error fetching cars:", error);
        }
    };

    useEffect(() => {
        fetchCars();
    }, []);

    const handleSelectCar = (car) => {
        setSelectedCar(car);
    };

    return (
        <div>
            <button onClick={() => fetchCars()}>Load Cars</button>
            <ul>
                {cars.map((car) => (
                    <li key={car.carNumber} onClick={() => handleSelectCar(car)}>
                        {car.model} - {car.carType}
                    </li>
                ))}
            </ul>
            {selectedCar && (
                <div>
                    <h2>Car Details</h2>
                    <p>Model: {selectedCar.model}</p>
                    <p>Type: {selectedCar.carType}</p>
                    <p>Parking Number: {selectedCar.parkingNumber}</p>
                    <p>Amount: {selectedCar.amount}</p>
                </div>
            )}
        </div>
    );
};

export default CarComponent;

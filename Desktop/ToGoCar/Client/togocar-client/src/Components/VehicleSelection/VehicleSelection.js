import React, { useState, useEffect } from 'react';
import axios from 'axios';

const VehicleSelection = () => {
    const [vehicles, setVehicles] = useState([]);

    useEffect(() => {
        axios.get('https://localhost:7140/api/car/all')
            .then(response => {
                setVehicles(response.data);
            })
            .catch(error => {
                console.error('There was an error fetching the vehicles!', error);
            });
    }, []);

    return (
        <div className="vehicle-selection">
            <h1>Vehicle Selection</h1>
            <table>
                <thead>
                    <tr>
                        <th>Car Number</th>
                        <th>Model</th>
                        <th>Car Type</th>
                        <th>Parking Number</th>
                        <th>Amount</th>
                        <th>Select</th>
                    </tr>
                </thead>
                <tbody>
                    {vehicles.map(vehicle => (
                        <tr key={vehicle.carNumber}>
                            <td>{vehicle.carNumber}</td>
                            <td>{vehicle.model}</td>
                            <td>{vehicle.carType}</td>
                            <td>{vehicle.parkingNumber}</td>
                            <td>{vehicle.amount}</td>
                            <td>
                                <button onClick={() => handleSelectVehicle(vehicle)}>Select</button>
                            </td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </div>
    );

    function handleSelectVehicle(vehicle) {
        console.log('Selected vehicle:', vehicle);
        // Implement the logic for selecting a vehicle
    }
}

export default VehicleSelection;

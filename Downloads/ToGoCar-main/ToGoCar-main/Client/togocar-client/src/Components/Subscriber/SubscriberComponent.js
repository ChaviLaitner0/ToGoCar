import React, { useEffect, useState } from 'react';
import { getSubscribers } from '../../apiService';

const SubscriberComponent = () => {
    const [subscribers, setSubscribers] = useState([]);

    useEffect(() => {
        getSubscribers()
            .then(data => setSubscribers(data))
            .catch(error => console.error("Error fetching subscribers:", error));
    }, []);

    return (
        <div>
            <h2>Subscribers List</h2>
            <ul>
                {subscribers.map(subscriber => (
                    <li key={subscriber.id}>{subscriber.name} - {subscriber.email}</li>
                ))}
            </ul>
        </div>
    );
};

export default SubscriberComponent;

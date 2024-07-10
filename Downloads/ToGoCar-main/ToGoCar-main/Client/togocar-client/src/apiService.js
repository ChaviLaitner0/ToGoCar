import axios from 'axios';

const API_BASE_URL = 'https://localhost:7140'; // Update with your API base URL

export const getCars = async () => {
    try {
        const response = await axios.get(`${API_BASE_URL}/cars`);
        return response.data;
    } catch (error) {
        console.error("Error fetching cars:", error);
        throw error;
    }
};

export const getRentals = async () => {
    try {
        const response = await axios.get(`${API_BASE_URL}/rentals`);
        return response.data;
    } catch (error) {
        console.error("Error fetching rentals:", error);
        throw error;
    }
};

export const getSubscribers = async () => {
    try {
        const response = await axios.get(`${API_BASE_URL}/subscribers`);
        return response.data;
    } catch (error) {
        console.error("Error fetching subscribers:", error);
        throw error;
    }
};

import axios from 'axios';

const API_URL = 'http://localhost:5252/api'; // .NET Core API endpoint

export const getEpisodes = async () => {
  try {
    const response = await axios.get(`${API_URL}/episodes`);
    return response.data;
  } catch (error) {
    console.error('Error fetching episodes', error);
    throw error;
  }
};

export const getCharacters = async () => {
  try {
    const response = await axios.get(`${API_URL}/characters`);
    return response.data;
  } catch (error) {
    console.error('Error fetching characters', error);
    throw error;
  }
};

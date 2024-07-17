import React, { useState, useEffect } from 'react';
import { getEpisodes, getCharacters } from './api';

function App() {
  const [episodes, setEpisodes] = useState([]);
  const [characters, setCharacters] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        const episodesData = await getEpisodes();
        const charactersData = await getCharacters();
        setEpisodes(episodesData);
        setCharacters(charactersData);
      } catch (error) {
        console.error('Error fetching data', error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="App">
      <h1>Rick and Morty Episodes and Characters</h1>
      <div>
        <h2>Episodes</h2>
        <ul>
          
          {episodes.map((episode) => (
            <li key={episode.id}>{episode.name}</li>
          ))}
        </ul>
      </div>
      <div>
        <h2>Characters</h2>
        <ul>
          {characters.map((character) => (
            <li key={character.id}>{character.name}</li>
          ))}
        </ul>
      </div>
    </div>
  );
}

export default App;

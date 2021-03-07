import './App.css';
import {  Navbar, ListGroup } from 'react-bootstrap';
import { useEffect, useState } from 'react';
import api from './services/service'

function App() {
  const [todos, setTodos] = useState([]);

  useEffect(() => {
    api.get('/api/person').then((response) => {
      console.log(response);
      setTodos(response.data);
    });
  });

  return (
    <div className="App">
      <Navbar bg='dark'>
        <Navbar.Brand style={{color: "white"}}>Lista de Nomes</Navbar.Brand>
      </Navbar>
      <ListGroup style={{ margin: '70px 40px' }}>
        { todos.map((item) => {
          return ( <ListGroup.Item style={{ textAlign: 'center' }}>{item.name}</ListGroup.Item> )
        }) }
      </ListGroup>
    </div>
  );
}

export default App;
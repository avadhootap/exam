import React, { Component, useEffect, useState } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';

const App = () => {

  const [player, setplayers] = useState([]);

  useEffect(() => {
    fetch("api/player/Getplayers")
    .then(response => { return response.json();})
    .then(responseJson => {
      console.log(responseJson);
      setplayers(responseJson)
    })
  },[])


  return (
  <div className="container">

  <h1>Players</h1>
    <div className="row">
      <div className='col-sm-12'>
        <table className="table table-striped">
          <thead>
            <tr>
              <th>ID</th>
              <th>PName</th>
              <th>PAge</th>
              <th>Pcountry</th>
            </tr>
          </thead>
          <tbody>
            {
              player.map((item) => (
                <tr key={item.id}>
                  <td>{item.id}</td>
                  <td>{item.pname}</td>
                  <td>{item.page}</td>
                  <td>{item.pcountry}</td>
                </tr>
              ))
            }
          </tbody>
        </table>
      </div>
    </div>
  </div>

  )
} 
export default App;

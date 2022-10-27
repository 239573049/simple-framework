import './App.css';
import { Component } from 'react';
import Routes from './router';
import {
  BrowserRouter
} from 'react-router-dom';

class App extends Component {

  render() {
    return (
      <BrowserRouter>
        <Routes />
      </BrowserRouter>
    );
  }
}

export default App;

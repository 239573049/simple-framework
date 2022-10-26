import './App.css';
import React, { Component } from 'react';
import { Button, Toast } from '@douyinfe/semi-ui';

class App extends React.Component {
  constructor(props: any) {
    super(props);
  }

  render() {
    return <Button onClick={() => Toast.warning({ content: 'welcome' })}>Hello Semi</Button>;
  }
}

export default App;

import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { NoteData } from './components/NoteData';
import { Counter } from './components/Counter';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={NoteData} />
      </Layout>
    );
  }
}

import React, { Component } from 'react';
import NoteCard from '../components/NoteCard';
import NoteEditActionButton from '../components/NoteEditActionButton';
import { Header } from './Header';

export class Layout extends Component {
  render () {
    return (
      <div>
        <Header></Header>
          <NoteCard />
          <NoteEditActionButton />
      </div>
    );
  }
}

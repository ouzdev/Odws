import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { Header } from './Header';

export class Layout extends Component {
  render () {
    return (
      <div>
        <Header></Header>
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}

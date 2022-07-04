import React, { Component } from 'react';
import NavMenu from '../../components/NavBar/index';


export class Header extends Component {
  static displayName = Header.name;

  render () {

    return (
      <div>
        <NavMenu />
      </div>
    );
  }
}

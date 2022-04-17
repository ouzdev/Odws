import React, { Component } from 'react';
import NavMenu from '../../components/NavBar/NavMenu';


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

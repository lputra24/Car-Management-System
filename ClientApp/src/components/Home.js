import React, { Component } from 'react';
import { Image } from 'react-bootstrap';
import '../style/Home.scss';

import DataTable from './DataTable.js'

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div className="container">
            <DataTable/>
      </div>
    );
  }
}

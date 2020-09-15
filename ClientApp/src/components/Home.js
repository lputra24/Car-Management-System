import React, { Component } from 'react';
import { Image } from 'react-bootstrap';
import '../style/Home.scss';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div className="container">
            <Image src="/cmslogo2.png" fluid />
      </div>
    );
  }
}

import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import { TitleBar } from './TitleBar';

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <TitleBar />
        <NavMenu />
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}

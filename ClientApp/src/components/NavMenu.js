import React from 'react'
import { Navbar, Nav, NavDropdown } from 'react-bootstrap';

function NavMenu() {
    return (
        <div>
            <Navbar bg="dark" variant="dark">
                <Navbar.Brand href="#home"><img
                    src="/carsales-white.svg"
                    width="100"
                    height="50"
                    className="d-inline-block align-top"
                    alt="React Bootstrap logo"
                /></Navbar.Brand>
                <Nav className="mr-auto">
                    <Nav.Link href="#home">Home</Nav.Link>


                    <NavDropdown title="Create" id="basic-nav-dropdown">
                        <NavDropdown.Item href="#action/3.1">Create new car</NavDropdown.Item>
                        
                    </NavDropdown>
                </Nav>
                
            </Navbar>

            

        </div>
    )
}

export default NavMenu
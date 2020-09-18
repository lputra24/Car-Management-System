import React from 'react'
import { Navbar} from 'react-bootstrap';


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
                <h3 style={{ color: "white"}}>VEHICLE MANAGEMENT SYSTEM</h3>
                
            </Navbar>
           
            

        </div>
    )
}

export default NavMenu
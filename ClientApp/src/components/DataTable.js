import React, { useState, useEffect } from 'react';
import { Table, Button, NavDropdown } from 'react-bootstrap'
import API from '../Helper/API.js'
import { VEHICLE } from '../Constant.js'
import AddModal from './AddModal.js';
import '../style/DataTable.scss'

const DataTable = (props) => {

    const [data, updateData] = useState([])
    const [isUpdating,changeIsUpdating] = useState(false)

    const api = new API();

    const fetchData = () => {
        changeIsUpdating(true);
        return api.getData(VEHICLE.car)
            .then(response => {
                updateData(response.data);
                changeIsUpdating(false);
            })
            .catch((err) => console.log(err));
    }

    useEffect(() => {
        fetchData()
    }, []);

    

    return (
        <div>
            <div className='buttonGroup'>
                <AddModal />
                <Button variant="warning" onClick={fetchData} disabled={isUpdating}>
                    Refresh
                </Button>
                <NavDropdown title="Create" id="basic-nav-dropdown">
                    <NavDropdown.Item href="#action/3.1">Car</NavDropdown.Item>

                </NavDropdown>
            </div>
            <Table striped bordered hover responsive>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Make</th>
                        <th>Model</th>
                        <th>Engine</th>
                        <th>Doors</th>
                        <th>Wheels</th>
                        <th>Body Type</th>

                    </tr>
                </thead>
                <tbody>

                    {data.map(d =>
                        <tr>
                            <td>{d.id}</td>
                            <td>{d.make}</td>
                            <td>{d.model}</td>
                            <td>{d.engine}</td>
                            <td>{d.doors}</td>
                            <td>{d.wheels}</td>
                            <td>{d.bodyType}</td>
                            <Button/>
                        </tr>
                    )}
                </tbody>
            </Table>
        </div>
        
    )

}

export default DataTable;
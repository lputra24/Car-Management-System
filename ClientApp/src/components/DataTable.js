import React, { useState, useEffect } from 'react';
import { Table, Button, NavDropdown } from 'react-bootstrap'
import API from '../Helper/API.js'
import { VEHICLE } from '../Constant.js'
import AddModal from './AddModal.js';
import VehicleSelect from './VehicleSelect.js'
import '../style/DataTable.scss'

const DataTable = (props) => {

    const [data, updateData] = useState([])
    const [isUpdating, changeIsUpdating] = useState(false)
    const [curVehicle, changeCurVehicle] = useState(VEHICLE.car)

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

    const handleDelete = id => {
        changeIsUpdating(true);
        return api.deleteData(VEHICLE.car,id)
            .then(response => {
                fetchData()
            })
            .catch((err) => console.log(err));
    }

    useEffect(() => {
        fetchData()
    }, []);

    

    return (
        <div style={{ textAlign: "center" }}>
            <h1 style={{ fontSize: "3.7rem", padding: "15px" }}>{curVehicle.toUpperCase()}</h1>
            <div className='buttonGroup'>
                <AddModal updateTable={updateData} curVehicle={curVehicle}/>
                <Button variant="warning" onClick={fetchData} disabled={isUpdating}>
                    Refresh
                </Button>
                <VehicleSelect changeCurVehicle={changeCurVehicle} />
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
                        <tr key={d.id}>
                            <td>{d.id}</td>
                            <td>{d.make}</td>
                            <td>{d.model}</td>
                            <td>{d.engine}</td>
                            <td>{d.doors}</td>
                            <td>{d.wheels}</td>
                            <td>{d.bodyType}</td>
                            <td><Button variant="danger" size="sm" onClick={() => handleDelete(d.id)} disabled={isUpdating}>X</Button></td>
                        </tr>
                    )}
                </tbody>
            </Table>
        </div>
        
    )

}

export default DataTable;
import React from 'react'
import { VEHICLE } from '../Constant.js'


function VehicleSelect(props) {

    const handleInputChange = (event) => {
        props.changeCurVehicle(event.target.value)    
    }

    return (

        <select className="form-control" name="vehicle" onChange={handleInputChange} style={{ alignSelf: "center",width: "auto" }}>
            <option value={VEHICLE.car}>{VEHICLE.car}</option>
        </select>

    )
}

export default VehicleSelect
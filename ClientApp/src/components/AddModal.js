import React, { useState } from 'react';
import { Modal, Button } from 'react-bootstrap';
import CarModalForm from './CarModalForm.js'


const AddModal = (props) => {
    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);
    return (
        <>
            <Button variant="success" onClick={handleShow}>
                Add Data
            </Button>

            <Modal show={show} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>ADD NEW {props.curVehicle.toUpperCase()}</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <CarModalForm updateTable={props.updateTable}/>
                </Modal.Body>
                -
            </Modal>
        </>
    )

}

export default AddModal;
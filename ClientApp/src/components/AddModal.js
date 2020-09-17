import React, { useState } from 'react';
import { Modal, Button } from 'react-bootstrap';
import CarModalForm from './CarModalForm.js'


const AddModal = () => {
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
                    <Modal.Title>Modal heading</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <CarModalForm/>
                </Modal.Body>
                -
            </Modal>
        </>
    )

}

export default AddModal;
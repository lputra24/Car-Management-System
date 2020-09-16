import React, { useState } from 'react';
import { Modal, Button } from 'react-bootstrap';
import AddModalForm from './AddModalForm.js'


const AddModal = () => {
    const [show, setShow] = useState(false);

    const handleClose = () => setShow(false);
    const handleShow = () => setShow(true);
    return (
        <>
            <div onClick={handleShow}>
                Create new car
            </div>

            <Modal show={show} onHide={handleClose}>
                <Modal.Header closeButton>
                    <Modal.Title>Modal heading</Modal.Title>
                </Modal.Header>
                <Modal.Body>
                    <AddModalForm/>
                </Modal.Body>
                
            </Modal>
        </>
    )

}

export default AddModal;
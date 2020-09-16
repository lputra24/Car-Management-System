import React, { useState } from 'react';
import { Form,Button,Col } from 'react-bootstrap';
import Api from '../Helper/API.js'
import { Formik } from 'formik';
import { validateCarSchema } from '../Helper/FormValidationSchema.js'
import '../style/Form.scss';

const AddModalForm = () => {
    const [show, setShow] = useState(false);

    const api = new Api();

    const AddCar = (data) => {
        api
            .addNewData(data,'/car')
            .then((response) => console.log(response))
            .catch((err) => console.log(err));
    }


    


    return (

        <div>
            <Formik
                initialValues={{ make: "", model: "", engine: "", doors: "", wheels: "", bodyType: "" }}
                validationSchema={validateCarSchema}
                onSubmit={(values, { setSubmitting, resetForm }) => {
                    // When button submits form and form is in the process of submitting, submit button is disabled
                    setSubmitting(true);

                    values.VehicleTypeID = 1;
                    console.log(values)

                    api
                        .addNewData(values, '/car')
                        .then((response) => {
                            console.log(response);
                            resetForm();
                            setSubmitting(false);
                        })
                        .catch((err) => console.log(err));

                    // Resets form after submission is complete
                    

                    // Sets setSubmitting to false after form is reset
                    
                }}
            >
                {({ values,
                    errors,
                    touched,
                    handleChange,
                    handleBlur,
                    handleSubmit,
                    isSubmitting }) => (
                        <Form onSubmit={handleSubmit}>
                           
                        <Form.Group controlId="formMake">
                            <Form.Label>Make :</Form.Label>
                            <Form.Control
                                    type="text"
                                    name="make"
                                    placeholder="e.g. Honda"
                                    onChange={handleChange}
                                    onBlur={handleBlur}
                                    value={values.make}
                                    className={touched.make && errors.make ? 'error' : null}
                                />
                                {touched.make && errors.make ? (
                                    <div className="error__message__on">{errors.make}</div>
                                ) : null}
                        </Form.Group>

                        <Form.Group controlId="formModel">
                            <Form.Label>Model :</Form.Label>
                            <Form.Control
                                type="text"
                                name="model"
                                    placeholder="e.g. Civic"
                                    onChange={handleChange}
                                    onBlur={handleBlur}
                                    className={touched.model && errors.model ? 'error' : null}
                                />
                                {touched.model && errors.model ? (
                                    <div className="error__message__on">{errors.model}</div>
                                ) : null}
                        </Form.Group>

                        <Form.Group controlId="formEngine">
                            <Form.Label>Engine :</Form.Label>
                            <Form.Control
                                type="text"
                                name="engine"
                                placeholder="e.g. 2.0T Petrol 8 sp Automatic RWD"
                                onChange={handleChange}
                                onBlur={handleBlur}
                                    className={touched.engine && errors.engine ? 'error' : null}
                                />
                                {touched.engine && errors.engine ? (
                                    <div className="error__message__on">{errors.engine}</div>
                                ) : null}
                        </Form.Group>

                        <Form.Row>
                            <Col>
                                <Form.Group controlId="formDoors">
                                    <Form.Label>Doors :</Form.Label>
                                    <Form.Control
                                        type="number"
                                        name="doors"
                                        placeholder="e.g. 4"
                                        onChange={handleChange}
                                        onBlur={handleBlur}
                                        className={touched.doors && errors.doors ? 'error' : null}
                                    />
                                    {touched.doors && errors.doors ? (
                                        <div className="error__message__on">{errors.doors}</div>
                                    ) : null}
                                </Form.Group>
                            </Col>
                            <Col>
                                <Form.Group controlId="formWheels">
                                    <Form.Label>Wheels :</Form.Label>
                                    <Form.Control
                                        type="number"
                                        name="wheels"
                                        placeholder="e.g. 4"
                                        onChange={handleChange}
                                        onBlur={handleBlur}
                                        className={touched.wheels && errors.wheels ? 'error' : null}
                                    />
                                    {touched.wheels && errors.wheels ? (
                                        <div className="error__message__on">{errors.wheels}</div>
                                    ) : null}
                                        
                                </Form.Group>
                            </Col>

                        </Form.Row>

                        <Form.Group controlId="formBody">
                            <Form.Label>Body Type :</Form.Label>
                            <Form.Control
                                    type="text"
                                    name="bodyType"
                                    placeholder="e.g. sedan"
                                    onChange={handleChange}
                                    onBlur={handleBlur}
                                    className={touched.bodyType && errors.bodyType ? 'error' : null}
                                />
                                {touched.bodyType && errors.bodyType ? (
                                    <div className="error__message__on">{errors.bodyType}</div>
                                ) : null}
                        </Form.Group>


                            <Button variant="primary" type='submit' disabled={isSubmitting}>
                            Submit
            </Button>

                    </Form>
                    )}
            </Formik>
        </div>
        
    )
}

export default AddModalForm;
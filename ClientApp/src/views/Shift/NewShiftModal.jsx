import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, SubmitBtn } from "../../components/Form";

const NewShiftModal = ({
  show,
  setShow,
  shift,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={shift}
      validationSchema={schema}
      onSubmit={(shift, { resetForm }) => {
        resetForm();
        handleSubmit(shift);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {shift.id === 0 ? "New Shift" : "Update Shift"}
              </Modal.Title>
            </Modal.Header>
            <Modal.Body>
              <DateField name="time" label="Time" dateFormat={false} required />
            </Modal.Body>
            <Modal.Footer>
              <Button onClick={() => setShow(false)} className="btn-secondary">
                Close
              </Button>
              <SubmitBtn />
            </Modal.Footer>
          </Modal>
        </>
      )}
    </Formik>
  );
};

export default NewShiftModal;

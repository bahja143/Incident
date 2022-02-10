import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, TextAreaField, SubmitBtn } from "../../components/Form";

const NewRTGModal = ({
  show,
  setShow,
  RTG,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={RTG}
      validationSchema={schema}
      onSubmit={(RTG, { resetForm }) => {
        resetForm();
        handleSubmit(RTG);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {RTG.id === 0 ? "New RTG" : "Update RTG"}
              </Modal.Title>
            </Modal.Header>
            <Modal.Body>
              <TextField name="name" label="Name" required />
              <TextAreaField name="description" label="description" />
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

export default NewRTGModal;

import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, TextAreaField, SubmitBtn } from "../../components/Form";

const NewMCModal = ({
  show,
  setShow,
  MC,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={MC}
      validationSchema={schema}
      onSubmit={(MC, { resetForm }) => {
        resetForm();
        handleSubmit(MC);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {MC.id === 0 ? "New MC" : "Update MC"}
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

export default NewMCModal;

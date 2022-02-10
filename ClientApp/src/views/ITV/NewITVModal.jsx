import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, TextAreaField, SubmitBtn } from "../../components/Form";

const NewITVModal = ({
  show,
  setShow,
  ITV,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={ITV}
      validationSchema={schema}
      onSubmit={(ITV, { resetForm }) => {
        resetForm();
        handleSubmit(ITV);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {ITV.id === 0 ? "New ITV" : "Update ITV"}
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

export default NewITVModal;

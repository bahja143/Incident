import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, TextAreaField, SubmitBtn } from "../../components/Form";

const NewECHModal = ({
  show,
  setShow,
  ECH,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={ECH}
      validationSchema={schema}
      onSubmit={(ECH, { resetForm }) => {
        resetForm();
        handleSubmit(ECH);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {ECH.id === 0 ? "New ECH" : "Update ECH"}
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

export default NewECHModal;

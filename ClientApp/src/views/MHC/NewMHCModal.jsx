import React from "react";
import { Formik } from "formik";

import { Modal, Button } from "react-bootstrap";
import { TextField, DateField, TextAreaField, SubmitBtn } from "../../components/Form";

const NewMHCModal = ({
  show,
  setShow,
  MHC,
  schema,
  handleSubmit,
}) => {
  return (
    <Formik
      enableReinitialize={true}
      initialValues={MHC}
      validationSchema={schema}
      onSubmit={(MHC, { resetForm }) => {
        resetForm();
        handleSubmit(MHC);
      }}
    >
      {() => (
        <>
          <Modal show={show}>
            <Modal.Header>
              <Modal.Title>
                {MHC.id === 0 ? "New MHC" : "Update MHC"}
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

export default NewMHCModal;

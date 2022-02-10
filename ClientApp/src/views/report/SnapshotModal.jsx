import React from "react";

import { Modal, Button } from "react-bootstrap";
import { Card, Row, Col } from "react-bootstrap";
import { SelectField, TextAreaField } from "../../components/Form";

import { Formik } from "formik";

const SnapshotModal = ({ show, setClose, snapshot, title }) => {
  const shifts = [
    { value: "7:00 - 11:00 am", label: "7:00 - 11:00 am" },
    { value: "12:00 - 4:00 pm", label: "12:00 - 4:00 pm" },
    { value: "5:00 - 7:00 pm", label: "5:00 - 7:00 pm" },
    { value: "7:00 - 11:00 pm", label: "7:00 - 11:00 pm" },
    { value: "12:00 - 4:00 am", label: "12:00 - 4:00 am" },
    { value: "5:00 - 7:00 am", label: "5:00 - 7:00 am" },
  ];
  const categories = [
    { label: "Safety", value: "safety" },
    { label: "Environment", value: "environment" },
    { label: "Security", value: "security" },
  ];
  const incidentTypes = [
    { label: "Not wearing ppe", value: "not wearing ppe" },
    { label: "Driving high speed", value: "driving high speed" },
    {
      label: "Working/Standing under suspension",
      value: "working/Standing under suspension",
    },
  ];
  const locations = [
    { label: "Main Yard", value: "main yard" },
    { label: "Queyside", value: "queyside" },
    { label: "Gate1", value: "gate1" },
    { label: "Gate2", value: "gate2" },
    { label: "Gate3", value: "gate3" },
    { label: "Gate4", value: "gate4" },
    { label: "Gate-pregate", value: "gate-pregate" },
    { label: "Gate-In", value: "gate-in" },
    { label: "Gate-Out", value: "gate-out" },
  ];
  const peoples = [
    { label: "Third part labor", value: "third part labor" },
    { label: "Employee", value: "employee" },
    {
      label: "Employee with third part labor",
      value: "employee with third part labor",
    },
  ];
  const equipmenties = [
    { label: "Personal car", value: "personal car" },
    { label: "Terminal pick up", value: "terminal pick up" },
    { label: "MHC", value: "mhc" },
    { label: "QC", value: "qc" },
    { label: "RS", value: "rs" },
    { label: "RTG", value: "rtg" },
    { label: "ITV", value: "itv" },
    { label: "ECH", value: "ech" },
    { label: "MC", value: "mc" },
    { label: "ML", value: "ml" },
    { label: "FL", value: "fl" },
  ];
  const responsiblies = [
    { label: "Operarion", value: "operations" },
    { label: "Technical", value: "technical" },
    { label: "Safety", value: "safety" },
    { label: "IT", value: "it" },
    { label: "Finance", value: "finance" },
    { label: "HR", value: "hr" },
    { label: "Security", value: "security" },
    { label: "Clinical", value: "clinical" },
    { label: "Others", value: "others" },
  ];
  const status = [
    { label: "Open", value: "open" },
    { label: "Close", value: "close" },
  ];

  const handleStringToArray = (str = "") => {
    const array = str.split(",");
    const buffer = [];

    for (let index = 0; index < array.length; index++) {
      buffer[index] = array[index];
    }

    const data = new Uint8Array(buffer);

    return data;
  };

  const fileImage = URL.createObjectURL(
    new Blob([handleStringToArray(snapshot.image)], { type: "image/png" })
  );

  return (
    <Modal show={show} size="lg">
      <Modal.Header>
        <Modal.Title>{title}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Formik initialValues={snapshot} enableReinitialize={true}>
          {() => (
            <>
              <Card.Body>
                <Row>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="category"
                      label="Category"
                      options={categories}
                    />
                  </Col>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="incidentType"
                      label="Incident Type"
                      options={incidentTypes}
                    />
                  </Col>
                </Row>
                <Row>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="location"
                      label="Location"
                      options={locations}
                    />
                  </Col>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="shift"
                      label="shift"
                      options={shifts}
                    />
                  </Col>
                </Row>
                <Row>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="peopleInvolved"
                      label="People Involved"
                      options={peoples}
                    />
                  </Col>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="equipment"
                      label="Equipment"
                      options={equipmenties}
                    />
                  </Col>
                </Row>
                <Row>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="responsible"
                      label="Responsible"
                      options={responsiblies}
                    />
                  </Col>
                  <Col>
                    <SelectField
                      isDisabled={true}
                      name="status"
                      label="Status"
                      options={status}
                    />
                  </Col>
                </Row>
                <Row>
                  <Col>
                    {/* <UploadFileField
                      name="image"
                      file="file"
                      label="Document"
                      type="file"
                      setFile={this.handleFile}
                    /> */}
                    {snapshot.image && (
                      <a href={fileImage} download>
                        <img width="400" height="400" src={fileImage} alt="" />
                      </a>
                    )}
                  </Col>
                </Row>
                <Row>
                  <Col>
                    <TextAreaField
                      name="description"
                      label="Description"
                      rows={5}
                    />
                  </Col>
                </Row>
              </Card.Body>
            </>
          )}
        </Formik>
      </Modal.Body>
      <Modal.Footer>
        <Button onClick={setClose} className="btn-secondary">
          Close
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default SnapshotModal;

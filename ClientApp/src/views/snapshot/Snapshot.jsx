import React, { Component } from "react";
import { Formik } from "formik";
import * as Yup from "yup";

import { Card, Row, Col } from "react-bootstrap";
import {
  SelectField,
  SubmitBtn,
  UploadFileField,
  TextAreaField,
} from "../../components/Form";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import { toast } from "react-toastify";
import jwtDecode from "jwt-decode";

class Snapshot extends Component {
  state = {
    snapshot: {
      id: 0,
      category: "",
      incidentType: "",
      location: "",
      shift: "",
      peopleInvolved: "",
      equipment: "",
      responsible: "",
      status: "",
      description: "",
    },
    file: "",
    shifts: [
      { value: "7:00 - 11:00 am", label: "7:00 - 11:00 am" },
      { value: "12:00 - 4:00 pm", label: "12:00 - 4:00 pm" },
      { value: "5:00 - 7:00 pm", label: "5:00 - 7:00 pm" },
      { value: "7:00 - 11:00 pm", label: "7:00 - 11:00 pm" },
      { value: "12:00 - 4:00 am", label: "12:00 - 4:00 am" },
      { value: "5:00 - 7:00 am", label: "5:00 - 7:00 am" },
    ],
    categories: [
      { label: "Safety", value: "safety" },
      { label: "Environment", value: "environment" },
      { label: "Security", value: "security" },
    ],
    incidentTypes: [
      { label: "Not wearing ppe", value: "not wearing ppe" },
      { label: "Driving high speed", value: "driving high speed" },
      {
        label: "Working/Standing under suspension",
        value: "working/Standing under suspension",
      },
    ],
    locations: [
      { label: "Main Yard", value: "main yard" },
      { label: "Queyside", value: "queyside" },
      { label: "Gate1", value: "gate1" },
      { label: "Gate2", value: "gate2" },
      { label: "Gate3", value: "gate3" },
      { label: "Gate4", value: "gate4" },
      { label: "Gate-pregate", value: "gate-pregate" },
      { label: "Gate-In", value: "gate-in" },
      { label: "Gate-Out", value: "gate-out" },
    ],
    peoples: [
      { label: "Third part labor", value: "third part labor" },
      { label: "Employee", value: "employee" },
      {
        label: "Employee with third part labor",
        value: "employee with third part labor",
      },
    ],
    equipmenties: [
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
    ],
    responsiblies: [
      { label: "Operarion", value: "operations" },
      { label: "Technical", value: "technical" },
      { label: "Safety", value: "safety" },
      { label: "IT", value: "it" },
      { label: "Finance", value: "finance" },
      { label: "HR", value: "hr" },
      { label: "Security", value: "security" },
      { label: "Clinical", value: "clinical" },
      { label: "Others", value: "others" },
    ],
    status: [
      { label: "Open", value: "open" },
      { label: "Close", value: "close" },
    ],
  };

  schema = Yup.object({
    id: Yup.number().label("Id"),
    category: Yup.string().required().label("Category"),
    incidentType: Yup.string().required().label("Incident Type"),
    location: Yup.string().required().label("Location"),
    shift: Yup.string().required().label("Shift"),
    peopleInvolved: Yup.string().required().label("People Involved"),
    equipment: Yup.string().required().label("Equipment"),
    responsible: Yup.string().required().label("Responsible"),
    status: Yup.string().required().label("Status"),
    description: Yup.string().label("Description"),
  });

  render() {
    const {
      snapshot,
      file,
      shifts,
      categories,
      incidentTypes,
      locations,
      peoples,
      equipmenties,
      responsiblies,
      status,
    } = this.state;
    const fileImage = URL.createObjectURL(
      new Blob([this.handleStringToArray(file)], { type: "image/png" })
    );

    return (
      <>
        <Card>
          <Card.Header>
            <Card.Title>
              {snapshot.id === 0 ? "New Snapshot" : "Update Snapshot"}
            </Card.Title>
          </Card.Header>
          <Formik
            initialValues={snapshot}
            enableReinitialize={true}
            validationSchema={this.schema}
            onSubmit={(snapshot, { resetForm }) => {
              resetForm();
              this.setState({ snapshot });
              this.handleSubmit(snapshot);
            }}
          >
            {() => (
              <>
                <Card.Body>
                  <Row>
                    <Col>
                      <SelectField
                        name="category"
                        label="Category"
                        options={categories}
                        required
                      />
                    </Col>
                    <Col>
                      <SelectField
                        name="incidentType"
                        label="Incident Type"
                        options={incidentTypes}
                        required
                      />
                    </Col>
                  </Row>
                  <Row>
                    <Col>
                      <SelectField
                        name="location"
                        label="Location"
                        options={locations}
                        required
                      />
                    </Col>
                    <Col>
                      <SelectField
                        name="shift"
                        label="shift"
                        options={shifts}
                        required
                      />
                    </Col>
                  </Row>
                  <Row>
                    <Col>
                      <SelectField
                        name="peopleInvolved"
                        label="People Involved"
                        options={peoples}
                        required
                      />
                    </Col>
                    <Col>
                      <SelectField
                        name="equipment"
                        label="Equipment"
                        options={equipmenties}
                        required
                      />
                    </Col>
                  </Row>
                  <Row>
                    <Col>
                      <SelectField
                        name="responsible"
                        label="Responsible"
                        options={responsiblies}
                        required
                      />
                    </Col>
                    <Col>
                      <SelectField
                        name="status"
                        label="Status"
                        options={status}
                        required
                      />
                    </Col>
                  </Row>
                  <Row>
                    <Col>
                      <UploadFileField
                        name="image"
                        file="file"
                        label="Document"
                        type="file"
                        setFile={this.handleFile}
                      />
                      {file && (
                        <a href={fileImage} download>
                          <img
                            width="400"
                            height="400"
                            src={fileImage}
                            alt=""
                          />
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
                <Card.Footer className="text-center">
                  <SubmitBtn />
                </Card.Footer>
              </>
            )}
          </Formik>
        </Card>
      </>
    );
  }

  handleFile = (file) => {
    this.setState({ file });
  };
  handleStringToArray = (str = "") => {
    const array = str.split(",");
    const buffer = [];

    for (let index = 0; index < array.length; index++) {
      buffer[index] = array[index];
    }

    const data = new Uint8Array(buffer);

    return data;
  };
  handleSubmit = () => {
    const { snapshot, file } = this.state;
    const auth = { Authorization: `bearer ${localStorage["token"]}` };
    const user = jwtDecode(localStorage["token"]);
    const data = { ...snapshot, image: file, date: new Date() };

    this.setState({
      snapshot: {
        id: 0,
        category: "",
        incidentType: "",
        location: "",
        shift: "",
        peopleInvolved: "",
        equipment: "",
        responsible: "",
        status: "",
        description: "",
      },
      file: "",
    });

    Services.post(Config.apiUrl + "/SnapShot", data, { headers: auth })
      .then(() => {
        toast.success("Successful Registred.");
      })
      .catch((error) => {
        console.log(error);

        if (error.response && error.response.data) {
          toast.error(error.response.data);
        } else {
          toast.error("Something went wrong");
        }
      });
  };
}

export default Snapshot;

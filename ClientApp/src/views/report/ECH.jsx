import React, { Component } from "react";
import { Card } from "react-bootstrap";
import Fontawesome from "react-fontawesome";
import { MDBDataTableV5 } from "mdbreact";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import ReactToPrint from "react-to-print";
import NewModal from "./NewModal";

class ECH extends Component {
  state = {
    tableHeaders: [
      { label: "Name", field: "name" },
      { label: "Date", field: "date" },
      { label: "", field: "edit" },
    ],
    services: [],
    categories: [],
    rooms: [],
    filter: {
      name: "All",
      date: "",
    },
    show: false,
    items: [],
    allItems: [],
    echs: [],
    ech: {},
    echCheck: [
      { value: "hydraulicControls", label: "Hydraulic controls" },
      { value: "steering", label: "Steering" },
      {
        value: "checkWindowsAreCleanAndNotDamaged",
        label: "Windows are clean and not damaged",
      },
      {
        value: "handBreakAndWindscreenWipers",
        label: "Hand-break & window screen wipers",
      },
      { value: "vMT", label: "VMT" },
      { value: "radioCommunication", label: "Radio Communication" },
      { value: "lights", label: "Lights" },
      { value: "speedLimitOperating", label: "Speed limit operating" },
      { value: "aC", label: "AC" },
      { value: "hornsAndAlarms", label: "Horns/ Alarms" },
      { value: "seatBelts", label: "Seat belts" },
      { value: "brakes", label: "Brakes" },
      {
        value: "noTyreDamageOrInsuficientInflation",
        label: "No Tyre damage or insuficient inflation",
      },
      { value: "noWheelsLooseNuts", label: "No Wheels- loose nuts" },
      {
        value: "noAccidentDamageOrFrameIncludingAttachements",
        label: "No accident damage or frame including attachements ",
      },
      {
        value: "noExcessiveFluidLeaksEspeciallyMnderMachine",
        label: "No excessive fluid leaks especially under machine",
      },
      { value: "sPREADEROilLeakingSPR", label: "SPREADER: oil leaking, SPR" },
      { value: "floodLightsAreWorking", label: "Flood lights are working " },
      { value: "tailLightsAreWorking", label: "Tail lights are working" },
      { value: "mirrors", label: "Mirrors" },
      { value: "fireExtingisher", label: "Fire extingisher" },
      { value: "deiselLevel", label: "Deisel level", string: true },
      { value: "hMR", label: "HMR", string: true },
    ],
    data: [],
  };

  render() {
    const { tableHeaders, echs, show, data } = this.state;

    return (
      <>
        <NewModal
          show={show}
          title="ech"
          data={data}
          setClose={this.handleClose}
        />
        <Card>
          <Card.Header>
            <Card.Title>
              ECH Report
              <ReactToPrint
                trigger={() => (
                  <button
                    type="button"
                    className="btn d-print-none float-right"
                  >
                    <Fontawesome
                      className="fas fa-print"
                      name="print"
                      style={{ fontSize: 25 }}
                    />
                  </button>
                )}
                content={() => {
                  return this.componentRef;
                }}
              />
              <div className="d-none">
                {/* <PrinTible
                  data={echs.map((r) => ({
                    id: r.id,
                    category: r.category,
                    date: new Date(r.Date).toDateString(),
                  }))}
                  theaders={tableHeaders
                    .filter((t) => t.label !== "")
                    .map((h) => h.label)}
                  title="Rental Report"
                  ref={(el) => (this.componentRef = el)}
                /> */}
              </div>
            </Card.Title>
          </Card.Header>
          <Card.Body>
            <MDBDataTableV5
              hover
              entriesOptions={[10, 25, 50, 100]}
              entries={10}
              pagesAmount={10}
              data={{
                columns: tableHeaders,
                rows: echs.map((ech) => {
                  ech.edit = (
                    <>
                      <a
                        className="ml-4"
                        onClick={() => this.handleShowModal(ech)}
                      >
                        <Fontawesome
                          className="fas fa-eye"
                          style={{ fontSize: 17 }}
                          name="edit"
                        />
                      </a>
                    </>
                  );
                  ech.date = new Date(ech.date).toDateString();
                  ech.name = ech.ech.name;

                  return ech;
                }),
              }}
              pagingTop
              searchBottom={false}
            />
          </Card.Body>
        </Card>
      </>
    );
  }

  handleClose = () => {
    this.setState({ show: false });
  };

  handleShowModal(ech) {
    const { echCheck } = this.state;
    const data = [];

    for (let f in ech) {
      for (let fk of echCheck) {
        if (fk.value.toLocaleLowerCase() === f.toLocaleLowerCase()) {
          if (fk.string) {
            fk.input = ech[f];
            data.push(fk);
          } else {
            fk.isTrue = ech[f];
            data.push(fk);
          }
        }
      }
    }

    this.setState({ ech, show: true, data });
  }
  componentDidMount() {
    this.setState({ loading: true });
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/echcheck", { headers: auth }).then(
      ({ data }) => {
        this.setState({
          echs: data,
        });
      }
    );
  }
}

export default ECH;

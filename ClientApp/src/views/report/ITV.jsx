import React, { Component } from "react";
import { Card } from "react-bootstrap";
import Fontawesome from "react-fontawesome";
import { MDBDataTableV5 } from "mdbreact";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import ReactToPrint from "react-to-print";
import NewModal from "./NewModal";

class ITV extends Component {
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
    itvs: [],
    itv: {},
    itvCheck: [
      { value: "hydraulicControls", label: "Hydraulic controls" },
      { value: "steering", label: "Steering" },
      {
        value: "checkWindowsAreCleanAndNotDamaged",
        label: "Check windows are clean and not damaged",
      },
      {
        value: "handBreakAndWindscreenWipers",
        label: "Hand-break &windscreen wipers",
      },
      { value: "vMT", label: "VMT" },
      { value: "radioCommunication", label: "Radio Communication" },
      {
        value: "ensure5thwheelAtCorrectHeight",
        label: "Ensure 5th wheel at correct height",
      },
      { value: "lights", label: "Lights" },
      { value: "speedLimitOperating", label: "Speed limit operating" },
      { value: "aC", label: "AC" },
      { value: "hornsAndAlarms", label: "Horns/ Alarms" },
      { value: "seatBelts", label: "Seat belts" },
      { value: "brakes", label: "Brakes" },
      {
        value: "noTyreDamageOrInsuficientInflation",
        label: "No tyre damage or insuficient inflation",
      },
      { value: "noWheelsLooseNuts", label: "No Wheels- loose nuts" },
      {
        value: "noAccidentDamageOrFrameIncludingAttachements",
        label: "No accident damage or frame including attachements",
      },
      {
        value: "noExcessiveFluidLeaksEspeciallyMnderMachine",
        label: "No excessive fluid leaks especially under machine",
      },
      { value: "floodLightsAreWorking", label: "Flood lights are working" },
      { value: "tailLightsAreWorking", label: "Tail lights are working" },
      { value: "mirrors", label: "Mirrors" },
      {
        value: "turntableLockingBarInFullyLatchedPosition",
        label: "Turntable locking bar in fully latched position",
      },
      {
        value: "trailerSuzieHosesAndCableSecure",
        label: "Trailer Suzie hoses and cable secure",
      },
      {
        value: "trailerLegsLiftedToFullHeight",
        label: "Trailer legs lifted to full height",
      },
      { value: "fireExtingisher", label: "Fire extingisher" },
      { value: "deiselLevel", label: "Deisel level", string: true },
      { value: "hMR", label: "HMR", string: true },
    ],
    data: [],
  };

  render() {
    const { tableHeaders, itvs, show, data } = this.state;

    return (
      <>
        <NewModal
          show={show}
          title="ITV"
          data={data}
          setClose={this.handleClose}
        />
        <Card>
          <Card.Header>
            <Card.Title>
              ITV Report
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
                  data={itvs.map((r) => ({
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
                rows: itvs.map((fork) => {
                  fork.edit = (
                    <>
                      <a
                        className="ml-4"
                        onClick={() => this.handleShowModal(fork)}
                      >
                        <Fontawesome
                          className="fas fa-eye"
                          style={{ fontSize: 17 }}
                          name="edit"
                        />
                      </a>
                    </>
                  );
                  fork.date = new Date(fork.date).toDateString();
                  fork.name = fork.itv.name;

                  return fork;
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

  handleShowModal(fork) {
    const { itvCheck } = this.state;
    const data = [];

    for (let f in fork) {
      for (let fk of itvCheck) {
        if (fk.value.toLocaleLowerCase() === f.toLocaleLowerCase()) {
          if (fk.string) {
            fk.input = fork[f];
            data.push(fk);
          } else {
            fk.isTrue = fork[f];
            data.push(fk);
          }
        }
      }
    }

    this.setState({ fork, show: true, data });
  }
  componentDidMount() {
    this.setState({ loading: true });
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/itvcheck", { headers: auth }).then(
      ({ data }) => {
        this.setState({
          itvs: data,
        });
      }
    );
  }
}

export default ITV;

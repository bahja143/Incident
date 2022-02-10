import React, { Component } from "react";
import { Card } from "react-bootstrap";
import Fontawesome from "react-fontawesome";
import { MDBDataTableV5 } from "mdbreact";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import ReactToPrint from "react-to-print";
import NewModal from "./NewModal";

class RS extends Component {
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
    rss: [],
    rs: {},
    rsCheck: [
      {
        value: "noTyreDamageOrInsuficientInflation",
        label: "Hydraulic controls",
      },
      { value: "noWheelsLooseNuts", label: "Steering" },
      {
        value: "sPREADEROilLeakingFlipperDamageFlipperMissingSPR",
        label: "Hand Break",
      },
      {
        value: "noAccidentDamageOrFrameIncludingAttachements",
        label: "Lights",
      },
      { value: "visualCheckOfBeltsBeforeOperation", label: "Horns/ Alarms" },
      {
        value: "excessiveFluidLeaksEspeciallyUnderMachine",
        label: "Seat belts",
      },
      {
        value: "floodLightsAreWorking",
        label: "No tyre damage or insuficient inflation",
      },
      { value: "tailLightsAreWorking", label: "No Wheels- loose nuts" },
      {
        value: "mirrors",
        label: "No accident damage or frame including attachements",
      },
      {
        value: "fireExtingisher",
        label: "No excessive fluid leaks especially under machine",
      },
      { value: "dieselLevel", label: "Flood lights are working", string: true },
      { value: "hMR", label: "Tail lights are working", string: true },
    ],
    data: [],
  };

  render() {
    const { tableHeaders, rss, show, data } = this.state;

    return (
      <>
        <NewModal
          show={show}
          title="RS"
          data={data}
          setClose={this.handleClose}
        />
        <Card>
          <Card.Header>
            <Card.Title>
              RS Report
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
                  data={rss.map((r) => ({
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
                rows: rss.map((rs) => {
                  rs.edit = (
                    <>
                      <a
                        className="ml-4"
                        onClick={() => this.handleShowModal(rs)}
                      >
                        <Fontawesome
                          className="fas fa-eye"
                          style={{ fontSize: 17 }}
                          name="edit"
                        />
                      </a>
                    </>
                  );
                  rs.date = new Date(rs.date).toDateString();
                  rs.name = rs.rs.name;

                  return rs;
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

  handleShowModal(rs) {
    const { rsCheck } = this.state;
    const data = [];

    for (let f in rs) {
      for (let fk of rsCheck) {
        if (fk.value.toLocaleLowerCase() === f.toLocaleLowerCase()) {
          if (fk.string) {
            fk.input = rs[f];
            data.push(fk);
          } else {
            fk.isTrue = rs[f];
            data.push(fk);
          }
        }
      }
    }

    this.setState({ rs, show: true, data });
  }
  componentDidMount() {
    this.setState({ loading: true });
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/rscheck", { headers: auth }).then(
      ({ data }) => {
        this.setState({
          rss: data,
        });
      }
    );
  }
}

export default RS;

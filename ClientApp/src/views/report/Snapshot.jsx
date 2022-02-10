import React, { Component } from "react";
import { Card } from "react-bootstrap";
import Fontawesome from "react-fontawesome";
import { MDBDataTableV5 } from "mdbreact";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import ReactToPrint from "react-to-print";
import SnapshotModal from "./SnapshotModal";

class Snapshot extends Component {
  state = {
    tableHeaders: [
      { label: "Category", field: "category" },
      { label: "Incident Type", field: "incidentType" },
      { label: "Locatiobn", field: "location" },
      { label: "Shift", field: "shift" },
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
    snapshots: [],
    snapshot: {},
  };

  render() {
    const { tableHeaders, snapshots, show, snapshot } = this.state;

    return (
      <>
        <SnapshotModal
          show={show}
          snapshot={snapshot}
          title="Snapshot"
          setClose={this.handleClose}
        />
        <Card>
          <Card.Header>
            <Card.Title>
              Snapshot Report
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
                  data={snapshots.map((r) => ({
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
                rows: snapshots.map((snapshot) => {
                  snapshot.edit = (
                    <>
                      <a
                        className="ml-4"
                        onClick={() => this.handleShowModal(snapshot)}
                      >
                        <Fontawesome
                          className="fas fa-eye"
                          style={{ fontSize: 17 }}
                          name="edit"
                        />
                      </a>
                    </>
                  );
                  snapshot.date = new Date(snapshot.date).toDateString();

                  return snapshot;
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

  handleShowModal(snapshot) {
    this.setState({ snapshot, show: true });
  }
  componentDidMount() {
    this.setState({ loading: true });
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/snapshot", { headers: auth }).then(
      ({ data }) => {
        this.setState({
          snapshots: data,
        });
      }
    );
  }
}

export default Snapshot;

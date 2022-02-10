import React, { Component } from "react";
import { Card } from "react-bootstrap";
import Fontawesome from "react-fontawesome";
import { MDBDataTableV5 } from "mdbreact";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import ReactToPrint from "react-to-print";
import NewModal from "./NewModal";

class mhc extends Component {
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
    mhcs: [],
    mhc: {},
    mhcCheck: [
      {
        value: "engineFluidLevelCorrect",
        label: "Engine fluid level correct (check dip stick or sight lass)",
      },
      {
        value: "hydraulicFluidLevelCorrect",
        label: "Hydraulic fluid level correct (check dip stick or sight glass)",
      },
      {
        value: "hydraulicSystemExhibitsNoApparentWeepingOrLeaks",
        label: "hydraulic system exhibits no apparent weeping or leaks",
      },
      {
        value: "airSystemexhibitsNoAudibleLeaks",
        label: "Air system exhibits no audible leaks",
      },
      {
        value: "tyrePressureAccetableAndTireNotDamaged",
        label: "Tyre pressure accetable and tire not damaged",
      },
      {
        value:
          "telescopingBoomExhibitsNoDamageToRuctureWearPadsBoomStopsOrCylinder",
        label:
          "telescoping boom exhibits no damage to ructure, wear pads, boom stops, or cylinder",
      },
      {
        value: "wireRopeFreeOfDirtExcessLubekinksAndWiresAndSooledCorrectl",
        label:
          "Wire rope free of dirt, excess lube, kinks, and wires nd s ooled correctl",
      },
      { value: "reevingCorrect", label: "Reeving correct" },
      {
        value: "wedgeAocketsAndWireRopeClipsNotDistortedCrackedOrMissing",
        label:
          "Wedge sockets and wire rope clips not distorted, cracked, or missing",
      },
      {
        value: "allAndHookAreFreeToSwivelAndRotate",
        label: "All and hook are free to swivel and rotate",
      },
      {
        value: "outriggerFloatsSecuredWithPadIn",
        label: "Outrigger float(s) secured with pad in",
      },
      { value: "cab", label: "Cab" },
      {
        value: "handrailsInPlaceAndNotDamaged",
        label: "Handrails in place and not damaged",
      },
      {
        value: "operatorManualInVehicle",
        label: "Operator's manual in vehicle",
      },
      {
        value: "loadChartLegibleAndVisibleToOperator",
        label: "Load chart legible and visible to operator",
      },
      {
        value: "handSignalChartVisibleToWorkers",
        label: "Hand signal chart visible to workers",
      },
      {
        value: "chargedFireExtinguisherInplace",
        label: "Charged fire extinguisher in place",
      },
      {
        value: "cabGlassNotCrackedAndWipersAreFunctional",
        label: "Cab glass not cracked, and wipers are functional",
      },
      {
        value: "loadMomentIndicatorOperational",
        label: "Load moment indicator operational",
      },
      {
        value: "drumRotationIndicatorFunctioning",
        label: "Drum rotation indicator functioning",
      },
      {
        value: "boomLengthIndicatorFunctioning",
        label: "Boom length indicator functioning",
      },
      {
        value: "boomAngleIndicatorFunctioning",
        label: "Boom angle indicator functioning",
      },
      {
        value: "engineHydraulicAirElectricalOilPressureTemperatureAandFuel",
        label:
          "Engine: hydraulic, air, electrical, oil pressure, temperature, and fuel",
      },
      {
        value: "correctCounterweightForTheLoad",
        label: "Correct counterweight for the load",
      },
      {
        value: "mainHoistControlFunctioning",
        label: "Main hoist control functioning",
      },
      {
        value: "antiTwoBlockInLaceAndFunctioning",
        label: "Anti-two block in lace and functioning",
      },
      { value: "swingBrake", label: "Swing brake" },
      {
        value: "auxiliaryHoistControlFunctioning",
        label: "Auxiliary hoist control functioning",
      },
      { value: "dieselFuelLeakage", label: "Diesel Fuel Leakage" },
      { value: "engineHourMeter", label: "Engine Hour Meter", string: true },
      { value: "fuelLevelReading", label: "Fuel Level Reading", string: true },
    ],
    data: [],
  };

  render() {
    const { tableHeaders, mhcs, show, data } = this.state;

    return (
      <>
        <NewModal
          show={show}
          title="MHC"
          data={data}
          setClose={this.handleClose}
        />
        <Card>
          <Card.Header>
            <Card.Title>
              MHC Report
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
                  data={mhcs.map((r) => ({
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
                rows: mhcs.map((mhc) => {
                  mhc.edit = (
                    <>
                      <a
                        className="ml-4"
                        onClick={() => this.handleShowModal(mhc)}
                      >
                        <Fontawesome
                          className="fas fa-eye"
                          style={{ fontSize: 17 }}
                          name="edit"
                        />
                      </a>
                    </>
                  );
                  mhc.date = new Date(mhc.date).toDateString();
                  mhc.name = mhc.mhc.name;

                  return mhc;
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

  handleShowModal(mhc) {
    const { mhcCheck } = this.state;
    const data = [];

    for (let f in mhc) {
      for (let fk of mhcCheck) {
        if (fk.value.toLocaleLowerCase() === f.toLocaleLowerCase()) {
          if (fk.string) {
            fk.input = mhc[f];
            data.push(fk);
          } else {
            fk.isTrue = mhc[f];
            data.push(fk);
          }
        }
      }
    }

    this.setState({ mhc, show: true, data });
  }
  componentDidMount() {
    this.setState({ loading: true });
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/mhccheck", { headers: auth }).then(
      ({ data }) => {
        this.setState({
          mhcs: data,
        });
      }
    );
  }
}

export default mhc;

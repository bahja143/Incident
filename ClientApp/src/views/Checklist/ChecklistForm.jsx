import React, { Component } from "react";
import { Formik } from "formik";
import * as Yup from "yup";

import { Card, Row, Col } from "react-bootstrap";
import { MDBDataTableV5 } from "mdbreact";
import { SelectField, SubmitBtn } from "../../components/Form";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import { toast } from "react-toastify";
import Select from "react-select";
import { FormLabel } from "react-bootstrap";
import JwtDecode from "jwt-decode";
import jwtDecode from "jwt-decode";

class ChecklistForm extends Component {
  state = {
    chechlist: {
      id: 0,
      equibmentTypeId: "",
      shift: "",
    },
    tableHeaders: [
      { label: "Name", field: "label" },
      { label: "", field: "edit" },
    ],
    equibments: [
      { value: 1, label: "FORKLIFT" },
      { value: 2, label: "ITV" },
      { value: 3, label: "MHC" },
      { value: 4, label: "MC" },
      { value: 5, label: "RTG" },
      { value: 6, label: "ECH" },
      { value: 7, label: "RS" },
    ],
    shifts: [
      { value: "A", label: "A" },
      { value: "B", label: "B" },
      { value: "C", label: "C" },
      { value: "D", label: "D" },
      { value: "General shift", label: "General shift" },
    ],
    forklifts: [],
    ITVes: [],
    MHCes: [],
    MCes: [],
    RTGes: [],
    ECHes: [],
    RSes: [],
    equibmentTypes: [],
    checkLists: [],
    forkliftCheck: [
      { value: "hydraulicControls", label: "Hydraulic controls" },
      { value: "steering", label: "Steering" },
      { value: "handBreak", label: "Hand Break" },
      { value: "lights", label: "Lights" },
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
        value: "noExcessiveFluidLeaksEspeciallyUnderMachine",
        label: "No excessive fluid leaks especially under machine",
      },
      { value: "floodLightsAreWorking", label: "Flood lights are working" },
      { value: "tailLightsAreWorking", label: "Tail lights are working" },
      { value: "mirrors", label: "Mirrors" },
      {
        value: "rotatingAmbersLightsAreWorking",
        label: "Rotating ambers lights are working",
      },
      { value: "fireExtingisher", label: "Fire extingisher" },
      { value: "deiselLevel", label: "Deisel level", string: true },
      { value: "hMR", label: "HMR", string: true },
    ],
    ITVCheck: [
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
    MHCCheck: [
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
    MCCheck: [
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
    RTGCheck: [
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
    ECHCheck: [
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
    RSCheck: [
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
    equibmentId: 0,
  };

  schema = Yup.object({
    id: Yup.number().label("Id"),
    shift: Yup.string().required().label("Shift"),
    equibmentTypeId: Yup.number().required().label("Equibment Type"),
  });

  render() {
    const {
      chechlist,
      equibments,
      shifts,
      tableHeaders,
      checkLists,
      equibmentTypes,
    } = this.state;

    return (
      <>
        <Card>
          <Card.Header>
            <Card.Title>
              {chechlist.id === 0 ? "New checklist" : "Update checklist"}
            </Card.Title>
          </Card.Header>
          <Formik
            initialValues={chechlist}
            enableReinitialize={true}
            validationSchema={this.schema}
            onSubmit={(chechlist, { resetForm }) => {
              resetForm();
              this.setState({ chechlist });
              this.handleSubmit(chechlist);
            }}
          >
            {({ values }) => (
              <>
                <Card.Body>
                  <Row>
                    <Col>
                      <FormLabel>
                        Equibment <span className="text-danger">*</span>
                      </FormLabel>
                      <Select
                        name="equibmentId"
                        onChange={(e) => this.handleEquinment(e.value)}
                        options={equibments}
                        required
                      />
                    </Col>
                    <Col>
                      <SelectField
                        name="shift"
                        label="Shift"
                        options={shifts}
                        required
                        disabled={true}
                      />
                    </Col>
                  </Row>
                  <Row>
                    <Col>
                      <SelectField
                        name="equibmentTypeId"
                        label="Equibment Type"
                        options={equibmentTypes.map((fork) => ({
                          label: fork.name,
                          value: fork.id,
                        }))}
                        required
                      />
                    </Col>
                  </Row>
                  <MDBDataTableV5
                    hover={false}
                    paging={false}
                    entries={15}
                    pagesAmount={15}
                    data={{
                      columns: tableHeaders,
                      rows: checkLists.map((obj) => {
                        obj.edit = obj.string ? (
                          <input
                            type="text"
                            className="form-control mr-5"
                            onChange={(e) =>
                              this.handlechecklistString({
                                value: obj.value,
                                string: e.target.value,
                              })
                            }
                          />
                        ) : (
                          <input
                            type="checkbox"
                            className="form-control mr-5"
                            onChange={() => this.handleChecklist(obj.value)}
                          />
                        );

                        return obj;
                      }),
                    }}
                    searchTop={false}
                    searchBottom={false}
                  />
                  <Row></Row>
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

  handleEquinment = (id) => {
    const {
      forklifts,
      forkliftCheck,
      ITVes,
      ITVCheck,
      MHCes,
      MHCCheck,
      MCes,
      MCCheck,
      RTGes,
      RTGCheck,
      ECHes,
      ECHCheck,
      RSes,
      RSCheck,
    } = this.state;

    this.setState({ equibmentId: id });

    if (id === 1) {
      this.setState({ equibmentTypes: forklifts, checkLists: forkliftCheck });
    } else if (id === 2) {
      this.setState({ equibmentTypes: ITVes, checkLists: ITVCheck });
    } else if (id === 3) {
      this.setState({ equibmentTypes: MHCes, checkLists: MHCCheck });
    } else if (id === 4) {
      this.setState({ equibmentTypes: MCes, checkLists: MCCheck });
    } else if (id === 5) {
      this.setState({ equibmentTypes: RTGes, checkLists: RTGCheck });
    } else if (id === 6) {
      this.setState({ equibmentTypes: ECHes, checkLists: ECHCheck });
    } else if (id === 7) {
      this.setState({ equibmentTypes: RSes, checkLists: RSCheck });
    } else {
      return [];
    }
  };
  handleChecklist = (value) => {
    const { checkLists } = this.state;
    const data = checkLists.map((f) => {
      if (f.value === value) {
        f.isTrue = f.isTrue ? false : true;

        return f;
      }

      return f;
    });

    this.setState({ checkLists: data });
  };
  handlechecklistString = (input) => {
    const { checkLists } = this.state;
    const data = checkLists.map((f) => {
      if (f.value === input.value) {
        f.input = input.string;

        return f;
      }

      return f;
    });

    this.setState({ checkLists: data });
  };
  componentDidMount() {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/forklift", { headers: auth })
      .then(({ data }) => {
        this.setState({ forklifts: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/itv", { headers: auth })
      .then(({ data }) => {
        this.setState({ ITVes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/mhc", { headers: auth })
      .then(({ data }) => {
        this.setState({ MHCes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/mc", { headers: auth })
      .then(({ data }) => {
        this.setState({ MCes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/rtg", { headers: auth })
      .then(({ data }) => {
        this.setState({ RTGes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/ech", { headers: auth })
      .then(({ data }) => {
        this.setState({ ECHes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });

    Services.get(Config.apiUrl + "/rs", { headers: auth })
      .then(({ data }) => {
        this.setState({ RSes: data });
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });
  }
  handleSubmit = () => {
    const { chechlist, checkLists, equibmentId } = this.state;
    const user = jwtDecode(localStorage["token"]);
    const auth = { Authorization: `bearer ${localStorage["token"]}` };
    const data = {
      id: 0,
      shift: chechlist.shift,
      date: new Date(),
      userId: parseInt(user.id),
    };

    for (let input of checkLists) {
      if (input.string) {
        data[input.value] = input.input;
      } else {
        data[input.value] = input.isTrue ? input.isTrue : false;
      }
    }

    if (equibmentId === 1) {
      data.forkliftId = chechlist.equibmentTypeId;
      Services.post(Config.apiUrl + "/forkliftcheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 2) {
      data.ITVId = chechlist.equibmentTypeId;
      console.log(data);
      Services.post(Config.apiUrl + "/itvcheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 3) {
      data.MHCId = chechlist.equibmentTypeId;
      Services.post(Config.apiUrl + "/mhccheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 4) {
      data.MCId = chechlist.equibmentTypeId;
      Services.post(Config.apiUrl + "/MCcheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 5) {
      data.RTGId = chechlist.equibmentTypeId;
      console.log(data);
      Services.post(Config.apiUrl + "/rtgcheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 6) {
      data.ECHId = chechlist.equibmentTypeId;
      Services.post(Config.apiUrl + "/echcheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else if (equibmentId === 7) {
      data.RSId = chechlist.equibmentTypeId;
      Services.post(Config.apiUrl + "/rscheck", data, { headers: auth })
        .then(() => {
          toast.success("Successful Registred.");
          this.setState({
            chechlist: { id: 0, equibmentTypeId: "", shift: "" },
            checkLists: [],
          });
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    }
  };
}

export default ChecklistForm;

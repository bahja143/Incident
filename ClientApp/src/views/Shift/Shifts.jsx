import React, { useState, useEffect } from "react";
import { Card, Button } from "react-bootstrap";
import * as Yup from "yup";

import FontAwesome from "react-fontawesome";
import NewshiftModal from "./NewShiftModal";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import { toast } from "react-toastify";
import { MDBDataTableV5 } from "mdbreact";
import Fontawesome from "react-fontawesome";

const schema = Yup.object({
  id: Yup.number(),
  time: Yup.date().required().label("Time"),
});

const Shifts = () => {
  const [show, setShow] = useState(false);
  const [shifts, setShifts] = useState([]);
  const [shift, setShift] = useState({
    id: 0,
    date: "",
  });
  const [tableHeaders] = useState([
    { label: "Time", field: "exactTime" },
    { label: "", field: "edit" },
  ]);

  useEffect(() => {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/shifts", { headers: auth })
      .then(({ data }) => {
        setShifts(data);
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });
  }, [shift]);

  const handleSubmit = (shift) => {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    if (shift.id === 0) {
      Services.post(Config.apiUrl + "/shifts", shift, { headers: auth })
        .then(({ data }) => {
          toast.success("Successful Registred.");
          setShow(false);
          setShifts([data, ...shifts]);
        })
        .catch((error) => {
          console.log(error);

          if (error.response && error.response.data) {
            toast.error(error.response.data);
          } else {
            toast.error("Something went wrong");
          }
        });
    } else {
      Services.put(Config.apiUrl + "/shifts/" + shift.id, shift, {
        headers: auth,
      })
        .then(({ data }) => {
          toast.info("Successful Updates.");
          console.log(data);
          setShow(false);
          setShifts([
            data,
            ...shifts.filter((c) => c.id !== shift.id),
          ]);
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
  const handleEdit = (custom) => {
    const cust = { ...custom };
    delete cust.edit;
    setShift(cust);
    setShow(true);
  };

  return (
    <>
      <NewshiftModal
        show={show}
        setShow={setShow}
        shift={shift}
        schema={schema}
        handleSubmit={handleSubmit}
      />
      <Card>
        <Card.Header>
          <Button
            className="float-right"
            onClick={() => {
              setShow(true);
              setShift({
                id: 0,
                name: "",
                tellphone: "",
                address: "",
              });
            }}
          >
            <FontAwesome name="fas fa-plus-circle" /> New shift
          </Button>
          <Card.Title>shifts</Card.Title>
        </Card.Header>
        <Card.Body>
          <MDBDataTableV5
            hover
            entriesOptions={[10, 25, 50, 100, 250, 500, 1000]}
            entries={10}
            pagesAmount={10}
            data={{
              columns: tableHeaders,
              rows: shifts.map((custom) => {
                custom.edit = (
                  <Button
                    onClick={() => handleEdit(custom)}
                    className="btn-light btn-sm"
                  >
                    <Fontawesome
                      className="fas fa-edit text-primary"
                      style={{ fontSize: 17 }}
                      name="edit"
                    />
                  </Button>
                );
                let date = new Date(custom.time );
                custom.exactTime = `${date.getHours()}: ${date.getMinutes()}: ${date.getSeconds()}`
                return custom;
              }),
            }}
            pagingTop
            searchTop
            searchBottom={false}
            fullPagination
          />
        </Card.Body>
      </Card>
    </>
  );
};

export default Shifts;

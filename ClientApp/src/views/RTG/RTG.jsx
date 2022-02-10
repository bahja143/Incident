import React, { useState, useEffect } from "react";
import { Card, Button } from "react-bootstrap";
import * as Yup from "yup";

import FontAwesome from "react-fontawesome";
import NewRTGModal from "./NewRTGModal";
import Config from "../../config/config.json";
import Services from "../../services/HttpServices";
import { toast } from "react-toastify";
import { MDBDataTableV5 } from "mdbreact";
import Fontawesome from "react-fontawesome";

const schema = Yup.object({
  id: Yup.number(),
  name: Yup.string().min(3).max(50).required().label("Name"),
  date: Yup.date().label("Date"),
  description: Yup.string().label("Description"),
});

const RTGES = () => {
  const [show, setShow] = useState(false);
  const [RTGES, setRTGES] = useState([]);
  const [RTG, setRTG] = useState({
    id: 0,
    name: "",
    date: "",
    description: "",
  });
  const [tableHeaders] = useState([
    { label: "Name", field: "name" },
    { label: "Date", field: "date" },
    { label: "Description", field: "description" },
    { label: "", field: "edit" },
  ]);

  useEffect(() => {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/RTG", { headers: auth })
      .then(({ data }) => {
        setRTGES(data);
      })
      .catch((error) => {
        console.log(error);

        toast.error("Something went wrong");
      });
  }, [RTG]);

  const handleSubmit = (RTG) => {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };
    RTG.date = new Date();
    

    if (RTG.id === 0) {
      Services.post(Config.apiUrl + "/RTG", RTG, { headers: auth })
        .then(({ data }) => {
          toast.success("Successful Registred.");
          setShow(false);
          setRTGES([data, ...RTGES]);
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
      Services.put(Config.apiUrl + "/RTG/" + RTG.id, RTG, {
        headers: auth,
      })
        .then(({ data }) => {
          toast.info("Successful Updates.");
          setShow(false);
          setRTGES([
            data,
            ...RTGES.filter((c) => c.id !== RTG.id),
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
    setRTG(cust);
    setShow(true);
  };

  return (
    <>
      <NewRTGModal
        show={show}
        setShow={setShow}
        RTG={RTG}
        schema={schema}
        handleSubmit={handleSubmit}
      />
      <Card>
        <Card.Header>
          <Button
            className="float-right"
            onClick={() => {
              setShow(true);
              setRTG({
                id: 0,
                name: "",
                tellphone: "",
                address: "",
              });
            }}
          >
            <FontAwesome name="fas fa-plus-circle" /> New RTG
          </Button>
          <Card.Title>RTGES</Card.Title>
        </Card.Header>
        <Card.Body>
          <MDBDataTableV5
            hover
            entriesOptions={[10, 25, 50, 100, 250, 500, 1000]}
            entries={10}
            pagesAmount={10}
            data={{
              columns: tableHeaders,
              rows: RTGES.map((custom) => {
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
                custom.date = new Date(custom.date).toDateString();
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

export default RTGES;

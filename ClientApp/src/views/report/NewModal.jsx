import React from "react";

import { Modal, Button } from "react-bootstrap";
import { MDBDataTableV5 } from "mdbreact";

const NewModal = ({ show, setClose, data, title }) => {
  const tableHeaders = [
    { label: "Name", field: "label" },
    { label: "", field: "edit" },
  ];

  return (
    <Modal show={show} size="lg">
      <Modal.Header>
        <Modal.Title>{title}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <MDBDataTableV5
          hover={false}
          paging={false}
          entries={15}
          pagesAmount={15}
          data={{
            columns: tableHeaders,
            rows: data.map((obj) => {
              obj.edit = obj.string ? (
                <input
                  type="text"
                  className="form-control mr-5"
                  value={obj.input}
                  disabled
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
                  checked={obj.isTrue}
                  disabled
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
      </Modal.Body>
      <Modal.Footer>
        <Button onClick={setClose} className="btn-secondary">
          Close
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default NewModal;

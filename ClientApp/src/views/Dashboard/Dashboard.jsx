import React, { useEffect, useState } from "react";
import { Row, Col, Card, Table } from "react-bootstrap";

import Config from "../../config/config.json";
import Services from "../../services/HttpServices";

const Dashboard = () => {
  const [snapshots, setSnapshots] = useState([]);
  const [users, setUsers] = useState([]);
  const [forklifts, setForklifts] = useState([]);
  const [itves, setItves] = useState([]);
  const [mhc, setMHC] = useState([]);
  const [mc, setMC] = useState([]);
  const [rtg, setRTG] = useState([]);
  const [ech, setECH] = useState([]);
  const [rs, setRS] = useState([]);

  useEffect(() => {
    const auth = { Authorization: `bearer ${localStorage["token"]}` };

    Services.get(Config.apiUrl + "/rs", { headers: auth }).then(({ data }) => {
      setRS([
        ...data
          .reverse((a, b) => new Date(a.date) + new Date(b.date))
          .slice(0, 7),
      ]);
    });

    Services.get(Config.apiUrl + "/rtg", { headers: auth }).then(({ data }) => {
      setRTG([
        ...data
          .reverse((a, b) => new Date(a.date) + new Date(b.date))
          .slice(0, 7),
      ]);
    });

    Services.get(Config.apiUrl + "/ech", { headers: auth }).then(({ data }) => {
      setECH([
        ...data
          .reverse((a, b) => new Date(a.date) + new Date(b.date))
          .slice(0, 7),
      ]);
    });

    Services.get(Config.apiUrl + "/mc", { headers: auth }).then(({ data }) => {
      setMC([
        ...data
          .reverse((a, b) => new Date(a.date) + new Date(b.date))
          .slice(0, 7),
      ]);
    });

    Services.get(Config.apiUrl + "/SnapShot", { headers: auth }).then(
      ({ data }) => {
        setSnapshots([
          ...data
            .reverse((a, b) => new Date(a.date) + new Date(b.date))
            .slice(0, 7),
        ]);
      }
    );

    Services.get(Config.apiUrl + "/users", { headers: auth }).then(
      ({ data }) => {
        setUsers([...data]);
      }
    );

    Services.get(Config.apiUrl + "/forklift", { headers: auth }).then(
      ({ data }) => {
        setForklifts([...data]);
      }
    );

    Services.get(Config.apiUrl + "/itv", { headers: auth }).then(({ data }) => {
      setItves([...data]);
    });

    Services.get(Config.apiUrl + "/mhc", { headers: auth }).then(({ data }) => {
      setMHC([...data]);
    });
  }, []);

  return (
    <React.Fragment>
      <Row>
        <Col md={4} sm={6}>
          <Card className="user-card">
            <Card.Body>
              <h5 className="m-b-15">FL</h5>
              <h4 className="f-w-300">{forklifts.length}</h4>
            </Card.Body>
          </Card>
        </Col>
        <Col md={4} sm={6}>
          <Card className="user-card">
            <Card.Body>
              <h5 className="f-w-400 m-b-15">ITV</h5>
              <h4 className="f-w-300">{itves.length}</h4>
            </Card.Body>
          </Card>
        </Col>
        <Col md={4}>
          <Card className="user-card">
            <Card.Body>
              <h5 className="f-w-400 m-b-15">MHC</h5>
              <h4 className="f-w-300">{mhc.length}</h4>
            </Card.Body>
          </Card>
        </Col>
      </Row>
      <Row>
        <Col sm={8}>
          <Card className="user-list">
            <Card.Header>
              <Card.Title as="h5">Recent Snapshots</Card.Title>
            </Card.Header>
            <Card.Body className="pb-0">
              <Table responsive hover>
                <thead>
                  <tr>
                    <th>Category</th>
                    <th>Location</th>
                    <th>Date</th>
                  </tr>
                </thead>
                <tbody>
                  {snapshots.map((s) => (
                    <tr>
                      <td>
                        <h6 className="mb-1">{s.category}</h6>
                      </td>
                      <td>
                        <span className="pie_1">{s.location}</span>
                      </td>
                      <td>
                        <h6 className="m-0">
                          {new Date(s.date).toDateString()}
                        </h6>
                      </td>
                    </tr>
                  ))}
                </tbody>
              </Table>
            </Card.Body>
          </Card>
        </Col>
        <Col md={4}>
          <Row>
            <Col md={12} xl={12} sm={12} lg={12}>
              <Card className="user-card">
                <Card.Body>
                  <h5 className="f-w-400 m-b-15">MC</h5>
                  <h4 className="f-w-300">{mc.length}</h4>
                </Card.Body>
              </Card>
            </Col>
            <Col md={12} xl={12} sm={12} lg={12}>
              <Card className="user-card">
                <Card.Body>
                  <h5 className="f-w-400 m-b-15">RTG</h5>
                  <h4 className="f-w-300">{rtg.length}</h4>
                </Card.Body>
              </Card>
            </Col>
            <Col md={12} xl={12} sm={12} lg={12}>
              <Card className="user-card">
                <Card.Body>
                  <h5 className="f-w-400 m-b-15">ECH</h5>
                  <h4 className="f-w-300">{ech.length}</h4>
                </Card.Body>
              </Card>
            </Col>
            <Col md={12} xl={12} sm={12} lg={12}>
              <Card className="user-card">
                <Card.Body>
                  <h5 className="f-w-400 m-b-15">RS</h5>
                  <h4 className="f-w-300">{rs.length}</h4>
                </Card.Body>
              </Card>
            </Col>
          </Row>
        </Col>
      </Row>
    </React.Fragment>
  );
};

export default Dashboard;

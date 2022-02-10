import React, { Suspense, Fragment, lazy } from "react";
import { Switch, Redirect, Route } from "react-router-dom";

import Loader from "./components/Loader/Loader";
import AdminLayout from "./layouts/AdminLayout";

import AuthGuard from "./components/Auth/AuthGuard";

import { BASE_URL } from "./config/constant";

export const renderRoutes = (routes = []) => (
  <Suspense fallback={<Loader />}>
    <Switch>
      {routes.map((route, i) => {
        const Guard = route.guard || Fragment;
        const Layout = route.layout || Fragment;
        const Component = route.component;

        return (
          <Route
            key={i}
            path={route.path}
            exact={route.exact}
            render={(props) => (
              <Guard>
                <Layout>
                  {route.routes ? (
                    renderRoutes(route.routes)
                  ) : (
                    <Component {...props} />
                  )}
                </Layout>
              </Guard>
            )}
          />
        );
      })}
    </Switch>
  </Suspense>
);

const routes = [
  {
    exact: true,
    path: "/auth/signin",
    component: lazy(() => import("./views/auth/SignIn5")),
  },
  {
    exact: true,
    path: "/auth/changePassword",
    component: lazy(() => import("./views/auth/ChangePassword")),
  },
  {
    path: "*",
    layout: AdminLayout,
    guard: AuthGuard,
    routes: [
      {
        exact: true,
        path: "/",
        component: lazy(() => import("./views/Dashboard/Dashboard")),
      },
      {
        exact: true,
        path: "/setup/shifts",
        component: lazy(() => import("./views/Shift/Shifts")),
      },
      {
        exact: true,
        path: "/setup/forklifts",
        component: lazy(() => import("./views/Forklift/Forklifts")),
      },
      {
        exact: true,
        path: "/setup/ITVES",
        component: lazy(() => import("./views/ITV/ITVES")),
      },
      {
        exact: true,
        path: "/setup/MHCES",
        component: lazy(() => import("./views/MHC/MHC")),
      },
      {
        exact: true,
        path: "/setup/MCES",
        component: lazy(() => import("./views/MC/MC")),
      },
      {
        exact: true,
        path: "/setup/RTGES",
        component: lazy(() => import("./views/RTG/RTG")),
      },
      {
        exact: true,
        path: "/setup/ECHES",
        component: lazy(() => import("./views/ECH/ECH")),
      },
      {
        exact: true,
        path: "/setup/RSES",
        component: lazy(() => import("./views/RS/RS")),
      },
      {
        exact: true,
        path: "/setup/users",
        component: lazy(() => import("./views/User/Users")),
      },
      {
        exact: true,
        path: "/checklist/checklistForm",
        component: lazy(() => import("./views/Checklist/ChecklistForm")),
      },
      {
        exact: true,
        path: "/snapshot/snapshotForm",
        component: lazy(() => import("./views/snapshot/Snapshot"))
      },
       {
        exact: true,
        path: "/report/forklifts",
        component: lazy(() => import("./views/report/Forklifts"))
      },
       {
        exact: true,
        path: "/report/itvs",
        component: lazy(() => import("./views/report/ITV"))
      },
       {
        exact: true,
        path: "/report/mhc",
        component: lazy(() => import("./views/report/MHC"))
      },
       {
        exact: true,
        path: "/report/rtg",
        component: lazy(() => import("./views/report/RTG"))
      },
       {
        exact: true,
        path: "/report/ech",
        component: lazy(() => import("./views/report/ECH"))
      },
        {
        exact: true,
        path: "/report/rs",
        component: lazy(() => import("./views/report/RS"))
      },
        {
        exact: true,
        path: "/report/snapshot",
        component: lazy(() => import("./views/report/Snapshot"))
      },
      {
        path: "*",
        exact: true,
        component: () => <Redirect to={BASE_URL} />,
      },
    ],
  },
];

export default routes;

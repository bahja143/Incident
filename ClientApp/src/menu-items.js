const menuItems = {
  items: [
    {
      id: "navigation",
      title: "Home",
      type: "group",
      icon: "icon-navigation",
      children: [
        {
          id: "dashboard",
          title: "Dashboard",
          type: "item",
          icon: "feather icon-home",
          url: "/",
        },
      ],
    },
    {
      id: "Setup",
      title: "Setup",
      type: "group",
      icon: "icon-ui",
      children: [
        {
          id: "Registration",
          title: "Registration",
          type: "collapse",
          icon: "feather icon-box",
          children: [
            {
              id: "2",
              title: "Forklifts",
              type: "item",
              url: "/setup/forklifts",
            },
            {
              id: "3",
              title: "ITV'S",
              type: "item",
              url: "/setup/ITVES",
            },
            {
              id: "4",
              title: "MHC'S",
              type: "item",
              url: "/setup/MHCES",
            },
            {
              id: "4",
              title: "MC'S",
              type: "item",
              url: "/setup/MCES",
            },
            {
              id: "4",
              title: "RTG'S",
              type: "item",
              url: "/setup/RTGES",
            },
            {
              id: "5",
              title: "ECH'S",
              type: "item",
              url: "/setup/ECHES",
            },
            {
              id: "6",
              title: "RS'S",
              type: "item",
              url: "/setup/RSES",
            },
            {
              id: "6",
              title: "Users",
              type: "item",
              url: "/setup/users",
            },
          ],
        },
      ],
    },
    {
      id: "Actions",
      title: "Actions",
      type: "group",
      icon: "icon-group",
      children: [
        {
          id: "Checklist Form",
          title: "Checklist Form",
          type: "item",
          icon: "feather icon-check-square",
          url: "/checklist/checklistForm",
        },
        {
          id: "Snapshot",
          title: "Snapshot",
          type: "item",
          icon: "feather icon-file-text",
          url: "/snapshot/snapshotForm",
        },
      ],
    },
    {
      id: "Report",
      title: "Report",
      type: "group",
      icon: "icon-ui",
      children: [
        {
          id: "Reports",
          title: "Reports",
          type: "collapse",
          icon: "feather icon-bar-chart-2",
          children: [
            {
              id: "2",
              title: "Forklifts",
              type: "item",
              url: "/report/forklifts",
            },
            {
              id: "3",
              title: "ITV'S",
              type: "item",
              url: "/report/itvs",
            },
            {
              id: "4",
              title: "MHC'S",
              type: "item",
              url: "/report/mhc",
            },
            {
              id: "4",
              title: "RTG'S",
              type: "item",
              url: "/report/rtg",
            },
            {
              id: "5",
              title: "ECH'S",
              type: "item",
              url: "/report/ech",
            },
            {
              id: "6",
              title: "RS'S",
              type: "item",
              url: "/report/rs",
            },
            {
              id: "7",
              title: "Snapshot",
              type: "item",
              url: "/report/snapshot",
            },
          ],
        },
      ],
    },
  ],
};

export default menuItems;

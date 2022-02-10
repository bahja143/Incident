using System;

namespace Incident.Modal
{
    public class SnapShot
    {
        public int Id { get; set; }

        public string Category { get; set; }
        public string IncidentType { get; set; }
        public string Location { get; set; }

        public string Shift { get; set; }

        public string PeopleInvolved { get; set; }

        public string Equipment { get; set; }

        public string Responsible { get; set; }

        public string Image { get; set; }
        public string Status { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }



    }
}
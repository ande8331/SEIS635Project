﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class EventLocation
    {
        public String locationAddress { get; set; }
        public String locationName { get; set; }
        public int locationPK { get; private set; }

        public static List<EventLocation> getLocationsBelongingToEvent(int eventPK)
        {
            List<EventLocation> returnVar = new List<EventLocation>();

            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["eventFK"].Equals(eventPK))
                {
                    EventLocation myLocation = new EventLocation(Convert.ToInt32(data.Rows[i]["locationFK"]));
                    returnVar.Add(myLocation);
                }
            }
            return returnVar;
        }

        public EventLocation(eventPlannerAccessDBDataSet.locationRow row)
        {
            locationPK = Convert.ToInt32(row["ID"]);
            locationName = Convert.ToString(row["locationName"]);
            locationAddress = Convert.ToString(row["locationAddress"]);
        }

        public EventLocation(int _locationPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter();
            eventPlannerAccessDBDataSet.locationDataTable data = new eventPlannerAccessDBDataSet.locationDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.locationRow row = data.FindByID(_locationPK);
            if (data.Rows.Count > 0)
            {
                locationPK = Convert.ToInt32(row["ID"]);
                locationName = Convert.ToString(row["locationName"]);
                locationAddress = Convert.ToString(row["locationAddress"]);
            }
        }
    }
}
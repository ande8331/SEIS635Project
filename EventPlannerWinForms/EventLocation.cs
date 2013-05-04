using System;
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

        public static List<EventLocation> getLocationsNotBelongingToEvent(int eventPK)
        {
            List<EventLocation> returnVar = new List<EventLocation>();

            eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter vendorAdapter = new eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter();
            eventPlannerAccessDBDataSet.locationDataTable locationData = new eventPlannerAccessDBDataSet.locationDataTable();
            vendorAdapter.Fill(locationData);

            for (int i = 0; i < locationData.Rows.Count; i++)
            {
                EventLocation myLocation = new EventLocation(Convert.ToInt32(locationData.Rows[i]["ID"]));
                returnVar.Add(myLocation);
            }

            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["eventFK"].Equals(eventPK))
                {
                    for (int j = 0; j < returnVar.Count; j++)
                    {
                        if (returnVar[j].locationPK == Convert.ToInt32(data.Rows[i]["locationFK"]))
                        {
                            returnVar.RemoveAt(j);
                            break;
                        }
                    }
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

        public EventLocation()
        {

        }

        public void SaveLocationChanges()
        {
            eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter();
            eventPlannerAccessDBDataSet.locationDataTable data = new eventPlannerAccessDBDataSet.locationDataTable();
            myadapter.Fill(data);
            if (locationPK != 0)
            {
                eventPlannerAccessDBDataSet.locationRow temp = data.FindByID(locationPK);
                temp["locationName"] = locationName;
                temp["locationAddress"] = locationAddress;
                myadapter.Update(temp);
            }
            else
            {
                myadapter.Insert(locationName, locationAddress);
            }
        
        }

        public void AddLocationToEvent(int eventPK)
        {
            if (this.locationPK == null)
            {
                eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter vendorAdapter = new eventPlannerAccessDBDataSetTableAdapters.locationTableAdapter();
                this.locationPK = vendorAdapter.Insert(this.locationName, this.locationAddress);
            }

            eventPlannerAccessDBDataSetTableAdapters.eventToLocationAssociationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventToLocationAssociationTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable();
            myadapter.Insert(eventPK, this.locationPK);
        }

    }
}

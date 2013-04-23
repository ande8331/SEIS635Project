using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class Events
    {

    }

    class Event
    {
        public DateTime eventStart { get; set; }
        public DateTime eventEnd { get; set; }
        public String eventName { get; set; }
        public int eventPK { get; private set; }

        public static List<Event> getEventsBelongingToOwner(int ownerPK)
        {
            List<Event> returnVar = new List<Event>();

            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["owner"].Equals(ownerPK))
                {
                    Event myEvent = new Event((eventPlannerAccessDBDataSet.eventRow) data.Rows[i]);
                    returnVar.Add(myEvent);
                }
            }
            return returnVar;
        }

        public Event(eventPlannerAccessDBDataSet.eventRow row)
        {
            eventPK = Convert.ToInt32(row["ID"]);
            eventName = Convert.ToString(row["eventName"]);
            eventStart = Convert.ToDateTime(row["start"]);
            eventEnd = Convert.ToDateTime(row["end"]);
        }

        public Event(int _eventPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.eventRow row = data.FindByID(_eventPK);
            if (row != null)
            {
                eventPK = Convert.ToInt32(row["ID"]);
                eventName = Convert.ToString(row["eventName"]);
                eventStart = Convert.ToDateTime(row["start"]);
                eventEnd = Convert.ToDateTime(row["end"]);
            }
        }

        public void saveEvent()
        {
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.eventRow myRow = data.FindByID(eventPK);
            if (myRow != null)
            {
                myRow.eventName = eventName;
                myRow.start = eventStart;
                myRow.end = eventEnd;
                myadapter.Update(myRow);
            }
        }

        public void addVendor(int vendorPK)
        {

        }

    }
}

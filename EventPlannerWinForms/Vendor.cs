using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class Vendor
    {
        public String vendorRole { get; set; }
        public String vendorName { get; set; }
        public int vendorPK { get; private set; }

        public static List<Vendor> getEventsBelongingToEvent(int eventPK)
        {
            List<Vendor> returnVar = new List<Vendor>();

            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["eventFK"].Equals(eventPK))
                {
                    Vendor myVendor = new Vendor(Convert.ToInt32(data.Rows[i]["vendorFK"]));
                    returnVar.Add(myVendor);
                }
            }
            return returnVar;
        }

        public Vendor(eventPlannerAccessDBDataSet.vendorRow row)
        {
            vendorPK = Convert.ToInt32(row["ID"]);
            vendorName = Convert.ToString(row["vendorName"]);
            vendorRole = Convert.ToString(row["vendorRole"]);
        }

        public Vendor(int _vendorPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.vendorTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.vendorTableAdapter();
            eventPlannerAccessDBDataSet.vendorDataTable data = new eventPlannerAccessDBDataSet.vendorDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.vendorRow row = data.FindByID(_vendorPK);
            if (data.Rows.Count > 0)
            {
                vendorPK = Convert.ToInt32(row["ID"]);
                vendorName = Convert.ToString(row["vendorName"]);
                vendorRole = Convert.ToString(row["vendorRole"]);
            }
        }
    }
}

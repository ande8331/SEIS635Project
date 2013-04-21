using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlannerWinForms
{
    public partial class Event : Form
    {
        private int _eventPK;

        public Event(int eventPK)
        {
            _eventPK = eventPK;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);

            eventPlannerAccessDBDataSet.eventRow myRow = data.FindByID(_eventPK);
            myRow.eventName = eventNameTextBox.Text;
            myRow.start = eventStartDateTimePicker.Value;
            myRow.end = eventEndDateTimePicker.Value;
            myadapter.Update(myRow);
            

        }

        private void Event_Load(object sender, EventArgs e)
        {
            eventStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventStartDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt";
            eventEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventEndDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt"; 

            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.eventRow myRow = data.FindByID(_eventPK);
            eventNameTextBox.Text = myRow.eventName;
            eventStartDateTimePicker.Value = myRow.start;
            eventEndDateTimePicker.Value = myRow.end;

            clearAndFillVendorsDataGridView();
            clearAndFillLocationsDataGridView();
        }

        private void clearAndFillLocationsDataGridView()
        {
            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter locationsAdapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable locations = new eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable();
            locationsAdapter.Fill(locations);

            locationsDataGridView.Rows.Clear();
            locationsDataGridView.Columns.Clear();
            locationsDataGridView.AllowUserToAddRows = false;
            locationsDataGridView.AllowUserToDeleteRows = false;
            locationsDataGridView.ShowEditingIcon = false;
            locationsDataGridView.RowHeadersVisible = false;

            locationsDataGridView.Columns.Add("PK", "PK");
            locationsDataGridView.Columns[0].Visible = false;
            locationsDataGridView.Columns.Add("", "");
            locationsDataGridView.Columns.Add("Location Name", "Location Name");
            locationsDataGridView.Columns.Add("Address", "Address");
            for (int i = 0; i < locations.Rows.Count; i++)
            {
                if (locations.Rows[i]["eventFK"].Equals(_eventPK))
                {
                    locationsDataGridView.Rows.Add(locations.Rows[i]["eventToLocationAssociation_ID"], "Remove", locations.Rows[i]["locationName"], locations.Rows[i]["locationAddress"]);
                }
            }
        }

        private void clearAndFillVendorsDataGridView()
        {
            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter vendorsAdapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable vendors = new eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable();
            vendorsAdapter.Fill(vendors);

            vendorsDataGridView.Rows.Clear();
            vendorsDataGridView.Columns.Clear();
            vendorsDataGridView.AllowUserToAddRows = false;
            vendorsDataGridView.AllowUserToDeleteRows = false;
            vendorsDataGridView.ShowEditingIcon = false;
            vendorsDataGridView.RowHeadersVisible = false;

            vendorsDataGridView.Columns.Add("PK", "PK");
            vendorsDataGridView.Columns[0].Visible = false;
            vendorsDataGridView.Columns.Add("", "");
            vendorsDataGridView.Columns.Add("Vendor Name", "Vendor Name");
            vendorsDataGridView.Columns.Add("Service Provided", "Service Provided");
            for (int i = 0; i < vendors.Rows.Count; i++)
            {
                if (vendors.Rows[i]["eventFK"].Equals(_eventPK))
                {
                    vendorsDataGridView.Rows.Add(vendors.Rows[i]["vendor_ID"], "Remove", vendors.Rows[i]["vendorName"], vendors.Rows[i]["vendorRole"]);
                }
            }
        }

        private void addNewVendorLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO
        }

        private void addNewLocationLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TODO
        }

        private void locationsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO
        }

        private void vendorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO
        }
    }
}

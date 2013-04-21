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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            clearAndLoadEventsIOwn();
        }

        private void clearAndLoadEventsIOwn()
        {
            ownedEventDataGrid.Rows.Clear();
            ownedEventDataGrid.Columns.Clear();
            ownedEventDataGrid.AllowUserToAddRows = false;
            ownedEventDataGrid.AllowUserToDeleteRows = false;
            ownedEventDataGrid.ShowEditingIcon = false;
            //ownedEventDataGrid.RowHeadersVisible = false;
            ownedEventDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ownedEventDataGrid.Columns.Add("PK", "PK");
            ownedEventDataGrid.Columns[0].Visible = false;
            ownedEventDataGrid.Columns.Add("Edit", "");
            ownedEventDataGrid.Columns.Add("Event Name", "Event Name");
            ownedEventDataGrid.Columns["Event Name"].Width = 150;
            ownedEventDataGrid.Columns.Add("Event Start", "Event Start");
            ownedEventDataGrid.Columns["Event Start"].Width = 150;
            ownedEventDataGrid.Columns.Add("Event End", "Event End");
            ownedEventDataGrid.Columns["Event End"].Width = 150;

            // Retreive Records            
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);
            
            DataGridViewCellStyle myStyle = new DataGridViewCellStyle();            
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["owner"].Equals(1))
                {
                    // Create Rows
                    int rowNumber = ownedEventDataGrid.Rows.Add(data.Rows[i]["ID"], "Edit", data.Rows[i]["eventName"], data.Rows[i]["start"], data.Rows[i]["end"]);
                    ownedEventDataGrid["Edit", rowNumber].Style.ForeColor = Color.Blue;
                    Font myFont = new Font(ownedEventDataGrid.DefaultCellStyle.Font, FontStyle.Underline);
                }
            }

            ownedEventDataGrid.ClearSelection();
        }

        private void ownedEventDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //Event popUpWindow = new Event(Convert.ToInt32(ownedEventDataGrid[0, e.RowIndex].Value));
                //popUpWindow.ShowDialog();
                //clearAndLoadEventsIOwn();
                populateEventPanel(Convert.ToInt32(ownedEventDataGrid[0, e.RowIndex].Value));
            }
        }

        private void populateEventPanel(int _eventPK)
        {
            eventsOwnedTabControl.Visible = true;
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

            clearAndFillownedEventVendorsDataGridView(_eventPK);
            clearAndFillownedEventLocationsDataGridView(_eventPK);

        }
        private void clearAndFillownedEventLocationsDataGridView(int _eventPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter locationsAdapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedLocationsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable locations = new eventPlannerAccessDBDataSet.eventsJoinedLocationsDataTable();
            locationsAdapter.Fill(locations);

            ownedEventLocationsDataGridView.Rows.Clear();
            ownedEventLocationsDataGridView.Columns.Clear();
            ownedEventLocationsDataGridView.AllowUserToAddRows = false;
            ownedEventLocationsDataGridView.AllowUserToDeleteRows = false;
            ownedEventLocationsDataGridView.ShowEditingIcon = false;
            ownedEventLocationsDataGridView.RowHeadersVisible = false;

            ownedEventLocationsDataGridView.Columns.Add("PK", "PK");
            ownedEventLocationsDataGridView.Columns[0].Visible = false;
            ownedEventLocationsDataGridView.Columns.Add("", "");
            ownedEventLocationsDataGridView.Columns.Add("Location Name", "Location Name");
            ownedEventLocationsDataGridView.Columns.Add("Address", "Address");
            for (int i = 0; i < locations.Rows.Count; i++)
            {
                if (locations.Rows[i]["eventFK"].Equals(_eventPK))
                {
                    ownedEventLocationsDataGridView.Rows.Add(locations.Rows[i]["eventToLocationAssociation_ID"], "Remove", locations.Rows[i]["locationName"], locations.Rows[i]["locationAddress"]);
                }
            }
        }

        private void clearAndFillownedEventVendorsDataGridView(int _eventPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter vendorsAdapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable vendors = new eventPlannerAccessDBDataSet.eventsJoinedVendorsDataTable();
            vendorsAdapter.Fill(vendors);

            ownedEventVendorsDataGridView.Rows.Clear();
            ownedEventVendorsDataGridView.Columns.Clear();
            ownedEventVendorsDataGridView.AllowUserToAddRows = false;
            ownedEventVendorsDataGridView.AllowUserToDeleteRows = false;
            ownedEventVendorsDataGridView.ShowEditingIcon = false;
            ownedEventVendorsDataGridView.RowHeadersVisible = false;

            ownedEventVendorsDataGridView.Columns.Add("PK", "PK");
            ownedEventVendorsDataGridView.Columns[0].Visible = false;
            ownedEventVendorsDataGridView.Columns.Add("", "");
            ownedEventVendorsDataGridView.Columns.Add("Vendor Name", "Vendor Name");
            ownedEventVendorsDataGridView.Columns.Add("Service Provided", "Service Provided");
            for (int i = 0; i < vendors.Rows.Count; i++)
            {
                if (vendors.Rows[i]["eventFK"].Equals(_eventPK))
                {
                    ownedEventVendorsDataGridView.Rows.Add(vendors.Rows[i]["vendor_ID"], "Remove", vendors.Rows[i]["vendorName"], vendors.Rows[i]["vendorRole"]);
                }
            }
        }


        private void ownedEventDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            ownedEventDataGrid.CurrentRow.Selected = false;
        }

        private void eventsIOwnPage_Enter(object sender, EventArgs e)
        {
            eventsOwnedTabControl.Visible = false;
        }
    }
}

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
            List<Event> myEvents = Event.getEventsBelongingToOwner(1);

            foreach (Event myEvent in myEvents)
            {
                int rowNumber = ownedEventDataGrid.Rows.Add(myEvent.eventPK, "Edit", myEvent.eventName, myEvent.eventStart, myEvent.eventEnd);
                ownedEventDataGrid["Edit", rowNumber].Style.ForeColor = Color.Blue;
                Font myFont = new Font(ownedEventDataGrid.DefaultCellStyle.Font, FontStyle.Underline);                
            }

            ownedEventDataGrid.ClearSelection();
        }

        private void ownedEventDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            changeDisplayedEvent(e.RowIndex);
        }
        private void ownedEventDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            changeDisplayedEvent(e.RowIndex);
        }
        private void changeDisplayedEvent(int rowIndex)
        {
            displayedOwnedEvent = new Event(Convert.ToInt32(ownedEventDataGrid[0, rowIndex].Value));
            populateEventPanel();
        }


        private void populateEventPanel()
        {
            eventsOwnedTabControl.Visible = true;
            eventStartDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventStartDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt";
            eventEndDateTimePicker.Format = DateTimePickerFormat.Custom;
            eventEndDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt";

            eventNameTextBox.Text = displayedOwnedEvent.eventName;
            eventStartDateTimePicker.Value = displayedOwnedEvent.eventStart;
            eventEndDateTimePicker.Value = displayedOwnedEvent.eventEnd;

            clearAndFillownedEventVendorsDataGridView(displayedOwnedEvent.eventPK);
            clearAndFillownedEventLocationsDataGridView(displayedOwnedEvent.eventPK);

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

            List<EventLocation> myLocations = EventLocation.getLocationsBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (EventLocation myLocation in myLocations)
            {
                ownedEventLocationsDataGridView.Rows.Add(myLocation.locationPK, "Remove", myLocation.locationName, myLocation.locationAddress);
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

            List<Vendor> myVendors = Vendor.getEventsBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (Vendor myVendor in myVendors)
            {
                ownedEventVendorsDataGridView.Rows.Add(myVendor.vendorPK, "Remove", myVendor.vendorName, myVendor.vendorRole);
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

        private Event displayedOwnedEvent;
        private void saveOwnedEventDetailButton_Click(object sender, EventArgs e)
        {
            displayedOwnedEvent.saveEvent();
            clearAndLoadEventsIOwn();
        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (displayedOwnedEvent != null)
            {
                displayedOwnedEvent.eventName = eventNameTextBox.Text;
            }
        }

        private void eventStartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (displayedOwnedEvent != null)
            {
                displayedOwnedEvent.eventStart = eventStartDateTimePicker.Value;
            }
        }

        private void eventEndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (displayedOwnedEvent != null)
            {
                displayedOwnedEvent.eventEnd = eventEndDateTimePicker.Value;
            }
        }

        private void addNewVendorLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void addNewWishListItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void addNewInvitationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void addNewLocationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }


    }
}

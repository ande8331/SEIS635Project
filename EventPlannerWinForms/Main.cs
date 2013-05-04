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
        private Event displayedOwnedEvent;
        private int ownerPK = 1;
        

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            clearAndLoadEventsIOwn();
            clearAndLoadMyWishlists();
        }

        /*
         * Events I Own Tab Stuff
         */
        private void changeDisplayedEvent(int rowIndex)
        {
            displayedOwnedEvent = new Event(Convert.ToInt32(ownedEventDataGrid[0, rowIndex].Value));
            /*populateEventPanel();
            refreshVendorTab();
            refreshLocationTab();
            refreshOwnedInvitationTab();
             */
            eventsOwnedTabControl_SelectedIndexChanged(this, EventArgs.Empty);
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
            List<Event> myEvents = Event.getEventsBelongingToOwner(ownerPK);

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

        private void ownedEventDataGrid_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void eventsIOwnPage_Enter(object sender, EventArgs e)
        {
            eventsOwnedTabControl.Visible = false;
        }

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

        private void populateEventPanel()
        {
            if (displayedOwnedEvent != null)
            {
                eventsOwnedTabControl.Visible = true;
                eventStartDateTimePicker.Format = DateTimePickerFormat.Custom;
                eventStartDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt";
                eventEndDateTimePicker.Format = DateTimePickerFormat.Custom;
                eventEndDateTimePicker.CustomFormat = "ddddd, MMMM dd, yyyy hh:mm ttt";

                eventNameTextBox.Text = displayedOwnedEvent.eventName;
                eventStartDateTimePicker.Value = displayedOwnedEvent.eventStart;
                eventEndDateTimePicker.Value = displayedOwnedEvent.eventEnd;
            }
            else
            {
                eventsOwnedTabControl.Visible = false;
            }
        }


        /*
         * Locations Tab Stuff
         */
        private EventLocation displayedLocation;
        private void refreshLocationTab()
        {
            clearAndFillownedEventLocationsDataGridView();
            clearAndFillAvailableEventLocationsDataGridView();
            updateDisplayedLocationData();
        }

        private void clearAndFillownedEventLocationsDataGridView()
        {
            ownedEventLocationsDataGridView.Rows.Clear();
            ownedEventLocationsDataGridView.Columns.Clear();
            ownedEventLocationsDataGridView.AllowUserToAddRows = false;
            ownedEventLocationsDataGridView.AllowUserToDeleteRows = false;
            ownedEventLocationsDataGridView.ShowEditingIcon = false;
            ownedEventLocationsDataGridView.RowHeadersVisible = false;

            ownedEventLocationsDataGridView.Columns.Add("PK", "PK");
            ownedEventLocationsDataGridView.Columns[0].Visible = false;
            ownedEventLocationsDataGridView.Columns.Add("", "");
            ownedEventLocationsDataGridView.Columns[1].Width = 100;
            ownedEventLocationsDataGridView.Columns.Add("Location Name", "Location Name");
            ownedEventLocationsDataGridView.Columns[2].Width = 250;
            ownedEventLocationsDataGridView.Columns.Add("Address", "Address");
            ownedEventLocationsDataGridView.Columns[3].Width = 300;

            List<EventLocation> myLocations = EventLocation.getLocationsBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (EventLocation myLocation in myLocations)
            {
                ownedEventLocationsDataGridView.Rows.Add(myLocation.locationPK, "Remove", myLocation.locationName, myLocation.locationAddress);
            }
        }

        private void clearAndFillAvailableEventLocationsDataGridView()
        {
            availableEventLocationDataGridView.Columns.Clear();
            availableEventLocationDataGridView.AllowUserToAddRows = false;
            availableEventLocationDataGridView.AllowUserToDeleteRows = false;
            availableEventLocationDataGridView.ShowEditingIcon = false;
            availableEventLocationDataGridView.RowHeadersVisible = false;

            availableEventLocationDataGridView.Columns.Add("PK", "PK");
            availableEventLocationDataGridView.Columns[0].Visible = false;
            availableEventLocationDataGridView.Columns.Add("Location Name", "Location Name");
            availableEventLocationDataGridView.Columns[1].Width = 250;

            List<EventLocation> myLocations = EventLocation.getLocationsNotBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (EventLocation myLocation in myLocations)
            {
                availableEventLocationDataGridView.Rows.Add(myLocation.locationPK, myLocation.locationName);
            }
        }

        private void updateDisplayedLocationData()
        {
            if (displayedLocation != null)
            {
                //vendorDetailPanel.Visible = true;
                locationNameTextBox.Text = displayedLocation.locationName;
                locationAddressTextBox.Text = displayedLocation.locationAddress;
            }
            else
            {
                //vendorDetailPanel.Visible = false;
                locationNameTextBox.Text = "" ;
                locationAddressTextBox.Text = "";
            }
        }
        private void addLocationToEventButton_Click(object sender, EventArgs e)
        {
            displayedLocation.AddLocationToEvent(displayedOwnedEvent.eventPK);
            displayedLocation = null;
            refreshLocationTab();
        }

        private void createNewLocationButton_Click(object sender, EventArgs e)
        {
            displayedLocation = new EventLocation();
            int temp = availableEventLocationDataGridView.Rows.Add();
            availableEventLocationDataGridView.ClearSelection();
            availableEventLocationDataGridView.Rows[temp].Selected = true;
            updateDisplayedLocationData();
        }

        private void saveLocationButton_Click(object sender, EventArgs e)
        {
            displayedLocation.locationName = locationNameTextBox.Text;
            displayedLocation.locationAddress = locationAddressTextBox.Text;
            displayedLocation.SaveLocationChanges();
            refreshLocationTab();
        }

        private void availableEventLocationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displayedLocation = new EventLocation(Convert.ToInt32(availableEventLocationDataGridView[0, e.RowIndex].Value));
            updateDisplayedLocationData();
        }

        private void availableEventLocationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayedLocation = new EventLocation(Convert.ToInt32(availableEventLocationDataGridView[0, e.RowIndex].Value));
            updateDisplayedLocationData();
        }

        /*
         * Vendors Tab Stuff
         */
        private Vendor displayedVendor;
        private void refreshVendorTab()
        {
            clearAndFillOwnedEventVendorsDataGridView();
            clearAndFillAvailableVendors();
            updateDisplayedVendorData();
        }
        private void clearAndFillOwnedEventVendorsDataGridView()
        {
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
            ownedEventVendorsDataGridView.Columns[2].Width = 200;
            ownedEventVendorsDataGridView.Columns.Add("Service Provided", "Service Provided");
            ownedEventVendorsDataGridView.Columns[3].Width = 200;

            List<Vendor> myVendors = Vendor.getVendorsBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (Vendor myVendor in myVendors)
            {
                ownedEventVendorsDataGridView.Rows.Add(myVendor.vendorPK, "Remove", myVendor.vendorName, myVendor.vendorRole);
            }
        }

        private void clearAndFillAvailableVendors()
        {
            addNewVendorPanel.Visible = true;
            availableVendorsDataGridView.Rows.Clear();
            availableVendorsDataGridView.Columns.Clear();
            availableVendorsDataGridView.AllowUserToAddRows = false;
            availableVendorsDataGridView.AllowUserToDeleteRows = false;
            availableVendorsDataGridView.ShowEditingIcon = false;

            availableVendorsDataGridView.Columns.Add("PK", "PK");
            availableVendorsDataGridView.Columns[0].Visible = false;
            availableVendorsDataGridView.Columns.Add("Vendor Name", "Vendor Name");

            List<Vendor> myVendors = Vendor.getVendorsNotBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (Vendor myVendor in myVendors)
            {
                availableVendorsDataGridView.Rows.Add(myVendor.vendorPK, myVendor.vendorName);
            }
            availableVendorsDataGridView.Columns[1].Width = availableVendorsDataGridView.Width - 45;

            if ((myVendors.Count > 0) && (displayedVendor == null))
            {
                displayedVendor = myVendors[0];
            }
            updateDisplayedVendorData();
        }

        private void updateDisplayedVendorData()
        {
            if (displayedVendor != null)
            {
                vendorDetailPanel.Visible = true;
                vendorNameTextBox.Text = displayedVendor.vendorName;
                vendorRoleTextBox.Text = displayedVendor.vendorRole;
            }
            else
            {
                vendorDetailPanel.Visible = false;
            }
        }

        private void addVendorButton_Click(object sender, EventArgs e)
        {
            displayedVendor.AddVendorToEvent(displayedOwnedEvent.eventPK);
            displayedVendor = null;
            refreshVendorTab();
        }

        private void createNewVendorButton_Click(object sender, EventArgs e)
        {
            displayedVendor = new Vendor();
            int temp = availableVendorsDataGridView.Rows.Add();
            availableVendorsDataGridView.ClearSelection();
            availableVendorsDataGridView.Rows[temp].Selected = true;
            updateDisplayedVendorData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            displayedVendor = new Vendor(Convert.ToInt32(availableVendorsDataGridView[0, e.RowIndex].Value));
            updateDisplayedVendorData();
        }

        private void availableVendorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayedVendor = new Vendor(Convert.ToInt32(availableVendorsDataGridView[0, e.RowIndex].Value));
            updateDisplayedVendorData();
        }

        private void saveVendorBtn_Click(object sender, EventArgs e)
        {
            displayedVendor.vendorName = vendorNameTextBox.Text;
            displayedVendor.vendorRole = vendorRoleTextBox.Text;
            displayedVendor.SaveVendorChanges();
            refreshVendorTab();
        }

        /*
         * Events I Own - Invitations Stuff
         */
        private void refreshOwnedInvitationTab()
        {
            clearAndFillOwnedEventInvitationDataGridView();
        }

        private void clearAndFillOwnedEventInvitationDataGridView()
        {           
            ownedEventInvitationsDataGridView.Rows.Clear();
            ownedEventInvitationsDataGridView.Columns.Clear();
            ownedEventInvitationsDataGridView.AllowUserToAddRows = false;
            ownedEventInvitationsDataGridView.AllowUserToDeleteRows = false;
            ownedEventInvitationsDataGridView.ShowEditingIcon = false;
            ownedEventInvitationsDataGridView.RowHeadersVisible = false;

            ownedEventInvitationsDataGridView.Columns.Add("PK", "PK");
            ownedEventInvitationsDataGridView.Columns[0].Visible = false;
            ownedEventInvitationsDataGridView.Columns.Add("", "");
            ownedEventInvitationsDataGridView.Columns.Add("Invitee Name", "Invitee Name");
            ownedEventInvitationsDataGridView.Columns[2].Width = 200;
            ownedEventInvitationsDataGridView.Columns.Add("Message", "Message");
            ownedEventInvitationsDataGridView.Columns[3].Width = 200;

            List<Invitation> myInvitations = Invitation.getInvitationsBelongingToEvent(displayedOwnedEvent.eventPK);

            foreach (Invitation myInvitation in myInvitations)
            {
                User myUser = new User(myInvitation.userFK);
                ownedEventInvitationsDataGridView.Rows.Add(myInvitation.invitationPK, "Remove", myUser.lastName + ", " + myUser.firstName, myInvitation.invitationText);
            }

        }

        /*
         * Events I'm Invited to Stuff
         */

        private void refreshMyInvitationsTab()
        {
            clearandFillEventsInvitedToDataGridView();
        }

        private void clearandFillEventsInvitedToDataGridView()
        {
            eventsInvitedToDataGridView.Rows.Clear();
            eventsInvitedToDataGridView.Columns.Clear();
            eventsInvitedToDataGridView.AllowUserToAddRows = false;
            eventsInvitedToDataGridView.AllowUserToDeleteRows = false;
            eventsInvitedToDataGridView.ShowEditingIcon = false;
            eventsInvitedToDataGridView.RowHeadersVisible = false;

            eventsInvitedToDataGridView.Columns.Add("PK", "PK");
            eventsInvitedToDataGridView.Columns[0].Visible = false;
            eventsInvitedToDataGridView.Columns.Add("", "");
            eventsInvitedToDataGridView.Columns.Add("Event Name", "Event Name");
            eventsInvitedToDataGridView.Columns[2].Width = 200;
            eventsInvitedToDataGridView.Columns.Add("Start", "Start");
            eventsInvitedToDataGridView.Columns[3].Width = 200;
            eventsInvitedToDataGridView.Columns.Add("End", "End");
            eventsInvitedToDataGridView.Columns[4].Width = 200;


            List<Invitation> myInvitations = Invitation.getInvitationsForUser(ownerPK);

            foreach (Invitation myInvitation in myInvitations)
            {
                Event myEvent = new Event(myInvitation.eventFK);
                eventsInvitedToDataGridView.Rows.Add(myInvitation.invitationPK, "Remove", myEvent.eventName, myEvent.eventStart, myEvent.eventEnd);
            }
        }


        /*
         * Wishlist Tab Stuff
         */
        private void clearAndLoadMyWishlists()
        {
            myWishListDataGridView.Rows.Clear();
            myWishListDataGridView.Columns.Clear();
            myWishListDataGridView.AllowUserToAddRows = false;
            myWishListDataGridView.AllowUserToDeleteRows = false;
            myWishListDataGridView.ShowEditingIcon = false;
            //myWishListDataGridView.RowHeadersVisible = false;
            myWishListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            myWishListDataGridView.Columns.Add("PK", "PK");
            myWishListDataGridView.Columns[0].Visible = false;
            myWishListDataGridView.Columns.Add("Edit", "");
            myWishListDataGridView.Columns.Add("Wishlist Name", "Wishlist Name");
            myWishListDataGridView.Columns["Wishlist Name"].Width = 150;

            List<WishList> myWishlists = WishList.getWishlistsForOwner(ownerPK);

            foreach (WishList myWishlist in myWishlists)
            {
                int rowNumber = myWishListDataGridView.Rows.Add(myWishlist.wishlistPK, "Edit", myWishlist.wishlistName);
                myWishListDataGridView["Edit", rowNumber].Style.ForeColor = Color.Blue;
                Font myFont = new Font(myWishListDataGridView.DefaultCellStyle.Font, FontStyle.Underline);
            }
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

        private void addNewWishlistLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void addNewWishlistItemLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void wishlistPage_Click(object sender, EventArgs e)
        {
            
        }

        private void myWishListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            changeDisplayedWishlist(e.RowIndex);
        }

        private void myWishListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            changeDisplayedWishlist(e.RowIndex);
        }

        private void changeDisplayedWishlist(int rowIndex)
        {
            displayedOwnedEvent = new Event(Convert.ToInt32(ownedEventDataGrid[0, rowIndex].Value));

            wishListItemsDataGridView.Rows.Clear();
            wishListItemsDataGridView.Columns.Clear();
            wishListItemsDataGridView.AllowUserToAddRows = false;
            wishListItemsDataGridView.AllowUserToDeleteRows = false;
            wishListItemsDataGridView.ShowEditingIcon = false;
            //myWishListDataGridView.RowHeadersVisible = false;
            wishListItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            wishListItemsDataGridView.Columns.Add("PK", "PK");
            wishListItemsDataGridView.Columns[0].Visible = false;
            wishListItemsDataGridView.Columns.Add("Edit", "");
            wishListItemsDataGridView.Columns.Add("Item Name", "Name");
            wishListItemsDataGridView.Columns["Item Name"].Width = 150;
            wishListItemsDataGridView.Columns.Add("Item UPC", "UPC");
            wishListItemsDataGridView.Columns["Item UPC"].Width = 150;
            wishListItemsDataGridView.Columns.Add("Item Cost", "Cost");
            wishListItemsDataGridView.Columns["Item Cost"].Width = 80;

            List<GiftItem> wishlistItems = GiftItem.getGiftItemsBelongingToWishList(rowIndex);

            foreach (GiftItem item in wishlistItems)
            {
                int rowNumber = wishListItemsDataGridView.Rows.Add(item.giftItemPK, "Edit", item.giftItemName);
                wishListItemsDataGridView["Edit", rowNumber].Style.ForeColor = Color.Blue;
                Font myFont = new Font(wishListItemsDataGridView.DefaultCellStyle.Font, FontStyle.Underline);
            }
        }

        private void eventsOwnedTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsOwnedTabControl.SelectedIndex == 0)
            {
                populateEventPanel();
            }

            if (eventsOwnedTabControl.SelectedIndex == 1)
            {
                displayedVendor = null;
                refreshVendorTab();
            }

            if (eventsOwnedTabControl.SelectedIndex == 2)
            {
                refreshLocationTab();
            }

            if (eventsOwnedTabControl.SelectedIndex == 3)
            {
                refreshOwnedInvitationTab();
            }
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                eventsOwnedTabControl_SelectedIndexChanged(this, EventArgs.Empty);
            }

            if (tabControl.SelectedIndex == 1)
            {
                refreshMyInvitationsTab();
            }

            if (tabControl.SelectedIndex == 2)
            {

            }
        }

        private void ownedEventVendorsPage_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }







 
    }
}

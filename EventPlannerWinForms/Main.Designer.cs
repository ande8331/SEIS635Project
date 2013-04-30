namespace EventPlannerWinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ownedEventDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.saveVendorButton = new System.Windows.Forms.TabPage();
            this.eventsOwnedTabControl = new System.Windows.Forms.TabControl();
            this.ownedEventDetailsPage = new System.Windows.Forms.TabPage();
            this.saveOwnedEventDetailButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.eventEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ownedEventVendorsPage = new System.Windows.Forms.TabPage();
            this.addNewVendorPanel = new System.Windows.Forms.Panel();
            this.vendorDetailPanel = new System.Windows.Forms.Panel();
            this.saveVendorBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.createNewVendorButton = new System.Windows.Forms.Button();
            this.vendorRoleTextBox = new System.Windows.Forms.TextBox();
            this.addVendorButton = new System.Windows.Forms.Button();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.availableVendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.ownedEventVendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.ownedEventLocationsPage = new System.Windows.Forms.TabPage();
            this.ownedEventLocationsDataGridView = new System.Windows.Forms.DataGridView();
            this.ownedEventInvitationsPage = new System.Windows.Forms.TabPage();
            this.addNewInvitationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ownedEventInvitationsDataGridView = new System.Windows.Forms.DataGridView();
            this.eventInvitedToPage = new System.Windows.Forms.TabPage();
            this.eventsInvitedToDetailPanel = new System.Windows.Forms.Panel();
            this.eventsInvitedToWishListDataGridView = new System.Windows.Forms.DataGridView();
            this.eventsInvitedToInvitationPanel = new System.Windows.Forms.Panel();
            this.eventsInvitedToDataGridView = new System.Windows.Forms.DataGridView();
            this.wishlistPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewWishlistItemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.wishListItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewWishlistLinkLabel = new System.Windows.Forms.LinkLabel();
            this.myWishListDataGridView = new System.Windows.Forms.DataGridView();
            this.availableEventDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.saveVendorButton.SuspendLayout();
            this.eventsOwnedTabControl.SuspendLayout();
            this.ownedEventDetailsPage.SuspendLayout();
            this.ownedEventVendorsPage.SuspendLayout();
            this.addNewVendorPanel.SuspendLayout();
            this.vendorDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableVendorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventVendorsDataGridView)).BeginInit();
            this.ownedEventLocationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventLocationsDataGridView)).BeginInit();
            this.ownedEventInvitationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventInvitationsDataGridView)).BeginInit();
            this.eventInvitedToPage.SuspendLayout();
            this.eventsInvitedToDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToWishListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToDataGridView)).BeginInit();
            this.wishlistPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishListItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myWishListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableEventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ownedEventDataGrid
            // 
            this.ownedEventDataGrid.AllowUserToAddRows = false;
            this.ownedEventDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.ownedEventDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ownedEventDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ownedEventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventDataGrid.Location = new System.Drawing.Point(6, 15);
            this.ownedEventDataGrid.MultiSelect = false;
            this.ownedEventDataGrid.Name = "ownedEventDataGrid";
            this.ownedEventDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ownedEventDataGrid.Size = new System.Drawing.Size(698, 150);
            this.ownedEventDataGrid.TabIndex = 0;
            this.ownedEventDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ownedEventDataGrid_CellClick);
            this.ownedEventDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ownedEventDataGrid_CellContentClick);
            this.ownedEventDataGrid.SelectionChanged += new System.EventHandler(this.ownedEventDataGrid_SelectionChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.saveVendorButton);
            this.tabControl.Controls.Add(this.eventInvitedToPage);
            this.tabControl.Controls.Add(this.wishlistPage);
            this.tabControl.Location = new System.Drawing.Point(2, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(773, 735);
            this.tabControl.TabIndex = 2;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // saveVendorButton
            // 
            this.saveVendorButton.Controls.Add(this.eventsOwnedTabControl);
            this.saveVendorButton.Controls.Add(this.ownedEventDataGrid);
            this.saveVendorButton.Location = new System.Drawing.Point(4, 22);
            this.saveVendorButton.Name = "saveVendorButton";
            this.saveVendorButton.Padding = new System.Windows.Forms.Padding(3);
            this.saveVendorButton.Size = new System.Drawing.Size(765, 709);
            this.saveVendorButton.TabIndex = 0;
            this.saveVendorButton.Text = "Events I Own";
            this.saveVendorButton.UseVisualStyleBackColor = true;
            this.saveVendorButton.Enter += new System.EventHandler(this.eventsIOwnPage_Enter);
            // 
            // eventsOwnedTabControl
            // 
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventDetailsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventVendorsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventLocationsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventInvitationsPage);
            this.eventsOwnedTabControl.Location = new System.Drawing.Point(7, 172);
            this.eventsOwnedTabControl.Name = "eventsOwnedTabControl";
            this.eventsOwnedTabControl.SelectedIndex = 0;
            this.eventsOwnedTabControl.Size = new System.Drawing.Size(694, 461);
            this.eventsOwnedTabControl.TabIndex = 2;
            this.eventsOwnedTabControl.Visible = false;
            this.eventsOwnedTabControl.SelectedIndexChanged += new System.EventHandler(this.eventsOwnedTabControl_SelectedIndexChanged);
            // 
            // ownedEventDetailsPage
            // 
            this.ownedEventDetailsPage.Controls.Add(this.saveOwnedEventDetailButton);
            this.ownedEventDetailsPage.Controls.Add(this.label1);
            this.ownedEventDetailsPage.Controls.Add(this.eventNameTextBox);
            this.ownedEventDetailsPage.Controls.Add(this.label2);
            this.ownedEventDetailsPage.Controls.Add(this.eventStartDateTimePicker);
            this.ownedEventDetailsPage.Controls.Add(this.label3);
            this.ownedEventDetailsPage.Controls.Add(this.eventEndDateTimePicker);
            this.ownedEventDetailsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventDetailsPage.Name = "ownedEventDetailsPage";
            this.ownedEventDetailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ownedEventDetailsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventDetailsPage.TabIndex = 0;
            this.ownedEventDetailsPage.Text = "Details";
            this.ownedEventDetailsPage.UseVisualStyleBackColor = true;
            // 
            // saveOwnedEventDetailButton
            // 
            this.saveOwnedEventDetailButton.Location = new System.Drawing.Point(84, 89);
            this.saveOwnedEventDetailButton.Name = "saveOwnedEventDetailButton";
            this.saveOwnedEventDetailButton.Size = new System.Drawing.Size(75, 23);
            this.saveOwnedEventDetailButton.TabIndex = 6;
            this.saveOwnedEventDetailButton.Text = "Save";
            this.saveOwnedEventDetailButton.UseVisualStyleBackColor = true;
            this.saveOwnedEventDetailButton.Click += new System.EventHandler(this.saveOwnedEventDetailButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(84, 10);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.eventNameTextBox.TabIndex = 3;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Start:";
            // 
            // eventStartDateTimePicker
            // 
            this.eventStartDateTimePicker.Location = new System.Drawing.Point(84, 36);
            this.eventStartDateTimePicker.Name = "eventStartDateTimePicker";
            this.eventStartDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventStartDateTimePicker.TabIndex = 4;
            this.eventStartDateTimePicker.ValueChanged += new System.EventHandler(this.eventStartDateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event End:";
            // 
            // eventEndDateTimePicker
            // 
            this.eventEndDateTimePicker.Location = new System.Drawing.Point(84, 62);
            this.eventEndDateTimePicker.Name = "eventEndDateTimePicker";
            this.eventEndDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventEndDateTimePicker.TabIndex = 5;
            this.eventEndDateTimePicker.ValueChanged += new System.EventHandler(this.eventEndDateTimePicker_ValueChanged);
            // 
            // ownedEventVendorsPage
            // 
            this.ownedEventVendorsPage.Controls.Add(this.addNewVendorPanel);
            this.ownedEventVendorsPage.Controls.Add(this.ownedEventVendorsDataGridView);
            this.ownedEventVendorsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventVendorsPage.Name = "ownedEventVendorsPage";
            this.ownedEventVendorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ownedEventVendorsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventVendorsPage.TabIndex = 1;
            this.ownedEventVendorsPage.Text = "Vendors";
            this.ownedEventVendorsPage.UseVisualStyleBackColor = true;
            this.ownedEventVendorsPage.Click += new System.EventHandler(this.ownedEventVendorsPage_Click);
            // 
            // addNewVendorPanel
            // 
            this.addNewVendorPanel.Controls.Add(this.vendorDetailPanel);
            this.addNewVendorPanel.Controls.Add(this.availableVendorsDataGridView);
            this.addNewVendorPanel.Location = new System.Drawing.Point(9, 176);
            this.addNewVendorPanel.Name = "addNewVendorPanel";
            this.addNewVendorPanel.Size = new System.Drawing.Size(671, 253);
            this.addNewVendorPanel.TabIndex = 8;
            // 
            // vendorDetailPanel
            // 
            this.vendorDetailPanel.Controls.Add(this.saveVendorBtn);
            this.vendorDetailPanel.Controls.Add(this.label4);
            this.vendorDetailPanel.Controls.Add(this.createNewVendorButton);
            this.vendorDetailPanel.Controls.Add(this.vendorRoleTextBox);
            this.vendorDetailPanel.Controls.Add(this.addVendorButton);
            this.vendorDetailPanel.Controls.Add(this.vendorNameTextBox);
            this.vendorDetailPanel.Controls.Add(this.label5);
            this.vendorDetailPanel.Location = new System.Drawing.Point(346, 15);
            this.vendorDetailPanel.Name = "vendorDetailPanel";
            this.vendorDetailPanel.Size = new System.Drawing.Size(322, 208);
            this.vendorDetailPanel.TabIndex = 7;
            // 
            // saveVendorBtn
            // 
            this.saveVendorBtn.Location = new System.Drawing.Point(190, 182);
            this.saveVendorBtn.Name = "saveVendorBtn";
            this.saveVendorBtn.Size = new System.Drawing.Size(75, 23);
            this.saveVendorBtn.TabIndex = 7;
            this.saveVendorBtn.Text = "Save";
            this.saveVendorBtn.UseVisualStyleBackColor = true;
            this.saveVendorBtn.Click += new System.EventHandler(this.saveVendorBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vendor Name:";
            // 
            // createNewVendorButton
            // 
            this.createNewVendorButton.Location = new System.Drawing.Point(109, 182);
            this.createNewVendorButton.Name = "createNewVendorButton";
            this.createNewVendorButton.Size = new System.Drawing.Size(75, 23);
            this.createNewVendorButton.TabIndex = 2;
            this.createNewVendorButton.Text = "Create New";
            this.createNewVendorButton.UseVisualStyleBackColor = true;
            this.createNewVendorButton.Click += new System.EventHandler(this.createNewVendorButton_Click);
            // 
            // vendorRoleTextBox
            // 
            this.vendorRoleTextBox.Location = new System.Drawing.Point(84, 34);
            this.vendorRoleTextBox.Name = "vendorRoleTextBox";
            this.vendorRoleTextBox.Size = new System.Drawing.Size(235, 20);
            this.vendorRoleTextBox.TabIndex = 6;
            // 
            // addVendorButton
            // 
            this.addVendorButton.Location = new System.Drawing.Point(6, 182);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(97, 23);
            this.addVendorButton.TabIndex = 1;
            this.addVendorButton.Text = "Add To Event";
            this.addVendorButton.UseVisualStyleBackColor = true;
            this.addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Location = new System.Drawing.Point(84, 8);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.vendorNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vendor Role:";
            // 
            // availableVendorsDataGridView
            // 
            this.availableVendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableVendorsDataGridView.Location = new System.Drawing.Point(13, 15);
            this.availableVendorsDataGridView.Name = "availableVendorsDataGridView";
            this.availableVendorsDataGridView.Size = new System.Drawing.Size(324, 207);
            this.availableVendorsDataGridView.TabIndex = 0;
            this.availableVendorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableVendorsDataGridView_CellClick);
            this.availableVendorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ownedEventVendorsDataGridView
            // 
            this.ownedEventVendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventVendorsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ownedEventVendorsDataGridView.Name = "ownedEventVendorsDataGridView";
            this.ownedEventVendorsDataGridView.Size = new System.Drawing.Size(674, 150);
            this.ownedEventVendorsDataGridView.TabIndex = 6;
            // 
            // ownedEventLocationsPage
            // 
            this.ownedEventLocationsPage.Controls.Add(this.availableEventDataGridView);
            this.ownedEventLocationsPage.Controls.Add(this.ownedEventLocationsDataGridView);
            this.ownedEventLocationsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventLocationsPage.Name = "ownedEventLocationsPage";
            this.ownedEventLocationsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventLocationsPage.TabIndex = 2;
            this.ownedEventLocationsPage.Text = "Locations";
            this.ownedEventLocationsPage.UseVisualStyleBackColor = true;
            // 
            // ownedEventLocationsDataGridView
            // 
            this.ownedEventLocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventLocationsDataGridView.Location = new System.Drawing.Point(18, 12);
            this.ownedEventLocationsDataGridView.Name = "ownedEventLocationsDataGridView";
            this.ownedEventLocationsDataGridView.Size = new System.Drawing.Size(653, 150);
            this.ownedEventLocationsDataGridView.TabIndex = 9;
            // 
            // ownedEventInvitationsPage
            // 
            this.ownedEventInvitationsPage.Controls.Add(this.addNewInvitationLinkLabel);
            this.ownedEventInvitationsPage.Controls.Add(this.ownedEventInvitationsDataGridView);
            this.ownedEventInvitationsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventInvitationsPage.Name = "ownedEventInvitationsPage";
            this.ownedEventInvitationsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventInvitationsPage.TabIndex = 3;
            this.ownedEventInvitationsPage.Text = "Invitations";
            this.ownedEventInvitationsPage.UseVisualStyleBackColor = true;
            // 
            // addNewInvitationLinkLabel
            // 
            this.addNewInvitationLinkLabel.AutoSize = true;
            this.addNewInvitationLinkLabel.Location = new System.Drawing.Point(318, 211);
            this.addNewInvitationLinkLabel.Name = "addNewInvitationLinkLabel";
            this.addNewInvitationLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewInvitationLinkLabel.TabIndex = 8;
            this.addNewInvitationLinkLabel.TabStop = true;
            this.addNewInvitationLinkLabel.Text = "Add New";
            this.addNewInvitationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewInvitationLinkLabel_LinkClicked);
            // 
            // ownedEventInvitationsDataGridView
            // 
            this.ownedEventInvitationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventInvitationsDataGridView.Location = new System.Drawing.Point(3, 14);
            this.ownedEventInvitationsDataGridView.Name = "ownedEventInvitationsDataGridView";
            this.ownedEventInvitationsDataGridView.Size = new System.Drawing.Size(657, 150);
            this.ownedEventInvitationsDataGridView.TabIndex = 0;
            // 
            // eventInvitedToPage
            // 
            this.eventInvitedToPage.Controls.Add(this.eventsInvitedToDetailPanel);
            this.eventInvitedToPage.Controls.Add(this.eventsInvitedToDataGridView);
            this.eventInvitedToPage.Location = new System.Drawing.Point(4, 22);
            this.eventInvitedToPage.Name = "eventInvitedToPage";
            this.eventInvitedToPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventInvitedToPage.Size = new System.Drawing.Size(765, 709);
            this.eventInvitedToPage.TabIndex = 1;
            this.eventInvitedToPage.Text = "Events I\'m Invited To";
            this.eventInvitedToPage.UseVisualStyleBackColor = true;
            // 
            // eventsInvitedToDetailPanel
            // 
            this.eventsInvitedToDetailPanel.Controls.Add(this.eventsInvitedToWishListDataGridView);
            this.eventsInvitedToDetailPanel.Controls.Add(this.eventsInvitedToInvitationPanel);
            this.eventsInvitedToDetailPanel.Location = new System.Drawing.Point(24, 208);
            this.eventsInvitedToDetailPanel.Name = "eventsInvitedToDetailPanel";
            this.eventsInvitedToDetailPanel.Size = new System.Drawing.Size(708, 376);
            this.eventsInvitedToDetailPanel.TabIndex = 1;
            // 
            // eventsInvitedToWishListDataGridView
            // 
            this.eventsInvitedToWishListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsInvitedToWishListDataGridView.Location = new System.Drawing.Point(371, 4);
            this.eventsInvitedToWishListDataGridView.Name = "eventsInvitedToWishListDataGridView";
            this.eventsInvitedToWishListDataGridView.Size = new System.Drawing.Size(334, 369);
            this.eventsInvitedToWishListDataGridView.TabIndex = 1;
            // 
            // eventsInvitedToInvitationPanel
            // 
            this.eventsInvitedToInvitationPanel.Location = new System.Drawing.Point(4, 4);
            this.eventsInvitedToInvitationPanel.Name = "eventsInvitedToInvitationPanel";
            this.eventsInvitedToInvitationPanel.Size = new System.Drawing.Size(360, 369);
            this.eventsInvitedToInvitationPanel.TabIndex = 0;
            // 
            // eventsInvitedToDataGridView
            // 
            this.eventsInvitedToDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsInvitedToDataGridView.Location = new System.Drawing.Point(24, 35);
            this.eventsInvitedToDataGridView.Name = "eventsInvitedToDataGridView";
            this.eventsInvitedToDataGridView.Size = new System.Drawing.Size(708, 150);
            this.eventsInvitedToDataGridView.TabIndex = 0;
            // 
            // wishlistPage
            // 
            this.wishlistPage.Controls.Add(this.panel1);
            this.wishlistPage.Controls.Add(this.addNewWishlistLinkLabel);
            this.wishlistPage.Controls.Add(this.myWishListDataGridView);
            this.wishlistPage.Location = new System.Drawing.Point(4, 22);
            this.wishlistPage.Name = "wishlistPage";
            this.wishlistPage.Size = new System.Drawing.Size(765, 709);
            this.wishlistPage.TabIndex = 2;
            this.wishlistPage.Text = "My Wishlists";
            this.wishlistPage.UseVisualStyleBackColor = true;
            this.wishlistPage.Click += new System.EventHandler(this.wishlistPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addNewWishlistItemLinkLabel);
            this.panel1.Controls.Add(this.wishListItemsDataGridView);
            this.panel1.Location = new System.Drawing.Point(69, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 225);
            this.panel1.TabIndex = 11;
            // 
            // addNewWishlistItemLinkLabel
            // 
            this.addNewWishlistItemLinkLabel.AutoSize = true;
            this.addNewWishlistItemLinkLabel.Location = new System.Drawing.Point(48, 15);
            this.addNewWishlistItemLinkLabel.Name = "addNewWishlistItemLinkLabel";
            this.addNewWishlistItemLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewWishlistItemLinkLabel.TabIndex = 11;
            this.addNewWishlistItemLinkLabel.TabStop = true;
            this.addNewWishlistItemLinkLabel.Text = "Add New";
            this.addNewWishlistItemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewWishlistItemLinkLabel_LinkClicked_1);
            // 
            // wishListItemsDataGridView
            // 
            this.wishListItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wishListItemsDataGridView.Location = new System.Drawing.Point(3, 31);
            this.wishListItemsDataGridView.Name = "wishListItemsDataGridView";
            this.wishListItemsDataGridView.Size = new System.Drawing.Size(643, 150);
            this.wishListItemsDataGridView.TabIndex = 10;
            // 
            // addNewWishlistLinkLabel
            // 
            this.addNewWishlistLinkLabel.AutoSize = true;
            this.addNewWishlistLinkLabel.Location = new System.Drawing.Point(346, 187);
            this.addNewWishlistLinkLabel.Name = "addNewWishlistLinkLabel";
            this.addNewWishlistLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewWishlistLinkLabel.TabIndex = 9;
            this.addNewWishlistLinkLabel.TabStop = true;
            this.addNewWishlistLinkLabel.Text = "Add New";
            this.addNewWishlistLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewWishlistLinkLabel_LinkClicked);
            // 
            // myWishListDataGridView
            // 
            this.myWishListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myWishListDataGridView.Location = new System.Drawing.Point(48, 25);
            this.myWishListDataGridView.Name = "myWishListDataGridView";
            this.myWishListDataGridView.Size = new System.Drawing.Size(623, 150);
            this.myWishListDataGridView.TabIndex = 1;
            this.myWishListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myWishListDataGridView_CellClick);
            this.myWishListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myWishListDataGridView_CellContentClick);
            // 
            // availableEventDataGridView
            // 
            this.availableEventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableEventDataGridView.Location = new System.Drawing.Point(18, 201);
            this.availableEventDataGridView.Name = "availableEventDataGridView";
            this.availableEventDataGridView.Size = new System.Drawing.Size(349, 212);
            this.availableEventDataGridView.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 752);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "EventPlanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.saveVendorButton.ResumeLayout(false);
            this.eventsOwnedTabControl.ResumeLayout(false);
            this.ownedEventDetailsPage.ResumeLayout(false);
            this.ownedEventDetailsPage.PerformLayout();
            this.ownedEventVendorsPage.ResumeLayout(false);
            this.addNewVendorPanel.ResumeLayout(false);
            this.vendorDetailPanel.ResumeLayout(false);
            this.vendorDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableVendorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventVendorsDataGridView)).EndInit();
            this.ownedEventLocationsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventLocationsDataGridView)).EndInit();
            this.ownedEventInvitationsPage.ResumeLayout(false);
            this.ownedEventInvitationsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventInvitationsDataGridView)).EndInit();
            this.eventInvitedToPage.ResumeLayout(false);
            this.eventsInvitedToDetailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToWishListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToDataGridView)).EndInit();
            this.wishlistPage.ResumeLayout(false);
            this.wishlistPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wishListItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myWishListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableEventDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ownedEventDataGrid;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage saveVendorButton;
        private System.Windows.Forms.DataGridView ownedEventLocationsDataGridView;
        private System.Windows.Forms.DataGridView ownedEventVendorsDataGridView;
        private System.Windows.Forms.DateTimePicker eventEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker eventStartDateTimePicker;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage eventInvitedToPage;
        private System.Windows.Forms.TabControl eventsOwnedTabControl;
        private System.Windows.Forms.TabPage ownedEventDetailsPage;
        private System.Windows.Forms.TabPage ownedEventVendorsPage;
        private System.Windows.Forms.TabPage ownedEventLocationsPage;
        private System.Windows.Forms.TabPage ownedEventInvitationsPage;
        private System.Windows.Forms.DataGridView ownedEventInvitationsDataGridView;
        private System.Windows.Forms.Button saveOwnedEventDetailButton;
        private System.Windows.Forms.Panel eventsInvitedToDetailPanel;
        private System.Windows.Forms.DataGridView eventsInvitedToWishListDataGridView;
        private System.Windows.Forms.Panel eventsInvitedToInvitationPanel;
        private System.Windows.Forms.DataGridView eventsInvitedToDataGridView;
        private System.Windows.Forms.LinkLabel addNewInvitationLinkLabel;
        private System.Windows.Forms.TabPage wishlistPage;
        private System.Windows.Forms.DataGridView myWishListDataGridView;
        private System.Windows.Forms.LinkLabel addNewWishlistLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel addNewWishlistItemLinkLabel;
        private System.Windows.Forms.DataGridView wishListItemsDataGridView;
        private System.Windows.Forms.Panel addNewVendorPanel;
        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.DataGridView availableVendorsDataGridView;
        private System.Windows.Forms.Button createNewVendorButton;
        private System.Windows.Forms.TextBox vendorRoleTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel vendorDetailPanel;
        private System.Windows.Forms.Button saveVendorBtn;
        private System.Windows.Forms.DataGridView availableEventDataGridView;
    }
}


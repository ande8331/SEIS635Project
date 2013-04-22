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
            this.eventsIOwnPage = new System.Windows.Forms.TabPage();
            this.eventInvitedToPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ownedEventVendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.ownedEventLocationsDataGridView = new System.Windows.Forms.DataGridView();
            this.eventsOwnedTabControl = new System.Windows.Forms.TabControl();
            this.ownedEventDetailsPage = new System.Windows.Forms.TabPage();
            this.ownedEventVendorsPage = new System.Windows.Forms.TabPage();
            this.ownedEventLocationsPage = new System.Windows.Forms.TabPage();
            this.ownedEventInvitationsPage = new System.Windows.Forms.TabPage();
            this.ownedEventWishListPage = new System.Windows.Forms.TabPage();
            this.ownedEventInvitationsDataGridView = new System.Windows.Forms.DataGridView();
            this.ownedEventWishListDataGridView = new System.Windows.Forms.DataGridView();
            this.saveOwnedEventDetailButton = new System.Windows.Forms.Button();
            this.eventsInvitedToDataGridView = new System.Windows.Forms.DataGridView();
            this.eventsInvitedToDetailPanel = new System.Windows.Forms.Panel();
            this.eventsInvitedToInvitationPanel = new System.Windows.Forms.Panel();
            this.eventsInvitedToWishListDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewVendorLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addNewLocationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addNewInvitationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addNewWishListItemLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.eventsIOwnPage.SuspendLayout();
            this.eventInvitedToPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventVendorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventLocationsDataGridView)).BeginInit();
            this.eventsOwnedTabControl.SuspendLayout();
            this.ownedEventDetailsPage.SuspendLayout();
            this.ownedEventVendorsPage.SuspendLayout();
            this.ownedEventLocationsPage.SuspendLayout();
            this.ownedEventInvitationsPage.SuspendLayout();
            this.ownedEventWishListPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventInvitationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventWishListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToDataGridView)).BeginInit();
            this.eventsInvitedToDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToWishListDataGridView)).BeginInit();
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
            this.tabControl.Controls.Add(this.eventsIOwnPage);
            this.tabControl.Controls.Add(this.eventInvitedToPage);
            this.tabControl.Location = new System.Drawing.Point(2, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(773, 735);
            this.tabControl.TabIndex = 2;
            // 
            // eventsIOwnPage
            // 
            this.eventsIOwnPage.Controls.Add(this.eventsOwnedTabControl);
            this.eventsIOwnPage.Controls.Add(this.ownedEventDataGrid);
            this.eventsIOwnPage.Location = new System.Drawing.Point(4, 22);
            this.eventsIOwnPage.Name = "eventsIOwnPage";
            this.eventsIOwnPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventsIOwnPage.Size = new System.Drawing.Size(765, 709);
            this.eventsIOwnPage.TabIndex = 0;
            this.eventsIOwnPage.Text = "Events I Own";
            this.eventsIOwnPage.UseVisualStyleBackColor = true;
            this.eventsIOwnPage.Enter += new System.EventHandler(this.eventsIOwnPage_Enter);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event End:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(84, 10);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.eventNameTextBox.TabIndex = 3;
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // eventStartDateTimePicker
            // 
            this.eventStartDateTimePicker.Location = new System.Drawing.Point(84, 36);
            this.eventStartDateTimePicker.Name = "eventStartDateTimePicker";
            this.eventStartDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventStartDateTimePicker.TabIndex = 4;
            this.eventStartDateTimePicker.ValueChanged += new System.EventHandler(this.eventStartDateTimePicker_ValueChanged);
            // 
            // eventEndDateTimePicker
            // 
            this.eventEndDateTimePicker.Location = new System.Drawing.Point(84, 62);
            this.eventEndDateTimePicker.Name = "eventEndDateTimePicker";
            this.eventEndDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventEndDateTimePicker.TabIndex = 5;
            this.eventEndDateTimePicker.ValueChanged += new System.EventHandler(this.eventEndDateTimePicker_ValueChanged);
            // 
            // ownedEventVendorsDataGridView
            // 
            this.ownedEventVendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventVendorsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.ownedEventVendorsDataGridView.Name = "ownedEventVendorsDataGridView";
            this.ownedEventVendorsDataGridView.Size = new System.Drawing.Size(316, 150);
            this.ownedEventVendorsDataGridView.TabIndex = 6;
            // 
            // ownedEventLocationsDataGridView
            // 
            this.ownedEventLocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventLocationsDataGridView.Location = new System.Drawing.Point(18, 12);
            this.ownedEventLocationsDataGridView.Name = "ownedEventLocationsDataGridView";
            this.ownedEventLocationsDataGridView.Size = new System.Drawing.Size(332, 150);
            this.ownedEventLocationsDataGridView.TabIndex = 9;
            // 
            // eventsOwnedTabControl
            // 
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventDetailsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventVendorsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventLocationsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventInvitationsPage);
            this.eventsOwnedTabControl.Controls.Add(this.ownedEventWishListPage);
            this.eventsOwnedTabControl.Location = new System.Drawing.Point(7, 172);
            this.eventsOwnedTabControl.Name = "eventsOwnedTabControl";
            this.eventsOwnedTabControl.SelectedIndex = 0;
            this.eventsOwnedTabControl.Size = new System.Drawing.Size(694, 461);
            this.eventsOwnedTabControl.TabIndex = 2;
            this.eventsOwnedTabControl.Visible = false;
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
            // ownedEventVendorsPage
            // 
            this.ownedEventVendorsPage.Controls.Add(this.addNewVendorLinkLabel);
            this.ownedEventVendorsPage.Controls.Add(this.ownedEventVendorsDataGridView);
            this.ownedEventVendorsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventVendorsPage.Name = "ownedEventVendorsPage";
            this.ownedEventVendorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ownedEventVendorsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventVendorsPage.TabIndex = 1;
            this.ownedEventVendorsPage.Text = "Vendors";
            this.ownedEventVendorsPage.UseVisualStyleBackColor = true;
            // 
            // ownedEventLocationsPage
            // 
            this.ownedEventLocationsPage.Controls.Add(this.addNewLocationLinkLabel);
            this.ownedEventLocationsPage.Controls.Add(this.ownedEventLocationsDataGridView);
            this.ownedEventLocationsPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventLocationsPage.Name = "ownedEventLocationsPage";
            this.ownedEventLocationsPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventLocationsPage.TabIndex = 2;
            this.ownedEventLocationsPage.Text = "Locations";
            this.ownedEventLocationsPage.UseVisualStyleBackColor = true;
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
            // ownedEventWishListPage
            // 
            this.ownedEventWishListPage.Controls.Add(this.addNewWishListItemLinkLabel);
            this.ownedEventWishListPage.Controls.Add(this.ownedEventWishListDataGridView);
            this.ownedEventWishListPage.Location = new System.Drawing.Point(4, 22);
            this.ownedEventWishListPage.Name = "ownedEventWishListPage";
            this.ownedEventWishListPage.Size = new System.Drawing.Size(686, 435);
            this.ownedEventWishListPage.TabIndex = 4;
            this.ownedEventWishListPage.Text = "Wish List";
            this.ownedEventWishListPage.UseVisualStyleBackColor = true;
            // 
            // ownedEventInvitationsDataGridView
            // 
            this.ownedEventInvitationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventInvitationsDataGridView.Location = new System.Drawing.Point(3, 14);
            this.ownedEventInvitationsDataGridView.Name = "ownedEventInvitationsDataGridView";
            this.ownedEventInvitationsDataGridView.Size = new System.Drawing.Size(657, 150);
            this.ownedEventInvitationsDataGridView.TabIndex = 0;
            // 
            // ownedEventWishListDataGridView
            // 
            this.ownedEventWishListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventWishListDataGridView.Location = new System.Drawing.Point(15, 16);
            this.ownedEventWishListDataGridView.Name = "ownedEventWishListDataGridView";
            this.ownedEventWishListDataGridView.Size = new System.Drawing.Size(623, 150);
            this.ownedEventWishListDataGridView.TabIndex = 0;
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
            // eventsInvitedToDataGridView
            // 
            this.eventsInvitedToDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsInvitedToDataGridView.Location = new System.Drawing.Point(24, 35);
            this.eventsInvitedToDataGridView.Name = "eventsInvitedToDataGridView";
            this.eventsInvitedToDataGridView.Size = new System.Drawing.Size(708, 150);
            this.eventsInvitedToDataGridView.TabIndex = 0;
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
            // eventsInvitedToInvitationPanel
            // 
            this.eventsInvitedToInvitationPanel.Location = new System.Drawing.Point(4, 4);
            this.eventsInvitedToInvitationPanel.Name = "eventsInvitedToInvitationPanel";
            this.eventsInvitedToInvitationPanel.Size = new System.Drawing.Size(360, 369);
            this.eventsInvitedToInvitationPanel.TabIndex = 0;
            // 
            // eventsInvitedToWishListDataGridView
            // 
            this.eventsInvitedToWishListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsInvitedToWishListDataGridView.Location = new System.Drawing.Point(371, 4);
            this.eventsInvitedToWishListDataGridView.Name = "eventsInvitedToWishListDataGridView";
            this.eventsInvitedToWishListDataGridView.Size = new System.Drawing.Size(334, 369);
            this.eventsInvitedToWishListDataGridView.TabIndex = 1;
            // 
            // addNewVendorLinkLabel
            // 
            this.addNewVendorLinkLabel.AutoSize = true;
            this.addNewVendorLinkLabel.Location = new System.Drawing.Point(172, 198);
            this.addNewVendorLinkLabel.Name = "addNewVendorLinkLabel";
            this.addNewVendorLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewVendorLinkLabel.TabIndex = 7;
            this.addNewVendorLinkLabel.TabStop = true;
            this.addNewVendorLinkLabel.Text = "Add New";
            this.addNewVendorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewVendorLinkLabel_LinkClicked);
            // 
            // addNewLocationLinkLabel
            // 
            this.addNewLocationLinkLabel.AutoSize = true;
            this.addNewLocationLinkLabel.Location = new System.Drawing.Point(318, 211);
            this.addNewLocationLinkLabel.Name = "addNewLocationLinkLabel";
            this.addNewLocationLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewLocationLinkLabel.TabIndex = 10;
            this.addNewLocationLinkLabel.TabStop = true;
            this.addNewLocationLinkLabel.Text = "Add New";
            this.addNewLocationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLocationLinkLabel_LinkClicked);
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
            // addNewWishListItemLinkLabel
            // 
            this.addNewWishListItemLinkLabel.AutoSize = true;
            this.addNewWishListItemLinkLabel.Location = new System.Drawing.Point(318, 211);
            this.addNewWishListItemLinkLabel.Name = "addNewWishListItemLinkLabel";
            this.addNewWishListItemLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.addNewWishListItemLinkLabel.TabIndex = 8;
            this.addNewWishListItemLinkLabel.TabStop = true;
            this.addNewWishListItemLinkLabel.Text = "Add New";
            this.addNewWishListItemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewWishListItemLinkLabel_LinkClicked);
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
            this.eventsIOwnPage.ResumeLayout(false);
            this.eventInvitedToPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventVendorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventLocationsDataGridView)).EndInit();
            this.eventsOwnedTabControl.ResumeLayout(false);
            this.ownedEventDetailsPage.ResumeLayout(false);
            this.ownedEventDetailsPage.PerformLayout();
            this.ownedEventVendorsPage.ResumeLayout(false);
            this.ownedEventVendorsPage.PerformLayout();
            this.ownedEventLocationsPage.ResumeLayout(false);
            this.ownedEventLocationsPage.PerformLayout();
            this.ownedEventInvitationsPage.ResumeLayout(false);
            this.ownedEventInvitationsPage.PerformLayout();
            this.ownedEventWishListPage.ResumeLayout(false);
            this.ownedEventWishListPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventInvitationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventWishListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToDataGridView)).EndInit();
            this.eventsInvitedToDetailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsInvitedToWishListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ownedEventDataGrid;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage eventsIOwnPage;
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
        private System.Windows.Forms.TabPage ownedEventWishListPage;
        private System.Windows.Forms.DataGridView ownedEventWishListDataGridView;
        private System.Windows.Forms.Button saveOwnedEventDetailButton;
        private System.Windows.Forms.Panel eventsInvitedToDetailPanel;
        private System.Windows.Forms.DataGridView eventsInvitedToWishListDataGridView;
        private System.Windows.Forms.Panel eventsInvitedToInvitationPanel;
        private System.Windows.Forms.DataGridView eventsInvitedToDataGridView;
        private System.Windows.Forms.LinkLabel addNewVendorLinkLabel;
        private System.Windows.Forms.LinkLabel addNewLocationLinkLabel;
        private System.Windows.Forms.LinkLabel addNewInvitationLinkLabel;
        private System.Windows.Forms.LinkLabel addNewWishListItemLinkLabel;
    }
}


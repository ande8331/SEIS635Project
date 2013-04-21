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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.eventsIOwnPage.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // ownedEventDataGrid
            // 
            this.ownedEventDataGrid.AllowUserToAddRows = false;
            this.ownedEventDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.ownedEventDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ownedEventDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ownedEventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventDataGrid.Location = new System.Drawing.Point(6, 15);
            this.ownedEventDataGrid.MultiSelect = false;
            this.ownedEventDataGrid.Name = "ownedEventDataGrid";
            this.ownedEventDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ownedEventDataGrid.Size = new System.Drawing.Size(698, 150);
            this.ownedEventDataGrid.TabIndex = 0;
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
            this.eventInvitedToPage.Location = new System.Drawing.Point(4, 22);
            this.eventInvitedToPage.Name = "eventInvitedToPage";
            this.eventInvitedToPage.Padding = new System.Windows.Forms.Padding(3);
            this.eventInvitedToPage.Size = new System.Drawing.Size(765, 121);
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
            // 
            // eventStartDateTimePicker
            // 
            this.eventStartDateTimePicker.Location = new System.Drawing.Point(84, 36);
            this.eventStartDateTimePicker.Name = "eventStartDateTimePicker";
            this.eventStartDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventStartDateTimePicker.TabIndex = 4;
            // 
            // eventEndDateTimePicker
            // 
            this.eventEndDateTimePicker.Location = new System.Drawing.Point(84, 62);
            this.eventEndDateTimePicker.Name = "eventEndDateTimePicker";
            this.eventEndDateTimePicker.Size = new System.Drawing.Size(250, 20);
            this.eventEndDateTimePicker.TabIndex = 5;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 752);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "EventPlanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.eventsIOwnPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventVendorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventLocationsDataGridView)).EndInit();
            this.eventsOwnedTabControl.ResumeLayout(false);
            this.ownedEventDetailsPage.ResumeLayout(false);
            this.ownedEventDetailsPage.PerformLayout();
            this.ownedEventVendorsPage.ResumeLayout(false);
            this.ownedEventLocationsPage.ResumeLayout(false);
            this.ownedEventInvitationsPage.ResumeLayout(false);
            this.ownedEventWishListPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventInvitationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventWishListDataGridView)).EndInit();
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
    }
}


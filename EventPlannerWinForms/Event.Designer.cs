namespace EventPlannerWinForms
{
    partial class Event
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.vendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.addNewVendorLink = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.locationsDataGridView = new System.Windows.Forms.DataGridView();
            this.addNewLocationLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Event End:";
            // 
            // eventStartDateTimePicker
            // 
            this.eventStartDateTimePicker.Location = new System.Drawing.Point(89, 48);
            this.eventStartDateTimePicker.Name = "eventStartDateTimePicker";
            this.eventStartDateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.eventStartDateTimePicker.TabIndex = 3;
            // 
            // eventEndDateTimePicker
            // 
            this.eventEndDateTimePicker.Location = new System.Drawing.Point(89, 74);
            this.eventEndDateTimePicker.Name = "eventEndDateTimePicker";
            this.eventEndDateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.eventEndDateTimePicker.TabIndex = 4;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(89, 22);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(242, 20);
            this.eventNameTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(124, 538);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 537);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // vendorsDataGridView
            // 
            this.vendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsDataGridView.Location = new System.Drawing.Point(16, 329);
            this.vendorsDataGridView.Name = "vendorsDataGridView";
            this.vendorsDataGridView.Size = new System.Drawing.Size(416, 159);
            this.vendorsDataGridView.TabIndex = 8;
            this.vendorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorsDataGridView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vendors For This Event:";
            // 
            // addNewVendorLink
            // 
            this.addNewVendorLink.AutoSize = true;
            this.addNewVendorLink.Location = new System.Drawing.Point(140, 313);
            this.addNewVendorLink.Name = "addNewVendorLink";
            this.addNewVendorLink.Size = new System.Drawing.Size(88, 13);
            this.addNewVendorLink.TabIndex = 10;
            this.addNewVendorLink.TabStop = true;
            this.addNewVendorLink.Text = "Add New Vendor";
            this.addNewVendorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewVendorLink_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Locations For This Event:";
            // 
            // locationsDataGridView
            // 
            this.locationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsDataGridView.Location = new System.Drawing.Point(20, 124);
            this.locationsDataGridView.Name = "locationsDataGridView";
            this.locationsDataGridView.Size = new System.Drawing.Size(412, 150);
            this.locationsDataGridView.TabIndex = 12;
            this.locationsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.locationsDataGridView_CellContentClick);
            // 
            // addNewLocationLink
            // 
            this.addNewLocationLink.AutoSize = true;
            this.addNewLocationLink.Location = new System.Drawing.Point(152, 108);
            this.addNewLocationLink.Name = "addNewLocationLink";
            this.addNewLocationLink.Size = new System.Drawing.Size(95, 13);
            this.addNewLocationLink.TabIndex = 13;
            this.addNewLocationLink.TabStop = true;
            this.addNewLocationLink.Text = "Add New Location";
            this.addNewLocationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addNewLocationLink_LinkClicked);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 600);
            this.Controls.Add(this.addNewLocationLink);
            this.Controls.Add(this.locationsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addNewVendorLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vendorsDataGridView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventEndDateTimePicker);
            this.Controls.Add(this.eventStartDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Event";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker eventStartDateTimePicker;
        private System.Windows.Forms.DateTimePicker eventEndDateTimePicker;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridView vendorsDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel addNewVendorLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView locationsDataGridView;
        private System.Windows.Forms.LinkLabel addNewLocationLink;
    }
}
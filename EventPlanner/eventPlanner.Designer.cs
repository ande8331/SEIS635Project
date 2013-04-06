namespace EventPlanner
{
    partial class eventPlanner
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eventPlannerAccessDBDataSet = new EventPlanner.eventPlannerAccessDBDataSet();
            this.eventPlannerAccessDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownedEventsLabel = new System.Windows.Forms.Label();
            this.eventsInvitedToLabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPlannerAccessDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPlannerAccessDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.iDDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "event";
            this.dataGridView1.DataSource = this.eventPlannerAccessDBDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(832, 135);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eventPlannerAccessDBDataSet
            // 
            this.eventPlannerAccessDBDataSet.DataSetName = "eventPlannerAccessDBDataSet";
            this.eventPlannerAccessDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventPlannerAccessDBDataSetBindingSource
            // 
            this.eventPlannerAccessDBDataSetBindingSource.DataSource = this.eventPlannerAccessDBDataSet;
            this.eventPlannerAccessDBDataSetBindingSource.Position = 0;
            // 
            // ownedEventsLabel
            // 
            this.ownedEventsLabel.AutoSize = true;
            this.ownedEventsLabel.Location = new System.Drawing.Point(26, 64);
            this.ownedEventsLabel.Name = "ownedEventsLabel";
            this.ownedEventsLabel.Size = new System.Drawing.Size(74, 13);
            this.ownedEventsLabel.TabIndex = 1;
            this.ownedEventsLabel.Text = "Events I Own:";
            // 
            // eventsInvitedToLabel
            // 
            this.eventsInvitedToLabel.AutoSize = true;
            this.eventsInvitedToLabel.Location = new System.Drawing.Point(29, 247);
            this.eventsInvitedToLabel.Name = "eventsInvitedToLabel";
            this.eventsInvitedToLabel.Size = new System.Drawing.Size(110, 13);
            this.eventsInvitedToLabel.TabIndex = 2;
            this.eventsInvitedToLabel.Text = "Events I\'m Invited To:";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "eventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "eventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            this.eventNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            this.startDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            this.endDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "owner";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 403);
            this.Controls.Add(this.eventsInvitedToLabel);
            this.Controls.Add(this.ownedEventsLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "eventPlanner";
            this.Text = "Event Planner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPlannerAccessDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPlannerAccessDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eventPlannerAccessDBDataSetBindingSource;
        private eventPlannerAccessDBDataSet eventPlannerAccessDBDataSet;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ownedEventsLabel;
        private System.Windows.Forms.Label eventsInvitedToLabel;
    }
}


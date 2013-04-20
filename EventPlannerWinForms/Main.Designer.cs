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
            this.ownedEventDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ownedEventDataGrid
            // 
            this.ownedEventDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownedEventDataGrid.Location = new System.Drawing.Point(44, 99);
            this.ownedEventDataGrid.Name = "ownedEventDataGrid";
            this.ownedEventDataGrid.Size = new System.Drawing.Size(698, 150);
            this.ownedEventDataGrid.TabIndex = 0;
            this.ownedEventDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ownedEventDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events I Own";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ownedEventDataGrid);
            this.Name = "Main";
            this.Text = "EventPlanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownedEventDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ownedEventDataGrid;
        private System.Windows.Forms.Label label1;
    }
}


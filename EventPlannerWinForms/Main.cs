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
            ownedEventDataGrid.RowHeadersVisible = false;

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
                Event popUpWindow = new Event(Convert.ToInt32(ownedEventDataGrid[0, e.RowIndex].Value));
                popUpWindow.ShowDialog();
                clearAndLoadEventsIOwn();
            }
        }

        private void ownedEventDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            ownedEventDataGrid.CurrentRow.Selected = false;
        }
    }
}

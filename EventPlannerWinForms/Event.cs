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
    public partial class Event : Form
    {
        private int _eventPK;

        public Event(int eventPK)
        {
            _eventPK = eventPK;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);

            eventPlannerAccessDBDataSet.eventRow myRow = data.FindByID(_eventPK);
            myRow.eventName = eventNameTextBox.Text;
            myRow.start = eventStartDateTimePicker.Value;
            myRow.end = eventEndDateTimePicker.Value;
            myadapter.Update(myRow);
        }

        private void Event_Load(object sender, EventArgs e)
        {
            eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventTableAdapter();
            eventPlannerAccessDBDataSet.eventDataTable data = new eventPlannerAccessDBDataSet.eventDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.eventRow myRow = data.FindByID(_eventPK);
            eventNameTextBox.Text = myRow.eventName;
            eventStartDateTimePicker.Value = myRow.start;
            eventEndDateTimePicker.Value = myRow.end;
        }
    }
}

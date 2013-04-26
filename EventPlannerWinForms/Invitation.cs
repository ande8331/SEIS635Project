using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class Invitation
    {
        public int eventFK { get; set; }
        public int userFK { get; set; }
        public String invitationText { get; set; }
        public int invitationPK { get; private set; }

        public static List<Invitation> getInvitationsBelongingToEvent(int eventPK)
        {
            List<Invitation> returnVar = new List<Invitation>();

            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedInvitationAndUserTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedInvitationAndUserTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedInvitationAndUserDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedInvitationAndUserDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["eventFK"].Equals(eventPK))
                {
                    //Invitation myVendor = new Invitation (Convert.ToInt32(data.Rows[i]["invitation_ID"]));
                    Invitation myInvitation = new Invitation();
                    myInvitation.invitationPK = Convert.ToInt32(data.Rows[i]["invitation_ID"]);
                    myInvitation.eventFK = Convert.ToInt32(data.Rows[i]["eventFK"]);
                    myInvitation.userFK = Convert.ToInt32(data.Rows[i]["user_ID"]);
                    myInvitation.invitationText = Convert.ToString(data.Rows[i]["invitationText"]);
                    returnVar.Add(myInvitation);
                }
            }
            return returnVar;
        }

        public static List<Invitation> getInvitationsForUser(int userPK)
        {
            List<Invitation> returnVar = new List<Invitation>();

            eventPlannerAccessDBDataSetTableAdapters.eventsJoinedInvitationAndUserTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedInvitationAndUserTableAdapter();
            eventPlannerAccessDBDataSet.eventsJoinedInvitationAndUserDataTable data = new eventPlannerAccessDBDataSet.eventsJoinedInvitationAndUserDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["user_ID"].Equals(userPK))
                {
                    //Invitation myVendor = new Invitation (Convert.ToInt32(data.Rows[i]["invitation_ID"]));
                    Invitation myInvitation = new Invitation();
                    myInvitation.invitationPK = Convert.ToInt32(data.Rows[i]["invitation_ID"]);
                    myInvitation.eventFK = Convert.ToInt32(data.Rows[i]["eventFK"]);
                    myInvitation.userFK = Convert.ToInt32(data.Rows[i]["user_ID"]);
                    myInvitation.invitationText = Convert.ToString(data.Rows[i]["invitationText"]);
                    returnVar.Add(myInvitation);
                }
            }
            return returnVar;
        }

        public Invitation()
        {
        }

        public Invitation(int _invitatationPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter();
            eventPlannerAccessDBDataSet.invitationDataTable data = new eventPlannerAccessDBDataSet.invitationDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.invitationRow row = data.FindByID(_invitatationPK);
            if (data.Rows.Count > 0)
            {
                invitationPK = Convert.ToInt32(row["ID"]);
                eventFK = Convert.ToInt32(row["eventFK"]);
                userFK = Convert.ToInt32(row["userFK"]);
                invitationText = Convert.ToString(row["invitationText"]);
            }
        }
    }
}

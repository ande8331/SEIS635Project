using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class User
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String userName { get; set; }
        public int userPK { get; private set; }

        public User()
        {

        }

        public User(int _userPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.userTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.userTableAdapter();
            eventPlannerAccessDBDataSet.userDataTable data = new eventPlannerAccessDBDataSet.userDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.userRow row = data.FindByID(_userPK);
            if (row != null)
            {
                userPK = Convert.ToInt32(row["ID"]);
                firstName = Convert.ToString(row["firstName"]);
                lastName = Convert.ToString(row["lastName"]);
                email = Convert.ToString(row["email"]);
            }
        }


        public void SaveUserChanges()
        {
            eventPlannerAccessDBDataSetTableAdapters.userTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.userTableAdapter();
            eventPlannerAccessDBDataSet.userDataTable data = new eventPlannerAccessDBDataSet.userDataTable();
            myadapter.Fill(data);
            if (userPK != 0)
            {
                eventPlannerAccessDBDataSet.userRow temp = data.FindByID(userPK);
                temp["firstName"] = firstName;
                temp["lastName"] = lastName;
                temp["email"] = email;
                myadapter.Update(temp);
            }
            else
            {
                myadapter.Insert(firstName, lastName, email, userName);
                eventPlannerAccessDBDataSet.userDataTable userData = new eventPlannerAccessDBDataSet.userDataTable();
                myadapter.Fill(userData);
                this.userPK = Convert.ToInt32(userData.Rows[userData.Rows.Count - 1]["ID"]);
            }
        }

        public void AddUserToEvent(int eventPK, string invitationText)
        {
            eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter();
            eventPlannerAccessDBDataSet.invitationDataTable data = new eventPlannerAccessDBDataSet.invitationDataTable();
            myadapter.Insert(eventPK, invitationText, userPK);
        }

        public static List<User> getUsersNotBelongingToEvent(int eventPK)
        {
            List<User> returnVar = new List<User>();

            eventPlannerAccessDBDataSetTableAdapters.userTableAdapter userAdapter = new eventPlannerAccessDBDataSetTableAdapters.userTableAdapter();
            eventPlannerAccessDBDataSet.userDataTable userData = new eventPlannerAccessDBDataSet.userDataTable();
            userAdapter.Fill(userData);

            for (int i = 0; i < userData.Rows.Count; i++)
            {
                User myUser = new User(Convert.ToInt32(userData.Rows[i]["ID"]));
                returnVar.Add(myUser);
            }

            eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.invitationTableAdapter();
            eventPlannerAccessDBDataSet.invitationDataTable data = new eventPlannerAccessDBDataSet.invitationDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["eventFK"].Equals(eventPK))
                {
                    for (int j = 0; j < returnVar.Count; j++)
                    {
                        if (returnVar[j].userPK == Convert.ToInt32(data.Rows[i]["userFK"]))
                        {
                            returnVar.RemoveAt(j);
                            break;
                        }
                    }
                }
            }

            return returnVar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class WishList
    {
        public int userFK {get; set;}
        public String wishlistName { get; set; }
        public int wishlistPK { get; set; }

        public static List<WishList> getWishlistsForOwner(int ownerPK)
        {
            List<WishList> returnVar = new List<WishList>();

            eventPlannerAccessDBDataSetTableAdapters.wishlistTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.wishlistTableAdapter();
            eventPlannerAccessDBDataSet.wishlistDataTable data = new eventPlannerAccessDBDataSet.wishlistDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["userFK"].Equals(ownerPK))
                {
                    WishList myWishlist = new WishList(Convert.ToInt32(data.Rows[i]["ID"]));
                    returnVar.Add(myWishlist);
                }
            }
            return returnVar;
        }

        public WishList(eventPlannerAccessDBDataSet.locationRow row)
        {
            wishlistPK = Convert.ToInt32(row["ID"]);
            userFK = Convert.ToInt32(row["userFK"]);
            wishlistName = Convert.ToString(row["wishlistName"]);
        }

        public WishList(int _wishlistPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.wishlistTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.wishlistTableAdapter();
            eventPlannerAccessDBDataSet.wishlistDataTable data = new eventPlannerAccessDBDataSet.wishlistDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.wishlistRow row = data.FindByID(_wishlistPK);
            if (data.Rows.Count > 0)
            {
                wishlistPK = Convert.ToInt32(row["ID"]);
                userFK = Convert.ToInt32(row["userFK"]);
                wishlistName = Convert.ToString(row["wishlistName"]);
            }
        }
    }
}

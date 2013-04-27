using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class GiftItem
    {
        public String giftItemUPC { get; set; }
        public String giftItemName { get; set; }
        public double giftItemCost { get; set; }
        public int giftItemPK { get; private set; }

        public static List<GiftItem> getGiftItemsBelongingToWishList(int wishlistPK)
        {
            List<GiftItem> returnVar = new List<GiftItem>();

            eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter();
            // eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.eventsJoinedVendorsTableAdapter();
            eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable data = new eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["wishlistFK"].Equals(wishlistPK))
                {
                    GiftItem myItem = new GiftItem(Convert.ToInt32(data.Rows[i]["itemFK"]));
                    returnVar.Add(myItem);
                }
            }
            return returnVar;
        }

        public GiftItem(int _giftitemPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.itemTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.itemTableAdapter();
            eventPlannerAccessDBDataSet.itemDataTable data = new eventPlannerAccessDBDataSet.itemDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.itemRow row = data.FindByID(_giftitemPK);
            if (data.Rows.Count > 0)
            {
                giftItemPK = Convert.ToInt32(row["ID"]);
                giftItemName = Convert.ToString(row["itemName"]);
                giftItemUPC = Convert.ToString(row["itemUPC"]);
                giftItemCost = Convert.ToDouble(row["itemCost"]);
            }
        }

    }
}

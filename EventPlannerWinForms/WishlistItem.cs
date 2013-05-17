using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlannerWinForms
{
    class WishlistItem
    {
        public int wishlistFK { get; set; }
        public int itemFK { get; set; }
        public int requestedQty { get; set; }
        public int purchasedQty { get; set; }
        public int wishlistItemPK { get; private set; }
        public GiftItem giftItem { get; set; }

        public static List<WishlistItem> getWishlistEntries(int wishlistPK)
        {
            List<WishlistItem> returnVar = new List<WishlistItem>();

            eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter();
            eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable data = new eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable();
            myadapter.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i]["wishlistFK"].Equals(wishlistPK))
                {
                    WishlistItem myWishlistItem = new WishlistItem();
                    myWishlistItem.wishlistItemPK = Convert.ToInt32(data.Rows[i]["ID"]);
                    myWishlistItem.wishlistFK = Convert.ToInt32(data.Rows[i]["wishlistFK"]);
                    myWishlistItem.itemFK = Convert.ToInt32(data.Rows[i]["itemFK"]);
                    myWishlistItem.requestedQty = Convert.ToInt32(data.Rows[i]["requestedQty"]);
                    myWishlistItem.purchasedQty = Convert.ToInt32(data.Rows[i]["purchasedQty"]);
                    GiftItem myItem = new GiftItem(Convert.ToInt32(data.Rows[i]["itemFK"]));
                    myWishlistItem.giftItem = myItem;
                    returnVar.Add(myWishlistItem);
                }
            }
            return returnVar;
        }

        public WishlistItem()
        {
        }

        public WishlistItem(int _wishlistItemPK)
        {
            eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter myadapter = new eventPlannerAccessDBDataSetTableAdapters.wishlistToItemAssociationTableAdapter();
            eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable data = new eventPlannerAccessDBDataSet.wishlistToItemAssociationDataTable();
            myadapter.Fill(data);
            eventPlannerAccessDBDataSet.wishlistToItemAssociationRow row = data.FindByID(_wishlistItemPK);
            if (data.Rows.Count > 0)
            {
                wishlistItemPK = Convert.ToInt32(row["ID"]);
                wishlistFK = Convert.ToInt32(row["wishlistFK"]);
                itemFK = Convert.ToInt32(row["itemFK"]);
                requestedQty = Convert.ToInt32(row["requestedQty"]);
                purchasedQty = Convert.ToInt32(row["purchasedQty"]);
                GiftItem myItem = new GiftItem(Convert.ToInt32(row["itemFK"]));
                giftItem = myItem;
            }
        }
    }
}

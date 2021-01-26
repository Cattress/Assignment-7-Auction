using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_7_Auction
{
    class Items
    {
        private string ItemDesc;
        private double RsrvPrice;
        private double HighestBid;
        private int BidderID;
    }

    public SetDesc(string ItemDesc)
    {
        this.ItemDesc = ItemDesc;
    }

    public SetRsrvP(double RsrvPrice)
    {
        this.RsrvPrice = RsrvPrice;
    }
   
    public double GetHbid()
    {
        return HighestBid;
    }

}

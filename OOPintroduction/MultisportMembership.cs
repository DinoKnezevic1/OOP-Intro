using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    public class MultisportMembership:Membership
    {
        private int discount = 10;

        public MultisportMembership(int price) : base(price)
        {

        }

        public int Discount { get { return discount; } set { discount = value; } }

        public override int CalculateMembershipPrice()
        {
            return base.Price - discount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    public class StudentMembership:Membership
    {
        private int discount=5;
        private string college;

        public StudentMembership(int price) : base(price)
        {
        }

        public int Discount { get { return discount; } set { discount = value; } }
        public string College { get { return college; } set { college = value; } }

        public override int CalculateMembershipPrice()
        {
            return base.Price - Discount;
            
        }
    }
}

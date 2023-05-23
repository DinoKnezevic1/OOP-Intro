using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPintroduction
{
    public class Membership
    {
        private string name;
        private DateTime dateJoined;
        private bool active=true;
        private DateTime renewalDate;
        private int price;
        private Guid id;

        public Membership(int price)
        {
            this.price = price;
            id = Guid.NewGuid();
        }

        public string Name { get { return name; }set { name = value; } }
        public DateTime DateJoined { get { return dateJoined; } set { dateJoined = value; } }
        public bool Active { get { return active; } set { active = value; } }
        public DateTime RenewalDate { get { return renewalDate; }set { renewalDate = value; } }
        public int Price { get { return price; } }

        public virtual int CalculateMembershipPrice()
        {
            return price;
        }
    }
}

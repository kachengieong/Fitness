using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC330_CSharp_Midterm
{
    public class Guest : Person
    {
        private int days;

        public Guest()
        {

        }

        public Guest(string inName, string inID, int inDays):base(inName, inID)
        {
            days = inDays;
        }

        public int Days
        {
            get
            {
                return days;
            }

            set
            {
                days = value;
            }
        }

        public override string ToString()
        {
            return base.Name + base.Id + days;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC330_CSharp_Midterm
{
    public class Member : Person
    {
        public Member()
        {

        }

        public Member(string inName):base(inName)
        {

        }

        public Member(string inName, string inID):base(inName, inID)
        {

        }

        public override string ToString()
        {
            return base.Name + base.Id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC330_CSharp_Midterm
{
    public class Employee : Person
    {
        private string etype;

        public Employee()
        {
        }

        public Employee(string inName):base(inName)
        {
        }

        public Employee(string inName, string inEtype):base(inName)
        {
            etype = inEtype;
        }

        public Employee(string inName, string inID, string inEtype):base(inName,inID)
        {
            etype = inEtype;
        }

        public string Etype
        {
            get
            {
                return etype;
            }

            set
            {
                etype = value;
            }
        }

        public override string ToString()
        {
            return base.Name + base.Id + etype;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC330_CSharp_Midterm
{
    public class Gym
    {
        private string gname;
        private string equipment;
        private int quantity;

        public Gym()
        {
        }

        public Gym(string inGName)
        {
            gname = inGName;
        }

        public Gym(string inEquipment, int inQuantity)
        {
            equipment = inEquipment;
            quantity = inQuantity;
        }

        public string Gname
        {
            get
            {
                return gname;
            }

            set
            {
                gname = value;
            }
        }

        public string Equipment
        {
            get
            {
                return equipment;
            }

            set
            {
                equipment = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public override string ToString()
        {
            return "Gym Equipment: " + equipment + "Quantity: " + quantity;
        }
    }
}

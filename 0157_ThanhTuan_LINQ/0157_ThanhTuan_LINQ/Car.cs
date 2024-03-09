using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0157_ThanhTuan_LINQ
{
    class Car : Vehicle
    {
        private int numSlots;
        private String type;

        public int NumSlots { get => numSlots; set => numSlots = value; }
        public string Type { get => type; set => type = value; }
        public Car(String name,double price ,int year,String manufac,int numSlots,String type) : base(name,price,year,manufac)
        {
            this.numSlots = numSlots;
            this.type = type;
        }
        public Car(): base()
        {

        }
        public override string ToString()
        {
            return base.ToString() + $" || {this.numSlots} || {this.type}";
        }
    }
}

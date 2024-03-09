using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0157_ThanhTuan_LINQ
{
    class Truck:Vehicle
    {
        private String ownerCompany;
        private String maxLoads;

        public string OwnerCompany { get => ownerCompany; set => ownerCompany = value; }
        public string MaxLoads { get => maxLoads; set => maxLoads = value; }
        public Truck() : base()
        {

        }
        public Truck(String name,double price,int year,String manufac,String ownerCom,String maxL) : base(name,price,year,manufac)
        {
            this.ownerCompany = ownerCom;
            this.maxLoads = maxL;
        }
        public override string ToString()
        {
            return base.ToString() + $" || {this.ownerCompany} || {this.maxLoads}";
        }
    }
}

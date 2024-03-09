using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0157_ThanhTuan_LINQ
{
    class Vehicle
    {
        private String name;
        private double price;
        private int yearOfProduction;
        private String manufacturer;
        public Vehicle(String name,double price, int year, String manufac)
        {
            this.name = name;
            this.price = price;
            this.yearOfProduction = year;
            this.manufacturer = manufac;
        }
        public Vehicle()
        {

        }

        public string Name { get => Name1; set => Name1 = value; }
        public double Price { get => Price1; set => Price1 = value; }
        
        public string Manufacturer { get => Manufacturer1; set => Manufacturer1 = value; }
        public string Name1 { get => name; set => name = value; }
        public double Price1 { get => price; set => price = value; }
        public int YearOfProduction { get => yearOfProduction; set => yearOfProduction = value; }
        public string Manufacturer1 { get => manufacturer; set => manufacturer = value; }

        public override string ToString()
        {
            return $"{this.Name} || {this.Price} || {this.yearOfProduction} || {this.manufacturer}";
        }
    }
}

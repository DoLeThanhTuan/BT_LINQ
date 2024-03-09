using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0157_ThanhTuan_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 Tạo danh sách các Car
            List<Car> listCar = new List<Car>();
            Car car1 = new Car("Xpander",200000,2022,"Mitsubitshi",7,"MVP");
            Car car2 = new Car("Civic", 150000, 1890, "Honda", 5, "Sedan");
            Car car3 = new Car("Mercedes E300", 500000, 2024, "Mercedes",5, "Sedan");
            Car car4 = new Car("City", 100000, 2020, "Honda", 5, "Sedan");
            Car car5 = new Car("CR-V", 300000, 2000, "Honda", 7, "SUV");
            Car car6 = new Car("Mercedes E200", 400000, 2022, "Mercedes",5, "Sedan");
            listCar.Add(car1);
            listCar.Add(car2);
            listCar.Add(car3);
            listCar.Add(car4);
            listCar.Add(car5);
            listCar.Add(car6);
            // a. Hiển thị các xe có giá trong khoảng 100000 đến 250000
            Console.WriteLine("a. Danh sách xe có giá trong khoảng 100000 đến 250000");
            foreach(var car in listCar.Where(c => c.Price >= 100000 && c.Price <=250000) )
            {
                Console.WriteLine(car);
            }
            // b. các xe có năm sản xuất >1900
            Console.WriteLine("\nb. Danh sách xe có năm sản xuất > 1900");
            foreach(var car in listCar.Where(c=>c.YearOfProduction > 1900))
            {
                Console.WriteLine(car);
            }
            // c. gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
            Console.WriteLine("\nc. Tổng giá trị các xe theo hãng sản xuất");
            foreach(var car in listCar.GroupBy(c => c.Manufacturer)
                .Select(groupManufac => 
                new {Manufacture = groupManufac.Key,TotalPri = groupManufac.Sum(c=>c.Price) }))
            {
                Console.WriteLine($"{car.Manufacture } : {car.TotalPri}");
            }
            Console.ReadLine();
        }
    }
}

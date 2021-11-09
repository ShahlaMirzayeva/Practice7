using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzTuP01_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk[] MilksDataBase = new Milk[0];
            int coise = 1;
            while (coise != 0)
            {
                Console.WriteLine("Enter Opration : ");
                Console.WriteLine("1. DashBoard    2. Add Product   3. Sel Product    4.Exit");
                byte ope = Convert.ToByte(Console.ReadLine());
                switch (ope)
                {
                    case 1:
                        DashBoar(MilksDataBase);
                        break;
                    case 2:
                        AddProduct(ref MilksDataBase);
                        break;
                    case 3:
                        Console.WriteLine(Product.Sell());
                        break;
                    case 4:
                        coise = 0;
                        break;
                    default:
                        Console.WriteLine("ERROR : Giris sehvdir!");
                        break;
                }
            }
        }
        static void DashBoar(Milk[] DB)
        {
            if(DB.Length != 0)
            {
                foreach (var item in DB)
                {
                    Console.WriteLine($"{item.Name}   {item.Volume}   {item.FatRate}  {item.Price}    {item.TotalIncome}");
                }
            }
            else
            {
                Console.WriteLine("Baza Yaradilmayib");
            }

        }
        static void AddProduct(ref Milk[] DB)
        {
            while (true)
            {
                Console.WriteLine("Enter Milk name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Milk volume : ");
                byte volume = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Enter Milk FatRate : ");
                double fatRate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Milk Price : ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Milk count : ");
                int count = Convert.ToInt32(Console.ReadLine());
                Milk NewMilk = new Milk(name)
                {
                    Volume = volume,
                    FatRate = fatRate,
                    Price = price,
                    Count = count
                };
                Array.Resize(ref DB, DB.Length + 1);
                DB[DB.Length - 1] = NewMilk;
                Console.WriteLine();
                Console.WriteLine("Emeliyyata devam edilsin ? Y/N");
                char daxil = Convert.ToChar(Console.ReadLine());
                if (daxil == 'N' || daxil == 'n')
                {
                    Console.WriteLine("\nSucces : Pruductlar elave olundu\n");
                    break;
                }
            }

        }
    }
    class Product
    {
        public string Name;
        public double Price;
        public int Count;
        public double TotalIncome = 0;
        public Product(string name)
        {
            this.Name = name;
        }

        public static string Sell()
        {
            return "Product Satildi";
        }
    }

    class Milk : Product
    {
        public byte Volume;
        public double FatRate;
        public Milk(string name) :base(name)
        {
            this.Name = name;
        }
    }
}

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            // name = " " , email = "nhancholl@gmail.com";

            //Student sv = new Student()
            //{
            //    Id = "001",
            //    Name = "Nhan kc rach choll"
            //};
            //Console.WriteLine(sv.ToString());

            //Student other = new Student();
            //other.Id = "002";

            //  *  // 
            //var firstCar = new Vehicle()
            //{
            //    Brand = "Ferrari"
            //};

            //firstCar.Start();

            //var secondCar = new Cabriolet()
            //{
            //    Brand = "DM"
            //};
            //secondCar.Start();
            // * // 

            // * //
            //var vehicles = new List<Vehicle>()
            //{
            //    new EV(){Brand = "Lamborghini"},
            //    new EV(){Brand = "BMW"},
            //    new Cabriolet(){Brand = "Honda"},
            //    new EV(){Brand = "Mitsubishi"},
            //    new Cabriolet(){Brand = "Mazda"}
            //};

            //foreach (var vehicle in vehicles)
            //{
            //    vehicle.Start();
            //}
            // * //

            // * //
            //int[] a = { 1, 3, 5, 7, 11, 13, 17, 19, 23 };

            //Random rng = new Random();

            //for(int i = 0; i < 10; i++)
            //{
            //    int k = rng.Next(a.Length);
            //    int number = a[k];
            //    Console.WriteLine(number);
            //}

            // * //
            string filename = "Data.txt";
            List<Entry> entries = new List<Entry>();
            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);
                foreach (var line in lines)
                {
                    string[] tokens = line.Split(
                        new String[] { " - " }, 
                        StringSplitOptions.None
                    );

                    string left = tokens[0];
                    string right = tokens[1];

                    Entry entry = new Entry()
                    {
                        Left = left,
                        Right = right
                    };
                    entries.Add(entry);

                    Console.WriteLine($"Get data : Key={left} Value ={right}");
                }
            }
        }
        class Entry
        {
            public string Left { get; set; }
            public string Right { get; set; }
        }

        class Student
        {
            public Student()
            {

            }
           

            private string _id;
            private string _name;
            private string _email;
            private string _Tel;

            public string Id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }

            public string Name
            {
                get => _name;
                set => _name = value; // short-hand version for 1-line bracket 
            }
            public string Email { get => _email; set => _email = value; }
            public string Tel { get => _Tel; set => _Tel = value; }

            public override string ToString()
            {
                return $"Student ID={Id}, name ={Name}";
            }
            public void Registercourses()
            {

            }
            public void RequestAbsence()
            {

            }
        }
        class Vehicle
        {
            public string Brand { get; set; }

            public virtual void Start()
            {
                Console.WriteLine($"{Brand} is starting"); 
            }
        }
        class Car: Vehicle // default: public 
        {
            public override void Start()
            {
                Console.WriteLine("A car is starting");
                base.Start();
            }
        }
        class Cabriolet: Car
        {
            public override void Start()
            { 
                Console.WriteLine("Removing the hood");
                //Vehicle grandpa = (Vehicle)this;
                base.Start();
            }
        }
        
        class EV : Vehicle
        {
            public override void Start()
            {
                Console.WriteLine("Checking power consistency");
                base.Start(); 
            }
        }
    }
}

//Coding Convention
//private _camelCase _id
//public Casalcase Id
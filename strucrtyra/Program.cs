using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strucrtyra
{
    abstract class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public abstract string Name { get; set; }
        /// <summary>
        /// Возраст 
        /// </summary>
        public abstract int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            Age = age;
        }
        public abstract void Correct();
    }

    class Employee : Person
    {
        private string name;
        private int _age;
        public string Position { get; set; }
        public override string Name
        {
            get
            {
                return "Mr./Ms." + name;
            }
            set
            {
                name = value;
            }
        }
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("The age can't be null or 0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Employee(string name, int age, string position)
            : base(name, age)
        {
            Position = position;
        }
        public override void Correct()
        {
            if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Position) && Age == 0)
            {
                Console.WriteLine("The name and position can't be empty");
            }
            else
            {
                Console.WriteLine($"Name:{Name} \tAge:{Age} \tPosition:{Position}");
            }
        }
    }

    class Client : Person
    {
        private string _name;
        private int _age;
        public string IIN { get; set; }
        public string number { get; set; }
        public override string Name
        {
            get
            {
                return "Mr./Ms." + _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The name can't be empty");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("The age can't be null or 0");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public Client(string name, int age, string iin, string numb)
            : base(name, age)
        {
            IIN = iin;
            number = numb;
        }

        public override void Correct()
        {
            Console.WriteLine($"Name:{Name} \tAge:{Age} \tIIN:{IIN} \tPhone Number:{number}");
        }
    }



    class Phone
    {
        public string model;
        public string name;
        public double price;
        public string company;
       
        public Phone() : this(1564)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public Phone(string name) : this(name,"Uncnown", "Uncnown", 1254)
        {
        }
        public Phone(string name,string model):this(name,model, "Uncnown", 145)
        {

        }
        public Phone(double price) : this("Uncnown", "Uncnown", "Uncnown", price)
        {

        }
        public Phone(string model, double price) : this("Uncnown", model, "Uncnown",price)
        {

        }
        public Phone(string name, string model,string company, double price)
        {
            this.name = name;
            this.price = price;
            this.model = model;
            this.company = company;
        }


        public void Getinfo()
        {
            Console.WriteLine($"Name:{name} \tModel:{model} \tPrice:{price}");
        }
    }
    class Program
    {
        public static void Main()
        {
            //Client client = new Client("Asulbek", 22, "970615300619", "+7 700 022 93 00");
            //Employee employee = new Employee("Arman", 22, "Teacher of geographi");
            //client.Correct();
            //employee.Correct();



            Phone phone = new Phone("X",256164);
            phone.Getinfo();

            Console.Read();
        }
    }

}

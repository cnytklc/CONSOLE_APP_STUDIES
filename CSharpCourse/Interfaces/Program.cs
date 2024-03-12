using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interface Example

            //         IPersonalAddress personalAddress = new PersonalId();
            //         personalAddress.AddressCity("Izmir");
            //         personalAddress.AddressCountry("Turkey");
            //         personalAddress.Address("fthmhl. 494. sk. no: 5 d: 22");
            //         Console.ReadLine();

            //IFindArea areaFinder = new SolutionArea();
            //Console.WriteLine($"Area is: {areaFinder.findArea(5, 6)}");

            //Student student = new Student
            //{
            //    Name = "CNYT"

            //};

            //Teacher teacher = new Teacher
            //{
            //    Name = "KLC"
            //};

            //PersonMenager person = new PersonMenager();
            //person.Add(teacher);
            //person.Add(student);

            //*******************************************************************
            //DataServerChooseDAL dataServerChoose = new DataServerChooseDAL();
            //IDataServer sqlData = new SQLDataServerDAL();
            //IDataServer oracleData = new OracleDataServerDAL();

            //dataServerChoose.Add(sqlData);

            IDataServer[] dataServer = new IDataServer[2]
            {
                new SQLDataServerDAL(),
                new OracleDataServerDAL()
            };


            foreach (IDataServer server in dataServer)
            {
                server.Add();
            }
            Console.ReadLine();
        }
             }

    //public interface IPersonalAddress
    // {

    //     void Address(string address);
    //     void AddressCity(string city);
    //     void AddressCountry(string country);

    // }

    // class PersonalId : IPersonalAddress
    // {
    //     public void Address(string address)
    //     {
    //         Console.WriteLine(address);
    //     }

    //     public void AddressCity(string city)
    //     {
    //         Console.WriteLine(city);

    //     }

    //     public void AddressCountry(string country)
    //     {
    //         Console.WriteLine(country);

    //     }
    //         }


    //---------------------------------------------------------------------
    //Interface Example

    //        AnimalId dogId = new Dog();
    //        dogId.AnimalName();

    //        dogId.AnimalId();

    //        dogId.AnimalVoice();

    //        AnimalId catId = new Cat();
    //        catId.AnimalName();

    //        catId.AnimalId();

    //        catId.AnimalVoice();

    //        Console.ReadLine();

    //    }
    //}

    //interface AnimalId
    //{
    //    void AnimalId();
    //    void AnimalName();
    //    void AnimalHMLegs();
    //    void AnimalVoice();

    //}

    //class Dog : AnimalId
    //{
    //    public void AnimalHMLegs()
    //    {
    //        Console.WriteLine(4);
    //    }

    //    public void AnimalId()
    //    {
    //        Console.WriteLine("1");

    //    }

    //    public void AnimalName()
    //    {
    //        Console.WriteLine("-------------Dog-------------");

    //    }

    //    public void AnimalVoice()
    //    {
    //        Console.WriteLine("HOAW HOAW");

    //    }
    //}

    //class Cat : AnimalId
    //{
    //    public void AnimalHMLegs()
    //    {
    //        Console.WriteLine(4);
    //    }

    //    public void AnimalId()
    //    {
    //        Console.WriteLine("2");

    //    }

    //    public void AnimalName()
    //    {
    //        Console.WriteLine("*************Cat*************");

    //    }

    //    public void AnimalVoice()
    //    {
    //        Console.WriteLine("Miyaw Miyaww");

    //    }

    //-------------------------------------------------------------------------

    //Interface Example

    //interface IFindArea
    //{
    //    int findArea(int l, int r);
    //}

    //class SolutionArea : IFindArea
    //{
    //    public int findArea(int l, int r)
    //    {
    //        var solution = l * r;
    //        return solution;
    //    }
    //}
    //-----------------------------------------------------------------------------

    // Interface Example
    //interface IPerson
    //{
    //    string Name { get; set; }
    //    string LastName { get; set; }
    //    int Id { get; set; }
    //}
    //class Student : IPerson
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public int Id { get; set; }

    //}
    //class Teacher : IPerson
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }
    //    public int Id { get; set; }

    //}
    //class PersonMenager
    //{
    //    public void Add(IPerson person)
    //    {
    //        Console.WriteLine(person.Name);
    //    }   
    //}

    interface IDataServer
    {
        void Add();
        void Remove();
        void Update();
    }

    class SQLDataServerDAL : IDataServer
    {
        public void Add()
        {
            Console.WriteLine("SQL Added!");
        }

        public void Remove()
        {
        }

        public void Update()
        {
        }
    }

    class OracleDataServerDAL : IDataServer
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Remove()
        {
        }

        public void Update()
        {
        }
    }

    class DataServerChooseDAL
    {
        public void Add(IDataServer dataServer)
        {
            dataServer.Add();
        }
    }
}
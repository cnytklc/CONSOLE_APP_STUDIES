using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }


}

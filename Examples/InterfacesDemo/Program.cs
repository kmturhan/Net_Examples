class Program
{
    static void Main(string[] args)
    {
        List<IWorker> workers = new List<IWorker>()
        {
            new Manager(),
            new Worker(),
            new Robot()
        };
        foreach (var worker in workers)
        {
            worker.Work();
        }

        List<IEat> eats = new List<IEat>()
        {
            new Worker(),
            new Manager()
        };
        foreach (var eat in eats)
        {
            eat.Eat();
        }

        Console.ReadLine();
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
    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Manager Work");
        }

        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager Salary");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Work()
        {
            
            Console.WriteLine("Worker Work");
        }

        public void Eat()
        {
            
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            
            Console.WriteLine("Worker Salary");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot Work");
        }
    }
}
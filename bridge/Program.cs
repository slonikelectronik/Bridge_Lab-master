using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory volvo = new Factory();

            Abstraction abstraction;

            abstraction = new Abstraction(new Abobus());
            volvo.DoSmth(abstraction);

            abstraction = new Abstraction(new Car());
            volvo.DoSmth(abstraction);
        }
    }
}

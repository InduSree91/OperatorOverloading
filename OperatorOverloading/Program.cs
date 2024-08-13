using System;
// Operator Overloading
namespace OperatorOverloading
{
    class NewClass
    {
        public string Name;
        public int Age;

        public static NewClass operator + (NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.Name = obj1.Name + " " + obj2.Name;
            obj3.Age = obj1.Age + obj2.Age;
            return obj3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            obj1.Name = "Sai";
            obj1.Age = 27;

            NewClass obj2 = new NewClass();
            obj2.Name = "Ram";
            obj2.Age = 29;

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.Name);
            Console.WriteLine(obj3.Age);
        }
    }
}
using System;

namespace Human
{
    class Program
    {
        public static void Main(string[] args)
        {
            Human myHuman = new Human("Luffy");
            object BoxedData = myHuman;
            myHuman.Attack(BoxedData);
            System.Console.WriteLine(myHuman.hHealth);
            
        }
    }
}

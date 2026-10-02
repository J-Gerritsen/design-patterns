namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            Console.WriteLine(boiler1 == boiler2);

            boiler1.fill();
            Console.WriteLine("This is empty " + boiler1.IsEmpty);

            boiler1.boil();
            Console.WriteLine("This is boiled " + boiler1.IsBoiled);

            boiler1.drain();
            Console.WriteLine(" This is empty again " + boiler1.IsEmpty);
        }
    }
}
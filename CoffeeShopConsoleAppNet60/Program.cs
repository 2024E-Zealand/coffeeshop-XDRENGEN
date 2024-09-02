using System;

namespace CoffeeShopConsoleAppNet60
{
    class Program
    {
        static void Main(string[] args)
        {
            // Der opretter instanser af Latte og BlackCoffee
            Coffee latte = new Latte();
            Coffee blackCoffee = new BlackCoffee();
            Coffee cortado = new Cortado();



            // Konsollen udskriver priser, styrke og mængde af mælk.
            Console.WriteLine("Price of Latte: " + latte.Price() + " DKK, Strength:" + latte.Strength() + ", Latte has " + ((IMilk)latte).mlMilk() + " ml of milk.");

            Console.WriteLine("Price of Black Coffee: " + blackCoffee.Price() + " DKK, Strength:" + blackCoffee.Strength());

            Console.WriteLine("Price of Cortado Coffee: " + cortado.Price() + " DKK, Strength:" + cortado.Strength() + ", Cortado has " + ((IMilk)cortado).mlMilk() + " ml of milk.");



            //Gør at jeg kan se resultaterne.
            Console.ReadLine();
        }
    }
}

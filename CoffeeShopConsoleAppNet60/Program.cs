using CoffeeShopConsoleAppNet60;
using System;

// Der oprettes instanser af kafferne og tallet i () er discount i %
Coffee Latte = new Latte(5);
Coffee BlackCoffee = new BlackCoffee(12);
Coffee Cortado = new Cortado(7);



// Konsollen udskriver priser, styrke og mængde af mælk.
Console.WriteLine("Price of Latte: " + Latte.PriceWithDiscount() + " DKK, Strength:" + Latte.Strength() + ", Latte has " + ((IMilk)Latte).mlMilk() + " ml of milk.");
Console.WriteLine("Price of Black Coffee: " + BlackCoffee.PriceWithDiscount() + " DKK, Strength:" + BlackCoffee.Strength());
Console.WriteLine("Price of Cortado: " + Cortado.PriceWithDiscount() + " DKK, Strength:" + Cortado.Strength() + ", Cortado has " + ((IMilk)Cortado).mlMilk() + " ml of milk.");



//Gør at jeg kan se resultaterne.
Console.ReadLine();

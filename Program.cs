using System;

class Program
{
    static void Main(string[] args) {
        int gold;
        int cristalPrise = 52;
        int crystalsToBuy;

        Console.Write("Сколько золота вы хотите? ");
        gold = Convert.ToInt32(Console.ReadLine());
        Console.Write("Сколько кристаллов вы хотите купить? ");
        crystalsToBuy = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        gold -= crystalsToBuy * cristalPrise;
        Console.WriteLine($"Количество кристаллов {crystalsToBuy}, остаток золота {gold}");
    }
}

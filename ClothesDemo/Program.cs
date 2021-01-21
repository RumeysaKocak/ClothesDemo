using System;

namespace ClothesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes clothes1 = new Clothes();
            clothes1.Id = 1;
            clothes1.ClothesName = "Sweatshirt";
            clothes1.CategoryId = 2;
            clothes1.UnitInStock = 30;
            clothes1.UnitPrice = 70;

            Clothes clothes2 = new Clothes();
            clothes2.Id = 2;
            clothes2.ClothesName = "Skirt";
            clothes2.CategoryId = 3;
            clothes2.UnitInStock = 5;
            clothes2.UnitPrice = 50.60;

            Clothes clothes3 = new Clothes();
            clothes3.Id = 3;
            clothes3.ClothesName = "Trousers";
            clothes3.CategoryId = 5;
            clothes3.UnitInStock = 70;
            clothes3.UnitPrice = 92.50;

            Clothes[] clothes = new Clothes[] { clothes1, clothes2, clothes3 };

            for (int i = 0; i < clothes.Length; i++)
            {
                Console.Write(clothes[i].Id+ "-)" );
                Console.WriteLine("Clothes Name : " + clothes[i].ClothesName);
                Console.WriteLine("Clothes Price: " + clothes[i].UnitPrice);
            }

            Console.WriteLine("-------------- Finished Of For Loop  :) ----------------- ");

            foreach (Clothes clothes0 in clothes)
            {
                Console.Write(clothes0.Id + "-)");
                Console.WriteLine("Clothes Name : " + clothes0.ClothesName);
                Console.WriteLine("Clothes Price: " + clothes0.UnitPrice);
            }

            Console.WriteLine("-------------- Finished Of Foreach Loop  :)) ----------------- ");

            int x = 0;
            while (x < clothes.Length)
            {
                Console.Write(clothes[x].Id + "-)");
                Console.WriteLine("Clothes Name : " + clothes[x].ClothesName);
                Console.WriteLine("Clothes Price: " + clothes[x].UnitPrice);
                x++;
            }
            
            Console.WriteLine("-------------- Finished Of While Loop  :D ----------------- ");
            Console.ReadKey();
        }
    }
}

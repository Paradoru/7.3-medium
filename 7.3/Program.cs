using System;

namespace _7._3
{
    class Program
    {
        struct product
        {
            public string name;
            public string maker;
            public string type;
            public DateTime dateOfEntry;
            public DateTime dateOfReg;
        }
        static void Main(string[] args)
        {
            product[] products = new product[3];
            for (int i = 0; i < products.Length; i++)
            {
                Console.Write("Введите название " + (i + 1) + " машины(ford): ");
                products[i].name = (Console.ReadLine());
                if (products[i].name=="ford")
                {
                    products[i].name = "Ford";
                }
                Console.Write("Введите производителя: ");
                products[i].maker = Console.ReadLine();
                Console.Write("Введите тип : ");
                products[i].type = Console.ReadLine();
                Console.Write("Введите год выпуска: ");
                products[i].dateOfEntry = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите дату регистрации: ");
                products[i].dateOfReg = Convert.ToDateTime(Console.ReadLine());
            }
            foreach (product item in products)
            {
                if (item.dateOfReg.Year == 2000 && item.name == "Ford")
                {
                    Console.WriteLine(item.maker+", "+item.type+", "+item.dateOfEntry+", "+item.dateOfReg);
                }
            }

        }
    }
}

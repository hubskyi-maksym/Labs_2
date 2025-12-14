using System;

namespace ToyStoreMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n=== Головне меню ===");
            Console.ResetColor();

            Console.WriteLine("1. Каталог іграшок");
            Console.WriteLine("2. Категорії");
            Console.WriteLine("3. Клієнти");
            Console.WriteLine("4. Замовлення");
            Console.WriteLine("0. Вихід");
            Console.Write("Ваш вибір: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ToysMenu();
                        break;
                    case 2:
                        CategoriesMenu();
                        break;
                    case 3:
                        ClientsMenu();
                        break;
                    case 4:
                        OrdersMenu();
                        break;
                    case 0:
                        Console.WriteLine("Вихід з програми...");
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення!");
            }

            MainMenu();
        }
        static void ToysMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n=== Каталог іграшок ===");
            Console.ResetColor();

            Console.WriteLine("1. Переглянути всі іграшки");
            Console.WriteLine("2. Додати іграшку");
            Console.WriteLine("3. Редагувати іграшку");
            Console.WriteLine("4. Видалити іграшку");
            Console.WriteLine("0. Назад");
            Console.Write("Ваш вибір: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShowToys();
                        break;
                    case 2:
                        Stub();
                        break;
                    case 3:
                        Stub();
                        break;
                    case 4:
                        Stub();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення!");
            }

            ToysMenu();
        }
        static void CategoriesMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=== Категорії ===");
            Console.ResetColor();

            Console.WriteLine("1. Переглянути категорії");
            Console.WriteLine("2. Додати категорію");
            Console.WriteLine("3. Редагувати категорію");
            Console.WriteLine("4. Видалити категорію");
            Console.WriteLine("0. Назад");
            Console.Write("Ваш вибір: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Stub();
                        break;
                    case 2:
                        Stub();
                        break;
                    case 3:
                        Stub();
                        break;
                    case 4:
                        Stub();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення!");
            }

            CategoriesMenu();
        }
        static void ClientsMenu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n=== Клієнти ===");
            Console.ResetColor();

            Console.WriteLine("1. Переглянути список клієнтів");
            Console.WriteLine("2. Додати клієнта");
            Console.WriteLine("3. Редагувати дані клієнта");
            Console.WriteLine("4. Видалити клієнта");
            Console.WriteLine("0. Назад");
            Console.Write("Ваш вибір: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Stub();
                        break;
                    case 2:
                        Stub();
                        break;
                    case 3:
                        Stub();
                        break;
                    case 4:
                        Stub();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення!");
            }

            ClientsMenu();
        }
        static void OrdersMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=== Замовлення ===");
            Console.ResetColor();

            Console.WriteLine("1. Створити нове замовлення");
            Console.WriteLine("2. Переглянути замовлення");
            Console.WriteLine("3. Змінити статус замовлення");
            Console.WriteLine("4. Видалити замовлення");
            Console.WriteLine("0. Назад");
            Console.Write("Ваш вибір: ");

            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculatePurchase();
                        break;
                    case 2:
                        Stub();
                        break;
                    case 3:
                        Stub();
                        break;
                    case 4:
                        Stub();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Невірний вибір!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Помилка введення!");
            }

            OrdersMenu();
        }
        static void CalculatePurchase()
        {
            double priceDoll = 250.00;
            double priceCar = 180.00;
            double priceLego = 520.00;
            double priceBear = 300.00;

            try
            {
                Console.Write("Кількість ляльок: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.Write("Кількість машинок: ");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.Write("Кількість конструкторів: ");
                int l = Convert.ToInt32(Console.ReadLine());

                Console.Write("Кількість м'яких іграшок: ");
                int b = Convert.ToInt32(Console.ReadLine());

                double total = d * priceDoll + c * priceCar + l * priceLego + b * priceBear;
                Random rnd = new Random();
                double discount = total * rnd.NextDouble() * 0.1;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\nСума: {Math.Round(total, 2)} грн");
                Console.WriteLine($"Знижка: {Math.Round(discount, 2)} грн");
                Console.WriteLine($"До оплати: {Math.Round(total - discount, 2)} грн");
                Console.ResetColor();
            }
            catch
            {
                Console.WriteLine("Помилка при введенні даних!");
            }
        }
        static void Stub()
        {
            Console.WriteLine("\nФункція в розробці...");
        }
        static void ShowToys()
        {
            Console.WriteLine("\nСписок іграшок:");
            Console.WriteLine("Лялька - 250.00");
            Console.WriteLine("Машинка - 180.00");
            Console.WriteLine("Конструктор - 520.00");
            Console.WriteLine("М'яка іграшка - 300.00");
        }
    }
}

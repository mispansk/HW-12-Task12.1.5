using System;
using System.Threading;

namespace HW_12_Task12._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем трех пользователей (для примера)
            User[] users = new User[3];
            users[0] = new User
            {
                Name = "Светлана",
                Login = "sdlfkjg",
                IsPremium = true
            };

            users[1] = new User
            {
                Name = "Алексей",
                Login = "sdlfkjg1",
                IsPremium = false
            };

            users[2] = new User
            {
                Name = "Мария",
                Login = "sdlfkjg2",
                IsPremium = true
            };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\nПривет, "+ users[i].Name); // приветствие пользователя
                Thread.Sleep(1000);
                if (users[i].IsPremium)
                {                 
                    Console.WriteLine("Рады, что вы с нами :)"); // если есть подписка
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ShowAds();                                  // реклама, если нет подписки
                    Console.ForegroundColor = ConsoleColor.White;
                }                 
            }
            Console.ReadKey();
        }
        /// <summary>
        /// метод для показа рекламы
        /// </summary>
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}

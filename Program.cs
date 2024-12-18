using System;
using System.Runtime.CompilerServices;

namespace KimMilyonerOlmakIster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kim Milyoner Olmak İster'e hoşgeldiniz!!\nYarışmacımızı tanıyalım. Adınızı giriniz:");
            string? userName = Console.ReadLine();
            Console.WriteLine($"Yarışmamıza hoşgeldiniz {userName}. İlk sorumuzla başlayalım:");

            Console.WriteLine("\nLeonardo da Vinci'nin ünlü eseri \"Son Akşam Yemeği\" hangi teknikle yapılmıştır?");
            Console.WriteLine("A:Fresk\nB:Yağlı Boya");

            int userScore = 0;

            string? userInput = Console.ReadLine();

            userInput = userInput ?? "";
            string userOut = userInput.ToUpper();

            if (Enum.TryParse(userOut, out Options options))
            {
                if (options == Options.A)
                {
                    userScore++;
                    Console.WriteLine("Doğru");
                }
                else if (options == Options.B)
                {
                    Console.WriteLine("Yanlış");
                }
                else
                {
                    Console.WriteLine("boş");
                }
            }

            Console.WriteLine("\n----------------------------------------\n");

            Console.WriteLine("Güneş Sistemi’ndeki en büyük doğal uydu hangisidir?");
            Console.WriteLine("A:Titan\nB:Ganymede");

            userInput = Console.ReadLine();

            userInput = userInput ?? "";
            userOut = userInput.ToUpper();

            if (Enum.TryParse(userOut, out options))
            {
                if (options == Options.B)
                {
                    userScore++;
                    Console.WriteLine("Doğru");
                }
                else if (options == Options.A)
                {
                    Console.WriteLine("Yanlış");
                }
                else
                {
                    Console.WriteLine("boş");
                }
            }

            if(userScore == 2)
            {
                ScoreStatus(userScore);
            }
            else
            {
                Console.WriteLine("\n----------------------------------------\n");

                Console.WriteLine("“Mutluluk, erdemli bir yaşamın sonucudur” düşüncesini savunan filozof kimdir?");
                Console.WriteLine("A:Epikür\nB:Aristoteles");

                userInput = Console.ReadLine();

                userInput = userInput ?? "";
                userOut = userInput.ToUpper();

                if (Enum.TryParse(userOut, out options))
                {
                    if (options == Options.B)
                    {
                        userScore++;
                        Console.WriteLine("Doğru");
                    }
                    else if (options == Options.A)
                    {
                        Console.WriteLine("Yanlış");
                    }
                    else
                    {
                        Console.WriteLine("boş");
                    }
                }
            }

            ScoreStatus(userScore);
        }

        public static void ScoreStatus(int userScore)
        {
            if (userScore >= 2)
            {
                Console.WriteLine($"\nTebrikler!! Büyük ödülü kazandınız.\nSkorunuz: {userScore}");
            }
            else
            {
                Console.WriteLine($"\nNe yazık ki ödülü kazanamadınız:(. Bir dahaki sefere;).\nSkorunuz: {userScore}");
            }
        }

    }

    enum Options
    {
        A,
        B
    }
}
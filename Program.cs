using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            Console.WriteLine("Найти сумму чётных чисел.");
            int a;
            Console.WriteLine("Введите число:");
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);
            int sum = 0;
            int b = a;
            while(a != 0)
            {
                int rest = a % 10;
                //Console.WriteLine(rest);
                if (rest % 2 == 0)
                    sum = sum + rest;
                a /= 10;
            }
            Console.WriteLine($"Сумма четных цифр числа {b} равна {sum}\n\n");

            //Number 2
            Console.WriteLine("Сделать умножение чисел друг на друга через сумму.");
            Console.WriteLine("Введите первое число:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string str2 = Console.ReadLine();
            int number1 = Convert.ToInt32(str1);
            int number2 = Convert.ToInt32(str2);
            int prod = 0;
            for(int i = 0; i < number2; i++)
            {
                prod = prod + number1;
            }
            Console.WriteLine($"{number1} * {number2} = {prod}\n\n");

            //Number 3 
            Console.WriteLine("Игра угадайка.");
            int from = -10;
            int to = 10;
            Random rnd = new Random();
            int randomNumber = rnd.Next(from, to);
            //Console.WriteLine(randomNumber);

            bool rightEnter = false;
            int inputNumber;
            string userInput;
            int count = 1;

            Console.WriteLine("Введите число от -10 до 10: ");
            while (!rightEnter)
            {
                Console.WriteLine("Если Вы устрали и хотите выйти, то нажмите q.");
                userInput = Console.ReadLine();
                char ex = Convert.ToChar(userInput);
                rightEnter = int.TryParse(userInput, out inputNumber);

                if (ex == 'q')
                {
                    Console.WriteLine("Очень жаль :(\n\n");
                    break;
                }
                    
                if (randomNumber == inputNumber)
                {
                    Console.WriteLine($"Молодцы! Вы угадали число с {count} попытки!\n\n");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, попробуйте снова!");
                    rightEnter = false;
                }
                count++;
            }

            //Number 4
            Console.WriteLine("Определить из каких цифр состоит число.");
            Console.WriteLine("Введите число:");
            string str3 = Console.ReadLine();
            int number = Convert.ToInt32(str3);
            int NumberCopy = number;
            int c = 0;

            while (NumberCopy != 0)
            {
                NumberCopy /= 10;
                c++;
            }

            int [] array = new int[c];
           for(int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = number % 10;
                number /= 10;
            }
            Console.WriteLine("Ваше число состоит из цифр: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
            Console.WriteLine("\n\n");

            //Number 5
            Console.WriteLine("Перевернуть число.");
            Console.Write("Ваше число: ");
            string str4 = Console.ReadLine();
            int abc = Convert.ToInt32(str4);
            int cba = 0;
            while(abc != 0)
            {
                cba = cba * 10 + abc % 10;
                abc /= 10;
            }
            Console.WriteLine($"Перевернутое число: {cba}");

            Console.Read();
        }

    }
}
